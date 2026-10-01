using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The runtime UGUI factory both scenes build their screens with. Everything is
/// created in the order background to icon to text, so a plate can never cover its
/// own label, and every label is authored with word wrap OFF, autosize ON and a
/// readability floor well above the 24 px minimum.
/// </summary>
public static class _0x4538f874
{
    public static TextMeshProUGUI StretchLabel(Transform _0x074b089a, string _0x306b0dac, string _0x8f104085, float _0xe66f725c, Color _0x9bb2ad12, TextAlignmentOptions _0xe26690f9)
    {
        RectTransform _0xe2afd62a = Stretch(_0x074b089a, _0x306b0dac);
        TextMeshProUGUI _0x9983b4ca = _0xe2afd62a.gameObject.AddComponent<TextMeshProUGUI>();
        Dress(_0x9983b4ca, _0x8f104085, _0xe66f725c, _0x9bb2ad12, _0xe26690f9);
        return _0x9983b4ca;
    }

    /// <summary>
    /// The house style for every label in both scenes: wrap OFF so only an explicit
    /// newline starts a line, autosize ON so a long string shrinks instead of
    /// clipping, and a floor that keeps the shrunk size readable.
    /// </summary>
    public static void Dress(TMP_Text _0x53cfc2b3, string _0x79eb4b66, float _0x17bf1f8e, Color _0x3b2b0802, TextAlignmentOptions _0x05bfea65)
    {
        _0x53cfc2b3.text = _0x79eb4b66;
        _0x53cfc2b3.color = _0x3b2b0802;
        _0x53cfc2b3.alignment = _0x05bfea65;
        _0x53cfc2b3.enableWordWrapping = false;
        _0x53cfc2b3.overflowMode = TextOverflowModes.Overflow;
        _0x53cfc2b3.enableAutoSizing = true;
        _0x53cfc2b3.fontSizeMin = FontFloor;
        _0x53cfc2b3.fontSizeMax = Mathf.Max(FontFloor, _0x17bf1f8e);
        _0x53cfc2b3.fontSize = Mathf.Max(FontFloor, _0x17bf1f8e);
        _0x53cfc2b3.raycastTarget = false;
    }

    /// <summary>Autosize shrinks to the MINIMUM, so the minimum is the size that ships.</summary>
    public const float FontFloor = 30f;
    /// <summary>
    /// A hit layer that is almost, but never fully, transparent: the graphic raycaster
    /// skips a culled mesh, and a fully clear Image at default settings IS culled - the
    /// whole control scheme would then silently do nothing.
    /// </summary>
    public static Image HitLayer(Transform _0x242bb4d5, string _0xb8f24669, Vector2 _0x538eb839, Vector2 _0x0991c8c8)
    {
        GameObject _0x27bb1544 = new GameObject(_0xb8f24669, typeof(RectTransform));
        RectTransform _0x60432236 = _0x27bb1544.GetComponent<RectTransform>();
        _0x60432236.SetParent(_0x242bb4d5, false);
        _0x60432236.anchorMin = _0x538eb839;
        _0x60432236.anchorMax = _0x0991c8c8;
        _0x60432236.pivot = new Vector2(0.5f, 0.5f);
        _0x60432236.anchoredPosition = Vector2.zero;
        _0x60432236.sizeDelta = Vector2.zero;
        _0x60432236.localScale = Vector3.one;
        Image _0xe0c764a4 = _0x27bb1544.AddComponent<Image>();
        _0xe0c764a4.color = new Color(1f, 1f, 1f, 0.004f);
        _0xe0c764a4.raycastTarget = true;
        if (_0xe0c764a4.canvasRenderer != null)
            _0xe0c764a4.canvasRenderer.cullTransparentMesh = false;
        _0x60432236.SetAsFirstSibling();
        return _0xe0c764a4;
    }

    /// <summary>Press feedback that survives a runtime palette change: the tint multiplies.</summary>
    private static void Tint(Button _0xa35c563c)
    {
        ColorBlock _0x50974419 = _0xa35c563c.colors;
        _0x50974419.normalColor = Color.white;
        _0x50974419.highlightedColor = Color.white;
        _0x50974419.pressedColor = new Color(0.62f, 0.78f, 0.9f, 1f);
        _0x50974419.selectedColor = Color.white;
        _0x50974419.disabledColor = new Color(0.45f, 0.48f, 0.6f, 0.65f);
        _0x50974419.fadeDuration = 0.08f;
        _0xa35c563c.colors = _0x50974419;
    }

