using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// The scene template carries seven tutorial slots and this game dresses none of them:
/// its how-to-play lives in the board scene, where the review capture can actually see
/// it. Slots left alone would still ship the template's filler copy, so every one of
/// them is emptied at runtime. The panels themselves stay in the pool - the template
/// controller addresses panels by index and a missing entry breaks its navigation.
/// </summary>
public sealed class _0x3e85366c : MonoBehaviour
{
    private void _0x22b4547a(int _0xf32f51b6)
    {
        _0x36c8771a _0x4fb0e761 = _0x36c8771a.Instance;
        if (_0x4fb0e761 == null || _0x4fb0e761.Panels == null)
            return;
        if (_0xf32f51b6 < 0 || _0xf32f51b6 >= _0x4fb0e761.Panels.Count)
            return;
        _0x0e1c288e _0xe2249dc2 = _0x4fb0e761.Panels[_0xf32f51b6];
        if (_0xe2249dc2 == null)
            return;
        List<TMP_Text> _0x32f9f139 = new List<TMP_Text>();
        if (_0xe2249dc2.Content != null)
            _0x32f9f139.AddRange(_0xe2249dc2.Content.GetComponentsInChildren<TMP_Text>(true));
        if (_0xe2249dc2.HeaderText != null && !_0x32f9f139.Contains(_0xe2249dc2.HeaderText))
            _0x32f9f139.Add(_0xe2249dc2.HeaderText);
        if (_0xe2249dc2.MainText != null && !_0x32f9f139.Contains(_0xe2249dc2.MainText))
            _0x32f9f139.Add(_0xe2249dc2.MainText);
        for (int _0x0709d01e = 0; _0x0709d01e < _0x32f9f139.Count; _0x0709d01e++)
            _0x32f9f139[_0x0709d01e].text = string.Empty;
    }

    public void _0x413b69ac()
    {
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL0);
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL1);
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL2);
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL3);
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL4);
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL5);
        this._0x22b4547a(_0x4a69945a._0xa8f07521.TUTORIAL6);
    }
}