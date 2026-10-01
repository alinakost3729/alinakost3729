using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Builds the menu: the abstract mark, what the player is being asked to do, the
/// record, the circuit row and the call to action. There is deliberately no title -
/// the brand here is a shape and a palette, never a word.
/// It also finishes the two things the scene template leaves half-done: the loading
/// bar arrives in the template's own grey with an inset that can collapse it to
/// nothing, and the play button arrives stretched across almost the whole screen.
/// </summary>
public sealed class _0xf41971ea : MonoBehaviour
{
    private const float PlayCaptionSize = 62f;
    /// <summary>
    /// The call to action's geometry, authored here rather than read off the scene
    /// instance: the template ships this button stretched over the whole panel, and
    /// the face and the hit rect have to agree whatever the instance happens to carry.
    /// The row of chips sits at 0.398 and is 190 tall, the hint line at 0.337 is 56
    /// tall, so a 168-tall button centred on 0.27 clears both.
    /// </summary>
    private static readonly Vector2 _0xebfc2797 = new Vector2(0.5f, 0.27f);
    private static readonly Vector2 _0x6abf2648 = new Vector2(760f, 168f);
    private void _0xfb804078(_0xb0d18c71 _0x453a80f3)
    {
        if (_0x453a80f3.Content == null || this._brandMark == null)
            return;
        Transform _0xe7453c30 = _0x453a80f3.Content.transform;
        Image _0xd94eb309 = _0x4538f874.Picture(_0xe7453c30, _0x7eb041e9._0xd63c1e26(new byte[10] { 156, 191, 163, 174, 188, 167, 130, 174, 189, 164 }, 207), new Vector2(0.5f, 0.62f), new Vector2(520f, 520f), this._brandMark, _0x2910d7f9.Cyan);
        _0xd94eb309.rectTransform.localEulerAngles = Vector3.zero;
        _0xd94eb309.rectTransform.DOLocalRotate(new Vector3(0f, 0f, -360f), MarkSpinSeconds, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        Image _0x234821cf = _0x4538f874.Picture(_0xe7453c30, _0x7eb041e9._0xd63c1e26(new byte[11] { 91, 120, 100, 105, 123, 96, 91, 120, 105, 122, 99 }, 8), new Vector2(0.5f, 0.62f), new Vector2(86f, 86f), this._pip, _0x2910d7f9.Gold);
        _0x234821cf.rectTransform.anchoredPosition = new Vector2(0f, 236f);
        _0x234821cf.rectTransform.DOScale(Vector3.one * 1.25f, 0.8f).SetLoops(-1, LoopType.Yoyo);
        _0x4538f874.Label(_0xe7453c30, _0x7eb041e9._0xd63c1e26(new byte[10] { 84, 119, 107, 102, 116, 111, 73, 104, 115, 98 }, 7), _0x7eb041e9._0xd63c1e26(new byte[7] { 47, 44, 34, 39, 42, 45, 36 }, 99), new Vector2(0.5f, 0.2f), new Vector2(760f, 56f), 34f, _0x2910d7f9.TextSecondary, TextAlignmentOptions.Center);
    }

    [SerializeField]
    private _0x3e85366c _cleaner;
    [SerializeField]
    private GameObject _playHost;
    private void _0x9c9ffdc6()
    {
        _0x36c8771a _0x90cbbb20 = _0x36c8771a.Instance;
        if (_0x90cbbb20 == null || _0x90cbbb20.Panels == null || _0x4a69945a._0xa8f07521.DEFAULT >= _0x90cbbb20.Panels.Count)
            return;
        _0x0e1c288e _0x1da24667 = _0x90cbbb20.Panels[_0x4a69945a._0xa8f07521.DEFAULT];
        if (_0x1da24667 == null || _0x1da24667.Content == null)
            return;
        Transform _0xdc4eff74 = _0x1da24667.Content.transform;
        if (this._brandMark != null)
        {
            Image _0x6eba9774 = _0x4538f874.Picture(_0xdc4eff74, _0x7eb041e9._0xd63c1e26(new byte[9] { 26, 42, 57, 54, 60, 21, 57, 42, 51 }, 88), new Vector2(0.5f, 0.80f), new Vector2(380f, 380f), this._brandMark, _0x2910d7f9.Cyan);
            _0x6eba9774.rectTransform.localScale = Vector3.one;
            _0x6eba9774.rectTransform.DOScale(Vector3.one * 1.04f, 1.6f).SetLoops(-1, LoopType.Yoyo);
        }

        _0x4538f874.Label(_0xdc4eff74, _0x7eb041e9._0xd63c1e26(new byte[9] { 254, 211, 219, 212, 210, 197, 216, 199, 212 }, 177), _0x7eb041e9._0xd63c1e26(new byte[31] { 48, 60, 63, 63, 54, 48, 39, 83, 69, 83, 33, 58, 61, 52, 32, 83, 94, 83, 33, 54, 50, 48, 59, 83, 39, 59, 54, 83, 48, 38, 35 }, 115), new Vector2(0.5f, 0.685f), new Vector2(1000f, 64f), 40f, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
        // The menu half of the template carries no coin read-out of its own, so the
        // wallet is shown here next to the record rather than left off the screen.
        _0x4538f874.Label(_0xdc4eff74, _0x7eb041e9._0xd63c1e26(new byte[9] { 128, 167, 177, 182, 144, 171, 172, 165, 177 }, 194), _0x7eb041e9._0xd63c1e26(new byte[12] { 230, 225, 247, 240, 132, 246, 237, 234, 227, 247, 132, 132 }, 164) + _0xcf552857._0x05ba273a.ToString(), new Vector2(0.29f, 0.615f), new Vector2(560f, 58f), 44f, _0x2910d7f9.Cyan, TextAlignmentOptions.Center);
        _0x4538f874.Label(_0xdc4eff74, _0x7eb041e9._0xd63c1e26(new byte[10] { 229, 201, 207, 200, 213, 242, 201, 210, 199, 202 }, 166), _0x7eb041e9._0xd63c1e26(new byte[7] { 90, 86, 80, 87, 74, 57, 57 }, 25) + _0x4a69945a._0x5dc950a9._0x02606895.ToString(), new Vector2(0.71f, 0.615f), new Vector2(560f, 58f), 44f, _0x2910d7f9.Gold, TextAlignmentOptions.Center);
        if (this._selector != null)
            this._selector._0x8f30ae17(_0xdc4eff74, this._plate, this._pip);
        // In the clear band between the chip row and the button, and in nobody else's
        // box. The row is centred on 0.398 and is 190 tall, so it reaches down to
        // 0.363; the button is anchored at 0.27 in the scene and is 168 tall, so it
        // reaches up to 0.301. This line is 56 tall, which leaves air on both
        // sides of it - put it any higher and it prints straight across the chips.
        _0x4538f874.Label(_0xdc4eff74, _0x7eb041e9._0xd63c1e26(new byte[11] { 198, 234, 235, 241, 247, 234, 233, 205, 236, 235, 241 }, 133), _0x7eb041e9._0xd63c1e26(new byte[33] { 202, 223, 206, 190, 202, 209, 190, 205, 219, 202, 190, 211, 223, 217, 208, 219, 202, 205, 190, 179, 190, 214, 209, 210, 218, 190, 202, 209, 190, 202, 215, 210, 202 }, 158), new Vector2(0.5f, 0.337f), new Vector2(1000f, 56f), 34f, _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.95f), TextAlignmentOptions.Center);
    }

    [SerializeField]
    private _0xfbce4001 _selector;
    /// <summary>
    /// The template's own coin read-outs are kept - they are what shows the currency
    /// this game pays out - but they arrive in the template's styling, so they are
    /// repainted into the palette here. They are reached through the controller's own
    /// public list, never by searching for them.
    /// </summary>
    private void _0xa85a4b53()
    {
        _0xdf57c529 _0x434bc8ee = _0xdf57c529.Instance;
        if (_0x434bc8ee == null || _0x434bc8ee.MoneyCountContainers == null)
            return;
        for (int _0x9f60ec32 = 0; _0x9f60ec32 < _0x434bc8ee.MoneyCountContainers.Count; _0x9f60ec32++)
        {
            _0x5c581cb0 _0xf0606970 = _0x434bc8ee.MoneyCountContainers[_0x9f60ec32];
            if (_0xf0606970 == null || _0xf0606970.MoneyCountText == null)
                continue;
            _0x4538f874.Dress(_0xf0606970.MoneyCountText, _0xf0606970.MoneyCountText.text, 48f, _0x2910d7f9.Gold, TextAlignmentOptions.Center);
        }
    }

    /// <summary>
    /// The scene already carries a button wired to load the board, so that button keeps
    /// the press and its LoadSceneButton driver. What it cannot be given is a FACE.
    /// The instance is the template's EMPTY button variant, and "empty" there is not
    /// just a matter of switched-off layers: every surviving layer of BASE_PANEL paints
    /// through a stencil material (ShowInsideMaskBack0/1, _Stencil 7, _StencilComp Less)
    /// whose mask writers - BackgroundRoundness, FillRoundess, Border and
    /// __RESET_STENCIL_MASKS__ - are exactly the objects the variant deactivates. With
    /// no writer the reference value is never laid down, so those layers fail their
    /// stencil test and draw nothing whatever sprite is handed to them. Adding our own
    /// plates as children of that instance did not reach the screen either: they live
    /// inside a prefab subtree whose sibling order and activity belong to the template.
    /// So the face is built as OUR object in the panel content, next to the button and
    /// after it, which is what C.2 asks for - own HUD, own objects, never re-skinned
    /// template slots. The button gets one thing only: a hit layer, because the graphic
    /// it tints is transparent at rest and a culled graphic takes no raycasts. Geometry
    /// is forced onto the host so the invisible hit rect and the visible face coincide.
    /// </summary>
    private void _0xea17a11d()
    {
        if (this._playHost == null)
            return;
        RectTransform _0x8f819f6e = this._playHost.GetComponent<RectTransform>();
        RectTransform _0x0bbe4814 = _0x8f819f6e != null ? _0x8f819f6e.parent as RectTransform : null;
        if (_0x8f819f6e == null || _0x0bbe4814 == null)
            return;
        _0x8f819f6e.anchorMin = _0xebfc2797;
        _0x8f819f6e.anchorMax = _0xebfc2797;
        _0x8f819f6e.pivot = new Vector2(0.5f, 0.5f);
        _0x8f819f6e.anchoredPosition = Vector2.zero;
        _0x8f819f6e.sizeDelta = _0x6abf2648;
        // The one thing added inside the template instance. It is all but transparent
        // and carries no pixels of its own - it exists so the tap always lands on the
        // Button, independently of what the template's own tinted layer does.
        _0x4538f874.HitLayer(_0x8f819f6e, _0x7eb041e9._0xd63c1e26(new byte[7] { 143, 179, 190, 166, 151, 182, 171 }, 223), Vector2.zero, Vector2.one);
        // The template caption is emptied, not removed - the layer it belongs to is
        // template structure. Emptying it is what keeps exactly one PLAY on the screen
        // once the readable one below is in place.
        TMP_Text _0x22f79213 = this._playHost.GetComponentInChildren<TMP_Text>(true);
        if (_0x22f79213 != null)
            _0x22f79213.text = string.Empty;
        // Last sibling of the content, so nothing in the menu can cover it; inside it
        // frame first, body second, caption last, so the caption can never end up
        // behind its own plate. Nothing here takes raycasts - the press falls straight
        // through to the hit layer sitting under it.
        RectTransform _0x10d4f876 = _0x4538f874.Node(_0x0bbe4814, _0x7eb041e9._0xd63c1e26(new byte[8] { 251, 199, 202, 210, 237, 202, 200, 206 }, 171), _0xebfc2797, _0x6abf2648);
        _0x10d4f876.SetAsLastSibling();
        _0x4538f874.FullPlate(_0x10d4f876, _0x7eb041e9._0xd63c1e26(new byte[9] { 24, 36, 41, 49, 14, 58, 41, 37, 45 }, 72), _0x2910d7f9.Cyan, this._plate);
        Image _0x50f90f50 = _0x4538f874.FullPlate(_0x10d4f876, _0x7eb041e9._0xd63c1e26(new byte[8] { 115, 79, 66, 90, 97, 76, 71, 90 }, 35), _0x2910d7f9.Magenta, this._plate);
        _0x50f90f50.rectTransform.offsetMin = new Vector2(7f, 7f);
        _0x50f90f50.rectTransform.offsetMax = new Vector2(-7f, -7f);
        TextMeshProUGUI _0x183854ad = _0x4538f874.StretchLabel(_0x10d4f876, _0x7eb041e9._0xd63c1e26(new byte[11] { 201, 245, 248, 224, 218, 248, 233, 237, 240, 246, 247 }, 153), _0x7eb041e9._0xd63c1e26(new byte[4] { 132, 152, 149, 141 }, 212), PlayCaptionSize, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
        _0x183854ad.rectTransform.offsetMin = new Vector2(32f, 18f);
        _0x183854ad.rectTransform.offsetMax = new Vector2(-32f, -18f);
        Button _0x27f1c3df = this._playHost.GetComponentInChildren<Button>(true);
        if (_0x27f1c3df == null)
            return;
        // The press has to read on a still frame, so the face answers with a squash
        // as well as the scene change the button's template driver already performs.
        _0x27f1c3df.onClick.AddListener(() => this._0x8fa3ab81(_0x10d4f876));
    }

    [SerializeField]
    private Sprite _pip;
    private const float MarkSpinSeconds = 2.2f;
    private void _0x8fa3ab81(RectTransform _0xef2e32dc)
    {
        if (_0xef2e32dc == null)
            return;
        DOTween.Kill(_0xef2e32dc, true);
        _0xef2e32dc.localScale = Vector3.one;
        _0xef2e32dc.DOScale(Vector3.one * 0.95f, 0.08f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutBack);
    }

    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _brandMark;
    private void Start()
    {
        if (this._cleaner != null)
            this._cleaner._0x413b69ac();
        this._0x9c9ffdc6();
        this._0xea17a11d();
        this._0x780b9376();
        this._0xa85a4b53();
    }

    /// <summary>
    /// The loading bar. Its fill area shrinks itself inside the template prefab, which
    /// can leave both the track and the fill at zero pixels however they are coloured,
    /// so the area is re-stretched over its parent first and coloured second. The fill
    /// rect's own anchors are left alone - the slider rewrites them every frame.
    /// </summary>
    private void _0x780b9376()
    {
        _0xb0d18c71 _0xfac13f3b = _0xb0d18c71.Instance;
        if (_0xfac13f3b == null || _0xfac13f3b.AnimationSlider == null)
            return;
        Slider _0xbaaadb0f = _0xfac13f3b.AnimationSlider;
        RectTransform _0xab40b65a = _0xbaaadb0f.fillRect;
        if (_0xab40b65a != null)
        {
            RectTransform _0x3c4eec0f = _0xab40b65a.parent as RectTransform;
            if (_0x3c4eec0f != null)
            {
                _0x3c4eec0f.anchorMin = Vector2.zero;
                _0x3c4eec0f.anchorMax = Vector2.one;
                _0x3c4eec0f.offsetMin = new Vector2(6f, 6f);
                _0x3c4eec0f.offsetMax = new Vector2(-6f, -6f);
            }

            Image _0x1eea9087 = _0xab40b65a.GetComponent<Image>();
            if (_0x1eea9087 != null)
            {
                _0x1eea9087.color = _0x2910d7f9.Cyan;
                if (_0x1eea9087.sprite == null && this._plate != null)
                {
                    _0x1eea9087.sprite = this._plate;
                    _0x1eea9087.type = Image.Type.Sliced;
                }
            }
        }

        Image _0x50c21e75 = _0xbaaadb0f.GetComponent<Image>();
        if (_0x50c21e75 != null)
            _0x50c21e75.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.BaseDeep, 0.9f);
        if (_0xfac13f3b.Background != null)
        {
            Image _0x2ab78153 = _0xfac13f3b.Background.GetComponent<Image>();
            if (_0x2ab78153 != null)
                _0x2ab78153.color = _0x2910d7f9.WithAlpha(Color.white, 1f);
        }

        this._0xfb804078(_0xfac13f3b);
    }
}

internal static class _0x7eb041e9
{
    internal static string _0xd63c1e26(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}