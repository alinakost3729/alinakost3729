using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The board scene's own read-outs: three stat plates under the top bar and the line
/// that reports what the last launch did. Every one of these is an object this game
/// creates, never a spare template slot dressed up from the outside - the template's
/// spare slots belong to the pipeline stage that switches them off, and hanging our
/// content on them would break that.
/// The three plates share one builder, so they cannot diverge from each other or
/// from the plates the menu draws.
/// </summary>
public sealed class _0xcfca063d : MonoBehaviour
{
    /// <summary>Builds the HUD inside the container the caller owns.</summary>
    public void _0xbc2ff4b9(Transform _0xf1b5986a, Sprite _0x11d4db97)
    {
        RectTransform _0xc04d1672 = _0x4538f874.Node(_0xf1b5986a, _0x5932e13a._0x8e9b3ae3(new byte[7] { 100, 67, 86, 67, 101, 88, 64 }, 55), new Vector2(0.5f, 0.905f), new Vector2(1100f, 150f));
        this._0xf50529cc = this.Plate(_0xc04d1672, _0x5932e13a._0x8e9b3ae3(new byte[10] { 112, 75, 76, 69, 81, 114, 78, 67, 86, 71 }, 34), -370f, _0x5932e13a._0x8e9b3ae3(new byte[3] { 178, 173, 180 }, 130), _0x5932e13a._0x8e9b3ae3(new byte[5] { 70, 93, 90, 83, 71 }, 20), _0x2910d7f9.Cyan, _0x11d4db97);
        this._0x471966e4 = this.Plate(_0xc04d1672, _0x5932e13a._0x8e9b3ae3(new byte[11] { 91, 118, 98, 121, 116, 127, 71, 123, 118, 99, 114 }, 23), 0f, _0x5932e13a._0x8e9b3ae3(new byte[3] { 231, 251, 231 }, 212), _0x5932e13a._0x8e9b3ae3(new byte[8] { 15, 2, 22, 13, 0, 11, 6, 16 }, 67), _0x2910d7f9.Gold, _0x11d4db97);
        this._0xb76aabc6 = this.Plate(_0xc04d1672, _0x5932e13a._0x8e9b3ae3(new byte[10] { 85, 121, 127, 120, 101, 70, 122, 119, 98, 115 }, 22), 370f, _0x5932e13a._0x8e9b3ae3(new byte[1] { 135 }, 183), _0x5932e13a._0x8e9b3ae3(new byte[5] { 196, 200, 206, 201, 212 }, 135), _0x2910d7f9.Green, _0x11d4db97);
        this._0xad31da13 = _0x4538f874.Node(_0xf1b5986a, _0x5932e13a._0x8e9b3ae3(new byte[6] { 156, 191, 176, 176, 187, 172 }, 222), new Vector2(0.5f, 0.795f), new Vector2(1060f, 90f));
        this._0x59b8ebca = _0x4538f874.StretchLabel(this._0xad31da13, _0x5932e13a._0x8e9b3ae3(new byte[11] { 35, 0, 15, 15, 4, 19, 45, 0, 3, 4, 13 }, 97), string.Empty, BannerSize, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
        this._0xad31da13.gameObject.SetActive(false);
    }

    private const float BannerSize = 44f;
    private TextMeshProUGUI _0xf50529cc;
    /// <summary>A changed number is punched so the change is visible, not just present.</summary>
    private void _0x9eab3d18(TextMeshProUGUI _0xd63191b0, string _0x23b6a650)
    {
        if (_0xd63191b0 == null || _0xd63191b0.text == _0x23b6a650)
            return;
        _0xd63191b0.text = _0x23b6a650;
        _0xd63191b0.rectTransform.localScale = Vector3.one;
        _0xd63191b0.rectTransform.DOPunchScale(Vector3.one * 0.2f, 0.25f);
    }

    public void _0x185ed9ad(int _0x2ccc55d7)
    {
        this._0x9eab3d18(this._0xb76aabc6, _0x2ccc55d7.ToString());
    }

    private const float ValueSize = 56f;
    /// <summary>
    /// One stat plate. Colour carries the meaning - cyan rings, gold launches, green
    /// coins - and the number is the big element, which is the whole point of a plate.
    /// The caption is added after the fill, so it draws on top of it.
    /// </summary>
    private TextMeshProUGUI Plate(Transform _0xfee372d7, string _0x361336be, float _0x2c2918aa, string _0xe4c89623, string _0x33065ec9, Color _0xc0b23fe0, Sprite _0xf06fe8a0)
    {
        RectTransform _0xee0cff76 = _0x4538f874.Node(_0xfee372d7, _0x361336be, new Vector2(0.5f, 0.5f), new Vector2(330f, 150f));
        _0xee0cff76.anchoredPosition = new Vector2(_0x2c2918aa, 0f);
        Image _0xd89aff2d = _0xee0cff76.gameObject.AddComponent<Image>();
        _0xd89aff2d.color = _0x2910d7f9.WithAlpha(_0xc0b23fe0, 0.55f);
        _0xd89aff2d.raycastTarget = false;
        if (_0xf06fe8a0 != null)
        {
            _0xd89aff2d.sprite = _0xf06fe8a0;
            _0xd89aff2d.type = Image.Type.Sliced;
        }

        RectTransform _0x936b7207 = _0x4538f874.Stretch(_0xee0cff76, _0x361336be + _0x5932e13a._0x8e9b3ae3(new byte[4] { 194, 237, 232, 232 }, 132));
        _0x936b7207.offsetMin = new Vector2(4f, 4f);
        _0x936b7207.offsetMax = new Vector2(-4f, -4f);
        Image _0x1533acf5 = _0x936b7207.gameObject.AddComponent<Image>();
        _0x1533acf5.color = _0x2910d7f9.Card;
        _0x1533acf5.raycastTarget = false;
        if (_0xf06fe8a0 != null)
        {
            _0x1533acf5.sprite = _0xf06fe8a0;
            _0x1533acf5.type = Image.Type.Sliced;
        }

        TextMeshProUGUI _0x2a317a36 = _0x4538f874.Label(_0xee0cff76, _0x361336be + _0x5932e13a._0x8e9b3ae3(new byte[5] { 112, 71, 74, 83, 67 }, 38), _0xe4c89623, new Vector2(0.5f, 0.64f), new Vector2(300f, 74f), ValueSize, _0xc0b23fe0, TextAlignmentOptions.Center);
        _0x4538f874.Label(_0xee0cff76, _0x361336be + _0x5932e13a._0x8e9b3ae3(new byte[7] { 169, 139, 154, 158, 131, 133, 132 }, 234), _0x33065ec9, new Vector2(0.5f, 0.26f), new Vector2(300f, 44f), CaptionSize, _0x2910d7f9.TextSecondary, TextAlignmentOptions.Center);
        return _0x2a317a36;
    }

    public void _0x3de40eba(int _0x81f4b934, int _0x63546d5b)
    {
        this._0x9eab3d18(this._0xf50529cc, _0x81f4b934.ToString() + _0x5932e13a._0x8e9b3ae3(new byte[1] { 19 }, 60) + _0x63546d5b.ToString());
    }

    private RectTransform _0xad31da13;
    private const float CaptionSize = 30f;
    public void SetLaunches(int _0x9922d50e, int _0x42437433)
    {
        this._0x9eab3d18(this._0x471966e4, _0x9922d50e.ToString() + _0x5932e13a._0x8e9b3ae3(new byte[1] { 148 }, 187) + _0x42437433.ToString());
    }

    private TextMeshProUGUI _0x471966e4;
    /// <summary>
    /// The between-launch line. It replaces a result pop on purpose: a pop after every
    /// launch would make the review album five copies of the same card instead of the
    /// board being played.
    /// </summary>
    public void _0x9f5c1a0b(string _0xc19e3ce7)
    {
        if (this._0xad31da13 == null || this._0x59b8ebca == null)
            return;
        this._0x59b8ebca.text = _0xc19e3ce7;
        this._0xad31da13.gameObject.SetActive(true);
    }

    private TextMeshProUGUI _0xb76aabc6;
    private TextMeshProUGUI _0x59b8ebca;
    public void _0x4887fe49()
    {
        if (this._0xad31da13 != null)
            this._0xad31da13.gameObject.SetActive(false);
    }
}

internal static class _0x5932e13a
{
    internal static string _0x8e9b3ae3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}