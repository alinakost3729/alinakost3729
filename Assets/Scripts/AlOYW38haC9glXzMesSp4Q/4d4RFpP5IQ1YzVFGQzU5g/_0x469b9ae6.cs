using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x469b9ae6 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0xe139e99b = Screen.safeArea;
        for (int _0x13c57403 = 0; _0x13c57403 < _0x29d25c9a.Count; _0x13c57403++)
            _0x29d25c9a[_0x13c57403]._0xae81caf7();
    }

    private void Awake()
    {
        if (!_0x29d25c9a.Contains(this))
            _0x29d25c9a.Add(this);
        this._0x02a13307 = this.GetComponent<Canvas>();
        this._0x2f58a71a = this.GetComponent<RectTransform>();
        this._0x76e02d14 = this.transform.Find(_0xaba256a8._0xffeecbc1(new byte[8] { 225, 211, 212, 215, 243, 192, 215, 211 }, 178)) as RectTransform;
        if (!_0x988d4419)
        {
            _0x67cb20e7 = Screen.orientation;
            _0x3cc29fc6.x = Screen.width;
            _0x3cc29fc6.y = Screen.height;
            _0xe139e99b = Screen.safeArea;
            _0x988d4419 = true;
        }

        this._0xae81caf7();
    }

    private static UnityEvent _0x1b463470 = new();
    private static Rect _0xe139e99b = Rect.zero;
    private static ScreenOrientation _0x67cb20e7 = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0x67cb20e7 = Screen.orientation;
        _0x3cc29fc6.x = Screen.width;
        _0x3cc29fc6.y = Screen.height;
        _0x1b463470.Invoke();
    }

    private RectTransform _0x76e02d14;
    private void _0xae81caf7()
    {
        if (this._0x76e02d14 == null)
            return;
        Rect _0x58740ee7 = Screen.safeArea;
        Vector2 _0x5791eb06 = _0x58740ee7.position;
        Vector2 _0x26b31021 = _0x58740ee7.position + _0x58740ee7.size;
        _0x5791eb06.x /= this._0x02a13307.pixelRect.width;
        _0x5791eb06.y /= this._0x02a13307.pixelRect.height;
        _0x26b31021.x /= this._0x02a13307.pixelRect.width;
        _0x26b31021.y /= this._0x02a13307.pixelRect.height;
        this._0x76e02d14.anchorMin = _0x5791eb06;
        this._0x76e02d14.anchorMax = _0x26b31021;
    }

    private static bool _0x988d4419;
    private static void ResolutionChanged()
    {
        _0x3cc29fc6.x = Screen.width;
        _0x3cc29fc6.y = Screen.height;
        _0x1b463470.Invoke();
    }

    private static Vector2 _0x3cc29fc6 = Vector2.zero;
    private void Update()
    {
        if (_0x29d25c9a[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x67cb20e7)
            OrientationChanged();
        if (Screen.safeArea != _0xe139e99b)
            SafeAreaChanged();
        if (Screen.width != _0x3cc29fc6.x || Screen.height != _0x3cc29fc6.y)
            ResolutionChanged();
    }

    private static readonly List<_0x469b9ae6> _0x29d25c9a = new();
    private void OnDestroy()
    {
        if (_0x29d25c9a != null && _0x29d25c9a.Contains(this))
            _0x29d25c9a.Remove(this);
    }

    private RectTransform _0x2f58a71a;
    private Canvas _0x02a13307;
}

internal static class _0xaba256a8
{
    internal static string _0xffeecbc1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}