    public static Image Plate(Transform _0xbbef3e9b, string _0xcd7b29c2, Vector2 _0x33f83562, Vector2 _0xcc42ae27, Color _0xce3a25be, Sprite _0xd411c0f2)
    {
        RectTransform _0x8578c03f = Node(_0xbbef3e9b, _0xcd7b29c2, _0x33f83562, _0xcc42ae27);
        Image _0xd5c121a9 = _0x8578c03f.gameObject.AddComponent<Image>();
        _0xd5c121a9.color = _0xce3a25be;
        _0xd5c121a9.raycastTarget = false;
        if (_0xd411c0f2 != null)
        {
            _0xd5c121a9.sprite = _0xd411c0f2;
            _0xd5c121a9.type = Image.Type.Sliced;
        }

        return _0xd5c121a9;
    }

    /// <summary>
    /// A themed button: neon border, dark fill, caption LAST so it draws on top.
    /// The caller always subscribes with a lambda, never a method group.
    /// </summary>
    public static Button Cta(Transform _0x012d2007, string _0xcbcd272f, string _0x496aa9c9, Vector2 _0x2459a030, Vector2 _0xb08a734c, Color _0x549f6ca2, Color _0xc65dd551, Color _0xd3674076, float _0x25eb921a, Sprite _0xd3ffa7cf)
    {
        RectTransform _0x4e7d5fcf = Node(_0x012d2007, _0xcbcd272f, _0x2459a030, _0xb08a734c);
        Image _0x506d771d = _0x4e7d5fcf.gameObject.AddComponent<Image>();
        _0x506d771d.color = _0xc65dd551;
        _0x506d771d.raycastTarget = true;
        if (_0xd3ffa7cf != null)
        {
            _0x506d771d.sprite = _0xd3ffa7cf;
            _0x506d771d.type = Image.Type.Sliced;
        }

        RectTransform _0x7c7b9824 = Stretch(_0x4e7d5fcf, _0xcbcd272f + _0xd0ca02ee._0xbc53d2ce(new byte[4] { 36, 11, 14, 14 }, 98));
        _0x7c7b9824.offsetMin = new Vector2(6f, 6f);
        _0x7c7b9824.offsetMax = new Vector2(-6f, -6f);
        Image _0xd4940f00 = _0x7c7b9824.gameObject.AddComponent<Image>();
        _0xd4940f00.color = _0x549f6ca2;
        _0xd4940f00.raycastTarget = false;
        if (_0xd3ffa7cf != null)
        {
            _0xd4940f00.sprite = _0xd3ffa7cf;
            _0xd4940f00.type = Image.Type.Sliced;
        }

        TextMeshProUGUI _0x00e133ac = StretchLabel(_0x4e7d5fcf, _0xcbcd272f + _0xd0ca02ee._0xbc53d2ce(new byte[5] { 156, 177, 178, 181, 188 }, 208), _0x496aa9c9, _0x25eb921a, _0xd3674076, TextAlignmentOptions.Center);
        _0x00e133ac.rectTransform.offsetMin = new Vector2(28f, 14f);
        _0x00e133ac.rectTransform.offsetMax = new Vector2(-28f, -14f);
        Button _0x27025ee1 = _0x4e7d5fcf.gameObject.AddComponent<Button>();
        _0x27025ee1.targetGraphic = _0xd4940f00;
        Tint(_0x27025ee1);
        return _0x27025ee1;
    }

    public static Image Picture(Transform _0x0140743c, string _0xfe4b0cf6, Vector2 _0x16f54ed6, Vector2 _0x873fc58a, Sprite _0xc50b9d99, Color _0x826efcf3)
    {
        RectTransform _0x441af0fe = Node(_0x0140743c, _0xfe4b0cf6, _0x16f54ed6, _0x873fc58a);
        Image _0xc81aada4 = _0x441af0fe.gameObject.AddComponent<Image>();
        _0xc81aada4.sprite = _0xc50b9d99;
        _0xc81aada4.color = _0x826efcf3;
        _0xc81aada4.preserveAspect = true;
        _0xc81aada4.raycastTarget = false;
        return _0xc81aada4;
    }

    public static RectTransform Stretch(Transform _0x23ae3d4a, string _0xf104b6a5)
    {
        GameObject _0x0d536a18 = new GameObject(_0xf104b6a5, typeof(RectTransform));
        RectTransform _0x2be122fc = _0x0d536a18.GetComponent<RectTransform>();
        _0x2be122fc.SetParent(_0x23ae3d4a, false);
        _0x2be122fc.anchorMin = Vector2.zero;
        _0x2be122fc.anchorMax = Vector2.one;
        _0x2be122fc.pivot = new Vector2(0.5f, 0.5f);
        _0x2be122fc.anchoredPosition = Vector2.zero;
        _0x2be122fc.sizeDelta = Vector2.zero;
        _0x2be122fc.localScale = Vector3.one;
        return _0x2be122fc;
    }

