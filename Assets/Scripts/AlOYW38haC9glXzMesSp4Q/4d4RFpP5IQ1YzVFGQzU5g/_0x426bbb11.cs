using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x426bbb11 : MonoBehaviour
{
    private Canvas _0x3c4ee7a2;
    private RectTransform _0x2ab5e7e1;
    private void OnDestroy()
    {
        if (_0xb0512e6a != null && _0xb0512e6a.Contains(this))
            _0xb0512e6a.Remove(this);
    }

    private static void ResolutionChanged()
    {
        _0x92b0623c.x = Screen.width;
        _0x92b0623c.y = Screen.height;
        _0x6da44e6f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x2899c15b.Invoke();
    }

    private static readonly List<_0x426bbb11> _0xb0512e6a = new();
    private static void SafeAreaChanged()
    {
        _0x6da44e6f = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private CanvasScaler _0xf4e300af;
    private static UnityEvent _0x2899c15b = new();
    private RectTransform _0x1399a512;
    private static Vector2 _0x92b0623c = Vector2.zero;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x91773d0f = 0; _0x91773d0f < _0xb0512e6a.Count; _0x91773d0f++)
            _0xb0512e6a[_0x91773d0f]._0x3bfbb538();
    }

    private static bool _0x8b5af5ea;
    private static void OrientationChanged()
    {
        _0x6cacb266 = Screen.orientation;
        _0x92b0623c.x = Screen.width;
        _0x92b0623c.y = Screen.height;
        _0x6da44e6f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x2899c15b.Invoke();
    }

    private void Update()
    {
        if (_0xb0512e6a.Count == 0 || _0xb0512e6a[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x6cacb266)
            OrientationChanged();
        if (Screen.safeArea != _0x6da44e6f)
            SafeAreaChanged();
        if (Screen.width != _0x92b0623c.x || Screen.height != _0x92b0623c.y)
            ResolutionChanged();
    }

    private static ScreenOrientation _0x6cacb266 = ScreenOrientation.LandscapeLeft;
    private static Rect _0x6da44e6f = Rect.zero;
    private Vector2 _0x7a637f8e;
    private void Awake()
    {
        if (!_0xb0512e6a.Contains(this))
            _0xb0512e6a.Add(this);
        this._0x3c4ee7a2 = this.GetComponent<Canvas>();
        this._0xf4e300af = this.GetComponent<CanvasScaler>();
        if (this._0xf4e300af != null)
            this._0x7a637f8e = this._0xf4e300af.referenceResolution;
        this._0x1399a512 = this.GetComponent<RectTransform>();
        this._0x2ab5e7e1 = this.transform.Find(_0xa422149b._0x958d333a(new byte[8] { 117, 71, 64, 67, 103, 84, 67, 71 }, 38)) as RectTransform;
        if (!_0x8b5af5ea)
        {
            _0x6cacb266 = Screen.orientation;
            _0x92b0623c.x = Screen.width;
            _0x92b0623c.y = Screen.height;
            _0x6da44e6f = Screen.safeArea;
            _0x8b5af5ea = true;
        }

        this._0x3bfbb538();
    }

    private void Start()
    {
    }

    private void _0x3bfbb538()
    {
        if (this._0x2ab5e7e1 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x0f64ff50 = Screen.safeArea;
        Vector2 _0xf4afb105 = _0x0f64ff50.position;
        Vector2 _0x9e855b48 = _0x0f64ff50.position + _0x0f64ff50.size;
        _0xf4afb105.x /= screenWidth;
        _0xf4afb105.y /= screenHeight;
        _0x9e855b48.x /= screenWidth;
        _0x9e855b48.y /= screenHeight;
        this._0x2ab5e7e1.anchorMin = _0xf4afb105;
        this._0x2ab5e7e1.anchorMax = _0x9e855b48;
        this._0x2ab5e7e1.offsetMin = Vector2.zero;
        this._0x2ab5e7e1.offsetMax = Vector2.zero;
        if (this._0xf4e300af == null)
            return;
        Vector2 _0xe155840b = _0x9e855b48 - _0xf4afb105;
        float _0xbd459832 = 2f - _0xe155840b.x;
        float _0x02ae4ae8 = 2f - _0xe155840b.y;
        this._0xf4e300af.referenceResolution = this._0x7a637f8e * new Vector2(_0xbd459832, _0x02ae4ae8);
    }
}

internal static class _0xa422149b
{
    internal static string _0x958d333a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}