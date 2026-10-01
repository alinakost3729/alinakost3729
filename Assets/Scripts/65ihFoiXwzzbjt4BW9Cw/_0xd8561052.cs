using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three result cards the template provides - cleared, lost and paused -
/// in this game's own words and colours. A card is more than its three strings: the
/// template ships its close button with NO sprite assigned, which Unity draws as a
/// plain white rectangle, and it ships spare labels from another game that would sit
/// under our heading saying nothing. Both are dealt with here.
/// Buttons are told apart by where they SIT and whether they own a caption, never by
/// name and never by traversal order: the cross comes back first from a hierarchy walk
/// and would otherwise collect the first action's word.
/// </summary>
public sealed class _0xd8561052 : MonoBehaviour
{
    /// <summary>
    /// Anything the template left behind - a spare metric label or stray counter - is
    /// emptied. A label with a name and no value is worse than no label at all, and
    /// these name metrics this game does not keep.
    /// </summary>
    private void _0x0f82e4cb(GameObject _0xa34471f8, List<TMP_Text> _0xf786e3eb)
    {
        TMP_Text[] _0x0b00ffc5 = _0xa34471f8.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x06b724b9 = 0; _0x06b724b9 < _0x0b00ffc5.Length; _0x06b724b9++)
        {
            if (_0x0b00ffc5[_0x06b724b9] == null || _0xf786e3eb.Contains(_0x0b00ffc5[_0x06b724b9]))
                continue;
            _0x0b00ffc5[_0x06b724b9].text = string.Empty;
        }
    }

    private const float HeaderSize = 96f;
    /// <summary>
    /// The close cross. Its Image arrives with no sprite, so without this the card ships
    /// a white block where the cross should be. Any caption it carries is removed - the
    /// cross needs a picture, not a word.
    /// </summary>
    private void _0x03c21e3d(Button _0xb02ea174)
    {
        Image _0x4151c1ed = _0xb02ea174.targetGraphic as Image;
        if (_0x4151c1ed == null)
            _0x4151c1ed = _0xb02ea174.GetComponent<Image>();
        if (_0x4151c1ed != null && this._closeIcon != null)
        {
            _0x4151c1ed.sprite = this._closeIcon;
            _0x4151c1ed.type = Image.Type.Simple;
            _0x4151c1ed.preserveAspect = true;
            _0x4151c1ed.color = _0x2910d7f9.Cyan;
        }
        else if (_0x4151c1ed != null && this._closeIcon == null)
        {
            // No icon to show: a coloured plate still beats a white rectangle.
            _0x4151c1ed.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Surface, 0.9f);
        }

        Image[] _0x459aa9a1 = _0xb02ea174.GetComponentsInChildren<Image>(true);
        for (int _0x63b218b8 = 0; _0x63b218b8 < _0x459aa9a1.Length; _0x63b218b8++)
        {
            if (_0x459aa9a1[_0x63b218b8] == null || _0x459aa9a1[_0x63b218b8] == _0x4151c1ed)
                continue;
            if (_0x459aa9a1[_0x63b218b8].sprite != null)
                continue;
            if (this._closeIcon == null)
                continue;
            _0x459aa9a1[_0x63b218b8].sprite = this._closeIcon;
            _0x459aa9a1[_0x63b218b8].preserveAspect = true;
            _0x459aa9a1[_0x63b218b8].color = _0x2910d7f9.Cyan;
        }
    }

    private void _0x38a1f04f(TMP_Text _0xdcc3af46, string _0xb7bcd654, float _0x19ea02f5, Color _0x68cf366a, List<TMP_Text> _0x0bbcc25a)
    {
        if (_0xdcc3af46 == null)
            return;
        _0x4538f874.Dress(_0xdcc3af46, _0xb7bcd654, _0x19ea02f5, _0x68cf366a, TextAlignmentOptions.Center);
        _0x0bbcc25a.Add(_0xdcc3af46);
    }

    private const float ValueSize = 64f;
    /// <summary>
    /// Sorts a card's buttons into the two groups the template lays out: the action row
    /// along the BOTTOM of the card, and the chrome above it - in practice the close
    /// cross in the top corner.
    /// Traversal order is not used to tell them apart, because the cross comes back
    /// FIRST from a hierarchy walk and would collect the first action's caption. Nor
    /// are object names, which do not survive renaming. What is used is where each
    /// button actually sits inside the card, plus whether it owns a caption at all;
    /// both of those are properties of the layout itself.
    /// The action row is then ordered left to right, so captions land in reading order
    /// no matter what order the hierarchy returns.
    /// </summary>
    private void _0xc9555acc(GameObject _0x2d621f26, RectTransform _0xdfc77d4e, List<Button> _0x7c396a98, List<Button> _0x5dfea666)
    {
        Button[] _0xdfd1f871 = _0x2d621f26.GetComponentsInChildren<Button>(true);
        List<float> _0x882c02e7 = new List<float>();
        for (int _0xf1720cf1 = 0; _0xf1720cf1 < _0xdfd1f871.Length; _0xf1720cf1++)
        {
            Button _0xf76eaf62 = _0xdfd1f871[_0xf1720cf1];
            if (_0xf76eaf62 == null)
                continue;
            bool _0x20219c89 = _0xf76eaf62.GetComponentInChildren<TMP_Text>(true) != null;
            float _0xdba7261e = 0f;
            bool _0xa1828dfb = true;
            if (_0xdfc77d4e != null)
            {
                Vector3 _0x96c1b413 = _0xdfc77d4e.InverseTransformPoint(_0xf76eaf62.transform.position);
                _0xdba7261e = _0x96c1b413.x;
                _0xa1828dfb = _0x96c1b413.y <= 0f;
            }

            if (!_0x20219c89 || !_0xa1828dfb)
            {
                _0x5dfea666.Add(_0xf76eaf62);
                continue;
            }

            int _0xca3a957c = _0x7c396a98.Count;
            for (int _0x28efb292 = 0; _0x28efb292 < _0x882c02e7.Count; _0x28efb292++)
            {
                if (_0xdba7261e < _0x882c02e7[_0x28efb292])
                {
                    _0xca3a957c = _0x28efb292;
                    break;
                }
            }

            _0x7c396a98.Insert(_0xca3a957c, _0xf76eaf62);
            _0x882c02e7.Insert(_0xca3a957c, _0xdba7261e);
        }
    }

    /// <summary>
    /// Fills one card. <paramref name = "actions"/> are the captions for the action row,
    /// left to right; a spare button beyond that list is emptied rather than given
    /// somebody else's word.
    /// </summary>
    public void _0x344efdc4(int _0x15cf26a5, string _0xa55e6e81, string _0xed94f022, string _0xcdc3cff0, string[] _0x85d4a352)
    {
        _0x2af55b18 _0x8a655160 = _0x2af55b18.Instance;
        if (_0x8a655160 == null || _0x8a655160.Pops == null)
            return;
        // Bounds are checked here because the template's accessor does not: it indexes
        // its list straight away and would throw on a pop this template never shipped.
        if (_0x15cf26a5 < 0 || _0x15cf26a5 >= _0x8a655160.Pops.Count)
            return;
        _0x9fc78e23 _0x5eabd2fa = _0x8a655160._0x6e27dfcb(_0x15cf26a5);
        if (_0x5eabd2fa == null || _0x5eabd2fa.Content == null)
            return;
        List<TMP_Text> _0xc3ce3024 = new List<TMP_Text>();
        this._0x38a1f04f(_0x5eabd2fa.ContentHeaderText, _0xa55e6e81, HeaderSize, _0x2910d7f9.TextPrimary, _0xc3ce3024);
        this._0x38a1f04f(_0x5eabd2fa.ContentMainText, _0xed94f022, ValueSize, _0x2910d7f9.Gold, _0xc3ce3024);
        this._0x38a1f04f(_0x5eabd2fa.ContentAdditionalText, _0xcdc3cff0, ValueSize, _0x2910d7f9.Cyan, _0xc3ce3024);
        RectTransform _0xfdfa9e03 = _0x5eabd2fa.Content.transform as RectTransform;
        List<Button> _0x316d4765 = new List<Button>();
        List<Button> _0x2689ddc0 = new List<Button>();
        this._0xc9555acc(_0x5eabd2fa.Content, _0xfdfa9e03, _0x316d4765, _0x2689ddc0);
        for (int _0xfe201181 = 0; _0xfe201181 < _0x2689ddc0.Count; _0xfe201181++)
            this._0x03c21e3d(_0x2689ddc0[_0xfe201181]);
        for (int _0x2bf1c512 = 0; _0x2bf1c512 < _0x316d4765.Count; _0x2bf1c512++)
        {
            TMP_Text _0x60176b0f = _0x316d4765[_0x2bf1c512].GetComponentInChildren<TMP_Text>(true);
            if (_0x60176b0f == null)
                continue;
            // No caption of its own beats somebody else's: a spare button is emptied,
            // never given the previous button's word.
            string _0x7157230b = _0x2bf1c512 < _0x85d4a352.Length ? _0x85d4a352[_0x2bf1c512] : string.Empty;
            _0x4538f874.Dress(_0x60176b0f, _0x7157230b, ActionSize, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
            _0xc3ce3024.Add(_0x60176b0f);
        }

        this._0x0f82e4cb(_0x5eabd2fa.Content, _0xc3ce3024);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private const float ActionSize = 52f;
}