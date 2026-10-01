using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x04c588c5 : MonoBehaviour
{
    private const float TargetRatio = 7f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xdb53a9f8(Object _0x0fd0dcd8)
    {
        TMP_Text _0xc7b73305 = _0x0fd0dcd8 as TMP_Text;
        if (_0xc7b73305 != null)
            this._0x91d9349e.Add(_0xc7b73305);
    }

    private static float Linear(float _0x776af11b)
    {
        _0x776af11b = Mathf.Clamp01(_0x776af11b);
        return _0x776af11b <= 0.03928f ? _0x776af11b / 12.92f : Mathf.Pow((_0x776af11b + 0.055f) / 1.055f, 2.4f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x26954b04 != null)
            return;
        GameObject _0xd64174cd = new GameObject(_0x70758935._0xebb66331(new byte[16] { 225, 216, 197, 246, 218, 219, 193, 199, 212, 198, 193, 242, 192, 212, 199, 209 }, 181));
        _0xd64174cd.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xd64174cd);
        _0x26954b04 = _0xd64174cd.AddComponent<_0x04c588c5>();
    }

    private static _0x04c588c5 _0x26954b04;
    private readonly HashSet<TMP_Text> _0x91d9349e = new HashSet<TMP_Text>();
    private static float Ratio(Color _0xb1b6b420, Color _0x6f15a7c8)
    {
        float _0x1f397f50 = Luminance(_0xb1b6b420);
        float _0x107ae041 = Luminance(_0x6f15a7c8);
        return (Mathf.Max(_0x1f397f50, _0x107ae041) + 0.05f) / (Mathf.Min(_0x1f397f50, _0x107ae041) + 0.05f);
    }

    private static void Fix(TMP_Text _0x1f07e34d)
    {
        if (_0x1f07e34d == null || !_0x1f07e34d.isActiveAndEnabled)
            return;
        Material _0x15a1069c = _0x1f07e34d.fontSharedMaterial;
        if (_0x15a1069c == null || !_0x15a1069c.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x15a1069c.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x15a1069c.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x14906fc5 = _0x1f07e34d.color;
        if (_0x14906fc5.a <= 0f)
            return;
        Color _0x4913327f = _0x15a1069c.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x14906fc5, _0x4913327f) >= MinRatio)
            return;
        Color _0x44895153 = Luminance(_0x4913327f) < 0.5f ? Color.white : Color.black;
        Color _0xc60828ff;
        if (Ratio(_0x44895153, _0x4913327f) < TargetRatio)
        {
            _0xc60828ff = _0x44895153;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x0ef0bd7b = 0f;
            float _0xc4ceba58 = 1f;
            for (int _0x75657a19 = 0; _0x75657a19 < 20; _0x75657a19++)
            {
                float _0x90e99de6 = (_0x0ef0bd7b + _0xc4ceba58) * 0.5f;
                if (Ratio(Color.Lerp(_0x14906fc5, _0x44895153, _0x90e99de6), _0x4913327f) >= TargetRatio)
                    _0xc4ceba58 = _0x90e99de6;
                else
                    _0x0ef0bd7b = _0x90e99de6;
            }

            _0xc60828ff = Color.Lerp(_0x14906fc5, _0x44895153, _0xc4ceba58);
        }

        _0xc60828ff.a = _0x14906fc5.a;
        _0x1f07e34d.color = _0xc60828ff;
    }

    private const float MinRatio = 4.5f;
    private const float MinOutlineWidth = 0.01f;
    private void LateUpdate()
    {
        if (this._0x91d9349e.Count == 0)
            return;
        this._0xdf546469.Clear();
        this._0xdf546469.AddRange(this._0x91d9349e);
        this._0x91d9349e.Clear();
        for (int _0xb007bb43 = 0; _0xb007bb43 < this._0xdf546469.Count; _0xb007bb43++)
            Fix(this._0xdf546469[_0xb007bb43]);
    }

    private void OnEnable()
    {
        if (this._0xe4c479ce == null)
            this._0xe4c479ce = _0xf62cd7c6 => this._0xdb53a9f8(_0xf62cd7c6);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xe4c479ce);
    }

    private readonly List<TMP_Text> _0xdf546469 = new List<TMP_Text>();
    private void OnDisable()
    {
        if (this._0xe4c479ce != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xe4c479ce);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xe4c479ce;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x4cefe1e0)
    {
        return 0.2126f * Linear(_0x4cefe1e0.r) + 0.7152f * Linear(_0x4cefe1e0.g) + 0.0722f * Linear(_0x4cefe1e0.b);
    }
}

internal static class _0x70758935
{
    internal static string _0xebb66331(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}