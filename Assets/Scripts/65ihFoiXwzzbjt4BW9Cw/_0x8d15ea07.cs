using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The control briefing. This game is held and dragged, not just tapped, so the
/// gesture has to be spelled out where the player - and the review screenshot - can
/// actually see it: in the board scene, not in a first-run panel that a fresh launch
/// would skip past.
/// It closes on its own after a few seconds as well as on the button, so an automated
/// capture can never be stranded on top of it.
/// </summary>
public sealed class _0x8d15ea07 : MonoBehaviour
{
    private void Step(Transform _0x9a5c5109, string _0xb171589d, float _0xe2e4f588, Sprite _0x3c0796b6, string _0xf1e38648)
    {
        RectTransform _0xb845068e = _0x4538f874.Node(_0x9a5c5109, _0xb171589d, new Vector2(0.5f, _0xe2e4f588), new Vector2(860f, 120f));
        if (_0x3c0796b6 != null)
            _0x4538f874.Picture(_0xb845068e, _0xb171589d + _0x4b3a4768._0x49161a7d(new byte[4] { 30, 52, 56, 57 }, 87), new Vector2(0.09f, 0.5f), new Vector2(96f, 96f), _0x3c0796b6, Color.white);
        _0x4538f874.Label(_0xb845068e, _0xb171589d + _0x4b3a4768._0x49161a7d(new byte[4] { 24, 41, 52, 56 }, 76), _0xf1e38648, new Vector2(0.58f, 0.5f), new Vector2(620f, 110f), StepSize, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Left);
    }