    public static RectTransform Node(Transform _0x73a7b439, string _0x068b0bea, Vector2 _0x7bd2a7d2, Vector2 _0x10368403)
    {
        GameObject _0xf6fc293e = new GameObject(_0x068b0bea, typeof(RectTransform));
        RectTransform _0xf3f5eff2 = _0xf6fc293e.GetComponent<RectTransform>();
        _0xf3f5eff2.SetParent(_0x73a7b439, false);
        _0xf3f5eff2.anchorMin = _0x7bd2a7d2;
        _0xf3f5eff2.anchorMax = _0x7bd2a7d2;
        _0xf3f5eff2.pivot = new Vector2(0.5f, 0.5f);
        _0xf3f5eff2.anchoredPosition = Vector2.zero;
        _0xf3f5eff2.sizeDelta = _0x10368403;
        _0xf3f5eff2.localScale = Vector3.one;
        return _0xf3f5eff2;
    }

    /// <summary>A square icon button - sprite face, no caption. Back, pause and close.</summary>
    public static Button IconCta(Transform _0xca17ab05, string _0x5e9a019f, Sprite _0xaf704a4d, Vector2 _0xc42b298b, Vector2 _0x112f820f, Color _0xa1603a6a, Color _0x8a2ff77b, Color _0x0e502dc5)
    {
        RectTransform _0xd7289412 = Node(_0xca17ab05, _0x5e9a019f, _0xc42b298b, _0x112f820f);
        Image _0x92fcdd4b = _0xd7289412.gameObject.AddComponent<Image>();
        _0x92fcdd4b.color = _0x8a2ff77b;
        _0x92fcdd4b.raycastTarget = true;
        RectTransform _0x71e21264 = Stretch(_0xd7289412, _0x5e9a019f + _0xd0ca02ee._0xbc53d2ce(new byte[4] { 236, 195, 198, 198 }, 170));
        _0x71e21264.offsetMin = new Vector2(5f, 5f);
        _0x71e21264.offsetMax = new Vector2(-5f, -5f);
        Image _0x30946a66 = _0x71e21264.gameObject.AddComponent<Image>();
        _0x30946a66.color = _0xa1603a6a;
        _0x30946a66.raycastTarget = false;
        Image _0xdac618bd = Picture(_0xd7289412, _0x5e9a019f + _0xd0ca02ee._0xbc53d2ce(new byte[4] { 203, 225, 237, 236 }, 130), new Vector2(0.5f, 0.5f), _0x112f820f * 0.56f, _0xaf704a4d, _0x0e502dc5);
        _0xdac618bd.raycastTarget = false;
        Button _0x2907157b = _0xd7289412.gameObject.AddComponent<Button>();
        _0x2907157b.targetGraphic = _0x30946a66;
        Tint(_0x2907157b);
        return _0x2907157b;
    }

    public static Image FullPlate(Transform _0x6a9ffc97, string _0x1c49eff5, Color _0x6c3ff345, Sprite _0x4d562447)
    {
        RectTransform _0x325c1ae6 = Stretch(_0x6a9ffc97, _0x1c49eff5);
        Image _0x591964b9 = _0x325c1ae6.gameObject.AddComponent<Image>();
        _0x591964b9.color = _0x6c3ff345;
        _0x591964b9.raycastTarget = false;
        if (_0x4d562447 != null)
        {
            _0x591964b9.sprite = _0x4d562447;
            _0x591964b9.type = Image.Type.Sliced;
        }

        return _0x591964b9;
    }

    public static TextMeshProUGUI Label(Transform _0xf4846d7e, string _0x6f6b1b06, string _0x1a41e856, Vector2 _0x0e8b7983, Vector2 _0x2b75e470, float _0x7de93e6b, Color _0x153a4211, TextAlignmentOptions _0x9cd2f507)
    {
        RectTransform _0x1c3fe526 = Node(_0xf4846d7e, _0x6f6b1b06, _0x0e8b7983, _0x2b75e470);
        TextMeshProUGUI _0xed4856cc = _0x1c3fe526.gameObject.AddComponent<TextMeshProUGUI>();
        Dress(_0xed4856cc, _0x1a41e856, _0x7de93e6b, _0x153a4211, _0x9cd2f507);
        return _0xed4856cc;
    }
}

internal static class _0xd0ca02ee
{
    internal static string _0xbc53d2ce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}