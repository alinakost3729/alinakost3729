using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The circuit picker. It lives inside the menu rather than behind a screen of its
/// own on purpose: an extra screen between the menu and the board is somewhere a
/// player - and an automated capture - can get stuck, and nothing here is worth that.
/// Picking a circuit has to be visibly answered, so a tap moves the highlight, redraws
/// the little schematic above the row AND rewrites the summary line; a locked chip is
/// refused with a shake and a sentence saying what would open it.
/// </summary>
public sealed class _0xfbce4001 : MonoBehaviour
{
    private const float RefusalSeconds = 2f;
    private void Chip(Transform _0x53527990, int _0x0e555606)
    {
        RectTransform _0x5c0fe2ae = _0x4538f874.Node(_0x53527990, _0xf4c6cf35._0xd2b48cd5(new byte[4] { 166, 141, 140, 149 }, 229) + _0x0e555606.ToString(), new Vector2(0.5f, 0.5f), new Vector2(230f, 170f));
        _0x5c0fe2ae.anchoredPosition = new Vector2((_0x0e555606 - 1.5f) * 260f, 0f);
        Image _0x14e5e16b = _0x5c0fe2ae.gameObject.AddComponent<Image>();
        _0x14e5e16b.raycastTarget = true;
        if (this._0x28daa5a2 != null)
        {
            _0x14e5e16b.sprite = this._0x28daa5a2;
            _0x14e5e16b.type = Image.Type.Sliced;
        }

        RectTransform _0xbfad3592 = _0x4538f874.Stretch(_0x5c0fe2ae, _0xf4c6cf35._0xd2b48cd5(new byte[8] { 167, 140, 141, 148, 162, 141, 136, 136 }, 228) + _0x0e555606.ToString());
        _0xbfad3592.offsetMin = new Vector2(5f, 5f);
        _0xbfad3592.offsetMax = new Vector2(-5f, -5f);
        Image _0xcbf40187 = _0xbfad3592.gameObject.AddComponent<Image>();
        _0xcbf40187.raycastTarget = false;
        if (this._0x28daa5a2 != null)
        {
            _0xcbf40187.sprite = this._0x28daa5a2;
            _0xcbf40187.type = Image.Type.Sliced;
        }

        bool _0x035eb1fc = _0xcf552857.IsOpen(_0x0e555606);
        _0x4538f874.Label(_0x5c0fe2ae, _0xf4c6cf35._0xd2b48cd5(new byte[11] { 84, 127, 126, 103, 89, 98, 122, 114, 101, 118, 123 }, 23) + _0x0e555606.ToString(), _0xd9cb9715.Numeral(_0x0e555606), new Vector2(0.5f, 0.62f), new Vector2(200f, 86f), NumeralSize, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
        _0x4538f874.Label(_0x5c0fe2ae, _0xf4c6cf35._0xd2b48cd5(new byte[8] { 169, 130, 131, 154, 164, 133, 158, 143 }, 234) + _0x0e555606.ToString(), _0x035eb1fc ? _0xf4c6cf35._0xd2b48cd5(new byte[7] { 122, 97, 102, 111, 123, 8, 30 }, 40) : _0xf4c6cf35._0xd2b48cd5(new byte[6] { 208, 211, 223, 215, 217, 216 }, 156), new Vector2(0.5f, 0.24f), new Vector2(200f, 44f), SmallSize, _0x2910d7f9.TextSecondary, TextAlignmentOptions.Center);
        Button _0x32ae6dc8 = _0x5c0fe2ae.gameObject.AddComponent<Button>();
        _0x32ae6dc8.targetGraphic = _0xcbf40187;
        int _0x14405bca = _0x0e555606;
        _0x32ae6dc8.onClick.AddListener(() => this._0xe7cbc069(_0x14405bca));
        this._0x873810d8.Add(_0x5c0fe2ae);
        this._0xf1a6ca87.Add(_0x14e5e16b);
        this._0x64afbd81.Add(_0xcbf40187);
    }

    private Sprite _0x28daa5a2;
    private readonly List<Image> _0x64afbd81 = new List<Image>();
    private TextMeshProUGUI _0xe55c7ae9;
    private Tween _0xa8effbc9;
    private const float SmallSize = 28f;
    private void _0xe7cbc069(int _0x5fd463a3)
    {
        if (!_0xcf552857.IsOpen(_0x5fd463a3))
        {
            this._0x90c671bd(_0x5fd463a3);
            return;
        }

        _0xcf552857._0xc42aaad0 = _0x5fd463a3;
        this._0x5b1091c8();
        if (_0x5fd463a3 < this._0x873810d8.Count)
        {
            RectTransform _0x975b4568 = this._0x873810d8[_0x5fd463a3];
            DOTween.Kill(_0x975b4568, true);
            _0x975b4568.localScale = Vector3.one;
            _0x975b4568.DOScale(Vector3.one * 1.06f, 0.15f);
        }
    }

    private readonly List<Image> _0xf1a6ca87 = new List<Image>();
    public void _0x8f30ae17(Transform _0xdeb10d1d, Sprite _0xf81beb71, Sprite _0x8fff342f)
    {
        this._0x28daa5a2 = _0xf81beb71;
        _0x4538f874.Label(_0xdeb10d1d, _0xf4c6cf35._0xd2b48cd5(new byte[13] { 190, 148, 143, 158, 136, 148, 137, 142, 169, 148, 137, 145, 152 }, 253), _0xf4c6cf35._0xd2b48cd5(new byte[8] { 197, 207, 212, 197, 211, 207, 210, 213 }, 134), new Vector2(0.5f, 0.555f), new Vector2(700f, 54f), 34f, _0x2910d7f9.TextSecondary, TextAlignmentOptions.Center);
        RectTransform _0xb98915e8 = _0x4538f874.Node(_0xdeb10d1d, _0xf4c6cf35._0xd2b48cd5(new byte[14] { 245, 223, 196, 213, 195, 223, 194, 230, 196, 211, 192, 223, 211, 193 }, 182), new Vector2(0.5f, 0.512f), new Vector2(1040f, 56f));
        for (int _0xf5d7128b = 0; _0xf5d7128b < 8; _0xf5d7128b++)
        {
            Image _0x38858fe6 = _0x4538f874.Picture(_0xb98915e8, _0xf4c6cf35._0xd2b48cd5(new byte[3] { 204, 245, 236 }, 156) + _0xf5d7128b.ToString(), new Vector2(0.5f, 0.5f), new Vector2(26f, 26f), _0x8fff342f, _0x2910d7f9.Cyan);
            _0x38858fe6.rectTransform.anchoredPosition = new Vector2((_0xf5d7128b - 3.5f) * 56f, 0f);
            this._0x191a8989.Add(_0x38858fe6);
        }

        this._0xe55c7ae9 = _0x4538f874.Label(_0xdeb10d1d, _0xf4c6cf35._0xd2b48cd5(new byte[14] { 251, 209, 202, 219, 205, 209, 204, 235, 205, 213, 213, 217, 202, 193 }, 184), string.Empty, new Vector2(0.5f, 0.452f), new Vector2(1000f, 50f), SmallSize, _0x2910d7f9.TextSecondary, TextAlignmentOptions.Center);
        RectTransform _0x2c157ce4 = _0x4538f874.Node(_0xdeb10d1d, _0xf4c6cf35._0xd2b48cd5(new byte[10] { 245, 223, 196, 213, 195, 223, 194, 228, 217, 193 }, 182), new Vector2(0.5f, 0.398f), new Vector2(1040f, 190f));
        for (int _0x46f1f273 = 0; _0x46f1f273 < _0xd9cb9715.CircuitCount; _0x46f1f273++)
            this.Chip(_0x2c157ce4, _0x46f1f273);
        this._0x5b1091c8();
    }

    private const float NumeralSize = 68f;
    /// <summary>Repaints the row, the schematic and the summary from the stored pick.</summary>
    public void _0x5b1091c8()
    {
        int _0x3b07fbf1 = _0xcf552857._0xc42aaad0;
        for (int _0xbec6eacd = 0; _0xbec6eacd < this._0x873810d8.Count; _0xbec6eacd++)
        {
            bool _0xe9ea36e6 = _0xcf552857.IsOpen(_0xbec6eacd);
            bool _0x73f3df81 = _0xe9ea36e6 && _0xbec6eacd == _0x3b07fbf1;
            this._0xf1a6ca87[_0xbec6eacd].color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, _0x73f3df81 ? 1f : 0.25f);
            this._0x64afbd81[_0xbec6eacd].color = _0xe9ea36e6 ? (_0x73f3df81 ? _0x2910d7f9.Surface : _0x2910d7f9.SurfaceDim) : _0x2910d7f9.BaseDeep;
            RectTransform _0xddc5ae9f = this._0x873810d8[_0xbec6eacd];
            DOTween.Kill(_0xddc5ae9f, true);
            _0xddc5ae9f.localScale = Vector3.one * (_0x73f3df81 ? 1.06f : 1f);
        }

        int _0xf2cbbe95 = _0xd9cb9715.Pegs(_0x3b07fbf1);
        int _0x8ec9dbf6 = Mathf.Clamp(_0xd9cb9715.Bands(_0x3b07fbf1) + _0x3b07fbf1, 1, this._0x191a8989.Count);
        for (int _0x84a656c5 = 0; _0x84a656c5 < this._0x191a8989.Count; _0x84a656c5++)
        {
            this._0x191a8989[_0x84a656c5].color = _0x84a656c5 < _0x8ec9dbf6 ? _0x2910d7f9.Cyan : _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.18f);
        }