    private const float AutoCloseSeconds = 6f;
    private Tween _0x680cc9a3;
    public void _0xfed66db8(Transform _0x71a8a289)
    {
        // The permanent hint outlives the card: rule C.6 asks for a visible gesture
        // label for the whole run, not only while the briefing is up.
        _0x4538f874.Label(_0x71a8a289, _0x4b3a4768._0x49161a7d(new byte[11] { 162, 128, 150, 145, 144, 151, 128, 173, 140, 139, 145 }, 229), _0x4b3a4768._0x49161a7d(new byte[25] { 203, 204, 207, 199, 163, 207, 198, 197, 215, 163, 172, 163, 209, 202, 196, 203, 215, 163, 215, 204, 163, 215, 202, 207, 215 }, 131), new Vector2(0.5f, 0.235f), new Vector2(1000f, 60f), HintSize, _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.9f), TextAlignmentOptions.Center);
        this._0x916b5abb = _0x4538f874.Stretch(_0x71a8a289, _0x4b3a4768._0x49161a7d(new byte[9] { 173, 138, 146, 177, 138, 181, 137, 132, 156 }, 229));
        Image _0x617c35b3 = this._0x916b5abb.gameObject.AddComponent<Image>();
        _0x617c35b3.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Base, 0.82f);
        _0x617c35b3.raycastTarget = true;
        RectTransform _0x8c92cd1a = _0x4538f874.Node(this._0x916b5abb, _0x4b3a4768._0x49161a7d(new byte[9] { 228, 195, 219, 248, 195, 239, 205, 222, 200 }, 172), new Vector2(0.5f, 0.52f), new Vector2(980f, 720f));
        Image _0xc7612700 = _0x8c92cd1a.gameObject.AddComponent<Image>();
        _0xc7612700.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.9f);
        _0xc7612700.raycastTarget = false;
        if (this._plate != null)
        {
            _0xc7612700.sprite = this._plate;
            _0xc7612700.type = Image.Type.Sliced;
        }

        RectTransform _0xdbae3390 = _0x4538f874.Stretch(_0x8c92cd1a, _0x4b3a4768._0x49161a7d(new byte[9] { 220, 251, 227, 192, 251, 210, 253, 248, 248 }, 148));
        _0xdbae3390.offsetMin = new Vector2(6f, 6f);
        _0xdbae3390.offsetMax = new Vector2(-6f, -6f);
        Image _0xf285cdd3 = _0xdbae3390.gameObject.AddComponent<Image>();
        _0xf285cdd3.color = _0x2910d7f9.Card;
        _0xf285cdd3.raycastTarget = false;
        if (this._plate != null)
        {
            _0xf285cdd3.sprite = this._plate;
            _0xf285cdd3.type = Image.Type.Sliced;
        }

        _0x4538f874.Label(_0x8c92cd1a, _0x4b3a4768._0x49161a7d(new byte[10] { 171, 140, 148, 183, 140, 183, 138, 151, 143, 134 }, 227), _0x4b3a4768._0x49161a7d(new byte[11] { 35, 36, 60, 75, 63, 36, 75, 59, 39, 42, 50 }, 107), new Vector2(0.5f, 0.87f), new Vector2(880f, 90f), 64f, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
        this.Step(_0x8c92cd1a, _0x4b3a4768._0x49161a7d(new byte[7] { 162, 133, 148, 129, 190, 159, 148 }, 241), 0.66f, this._magnetIcon, _0x4b3a4768._0x49161a7d(new byte[29] { 77, 88, 73, 57, 77, 81, 92, 57, 91, 86, 88, 75, 93, 57, 77, 86, 57, 74, 92, 77, 57, 88, 57, 84, 88, 94, 87, 92, 77 }, 25));
        this.Step(_0x8c92cd1a, _0x4b3a4768._0x49161a7d(new byte[7] { 237, 202, 219, 206, 234, 201, 209 }, 190), 0.50f, this._ballIcon, _0x4b3a4768._0x49161a7d(new byte[27] { 184, 173, 188, 204, 160, 173, 185, 162, 175, 164, 204, 184, 163, 204, 168, 190, 163, 188, 204, 184, 164, 169, 204, 174, 173, 160, 160 }, 236));
        this.Step(_0x8c92cd1a, _0x4b3a4768._0x49161a7d(new byte[9] { 26, 61, 44, 57, 29, 33, 59, 44, 44 }, 73), 0.34f, this._ringIcon, _0x4b3a4768._0x49161a7d(new byte[36] { 39, 32, 35, 43, 79, 35, 42, 41, 59, 79, 32, 61, 79, 61, 38, 40, 39, 59, 101, 59, 32, 79, 59, 38, 35, 59, 79, 59, 39, 42, 79, 45, 32, 46, 61, 43 }, 111));
        Button _0xb573f252 = _0x4538f874.Cta(_0x8c92cd1a, _0x4b3a4768._0x49161a7d(new byte[5] { 219, 243, 232, 213, 232 }, 156), _0x4b3a4768._0x49161a7d(new byte[6] { 220, 212, 207, 187, 210, 207 }, 155), new Vector2(0.5f, 0.13f), new Vector2(520f, 150f), _0x2910d7f9.Magenta, _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.9f), _0x2910d7f9.TextPrimary, 56f, this._plate);
        // Always a lambda: a bare method name survives compilation here and then fails
        // the cloud build once the symbol has been renamed.
        _0xb573f252.onClick.AddListener(() => this._0xb722a39f());
        this._0x916b5abb.gameObject.SetActive(false);
    }

    public void _0x5206dbcd()
    {
        if (this._0x916b5abb == null || this._0x916b5abb.gameObject.activeSelf)
            return;
        this._0x916b5abb.gameObject.SetActive(true);
        this.Kill();
        // DOVirtual rather than a delayed call by method NAME: the name would not
        // survive obfuscation, and the timer would silently stop firing.
        this._0x680cc9a3 = DOVirtual.DelayedCall(AutoCloseSeconds, () => this._0xb722a39f(), false);
    }

    private void OnDestroy()
    {
        this.Kill();
    }

    public void _0xb722a39f()
    {
        this.Kill();
        if (this._0x916b5abb != null)
            this._0x916b5abb.gameObject.SetActive(false);
    }

    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _ringIcon;
    private RectTransform _0x916b5abb;
    private void Kill()
    {
        if (this._0x680cc9a3 != null && this._0x680cc9a3.IsActive())
            this._0x680cc9a3.Kill();
        this._0x680cc9a3 = null;
    }

    [SerializeField]
    private Sprite _magnetIcon;
    private const float StepSize = 42f;
    private const float HintSize = 38f;
    [SerializeField]
    private Sprite _ballIcon;
    public bool _0x6ed82c3c
    {
        get
        {
            return this._0x916b5abb != null && this._0x916b5abb.gameObject.activeSelf;
        }
    }
}

internal static class _0x4b3a4768
{
    internal static string _0x49161a7d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}