        if (this._0xe55c7ae9 == null)
            return;
        this._0xe55c7ae9.color = _0x2910d7f9.TextSecondary;
        this._0xe55c7ae9.text = _0xf4c6cf35._0xd2b48cd5(new byte[6] { 89, 66, 69, 76, 88, 43 }, 11) + _0xd9cb9715.RingsPerCircuit.ToString() + _0xf4c6cf35._0xd2b48cd5(new byte[8] { 34, 47, 34, 82, 71, 69, 81, 34 }, 2) + _0xf2cbbe95.ToString();
    }

    private readonly List<Image> _0x191a8989 = new List<Image>();
    private void OnDestroy()
    {
        if (this._0xa8effbc9 != null && this._0xa8effbc9.IsActive())
            this._0xa8effbc9.Kill();
    }

    private void _0x90c671bd(int _0x059efeac)
    {
        if (_0x059efeac < this._0x873810d8.Count)
            this._0x873810d8[_0x059efeac].DOPunchScale(Vector3.one * 0.12f, 0.3f);
        if (this._0xe55c7ae9 == null)
            return;
        this._0xe55c7ae9.text = _0xf4c6cf35._0xd2b48cd5(new byte[14] { 36, 43, 34, 38, 53, 71, 36, 46, 53, 36, 50, 46, 51, 71 }, 103) + _0xd9cb9715.Numeral(_0x059efeac - 1) + _0xf4c6cf35._0xd2b48cd5(new byte[10] { 165, 209, 202, 165, 208, 203, 201, 202, 198, 206 }, 133);
        this._0xe55c7ae9.color = _0x2910d7f9.Gold;
        if (this._0xa8effbc9 != null && this._0xa8effbc9.IsActive())
            this._0xa8effbc9.Kill();
        this._0xa8effbc9 = DOVirtual.DelayedCall(RefusalSeconds, () => this._0x5b1091c8(), false);
    }

    private readonly List<RectTransform> _0x873810d8 = new List<RectTransform>();
}

internal static class _0xf4c6cf35
{
    internal static string _0xd2b48cd5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}