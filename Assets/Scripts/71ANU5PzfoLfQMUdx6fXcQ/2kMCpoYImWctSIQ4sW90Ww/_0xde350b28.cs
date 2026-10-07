using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xde350b28 : MonoBehaviour
{
    private Touch? _0x2f2898e9()
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
            return null;
        foreach (Touch _0xfa8345e2 in Touch.activeTouches)
            if (!_0xfa8345e2.ended)
                if (this._0xacc7b500(_0xfa8345e2))
                    return _0xfa8345e2;
        return null;
    }

    private void _0xad188c98(Touch? _0xd1dcba43)
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
        {
            _0xd1dcba43 = null;
            return;
        }

        int _0x6c53f384 = _0xd1dcba43.Value.touchId;
        _0xd1dcba43 = Touch.activeTouches.FirstOrDefault(_0xa7b1c671 => _0xa7b1c671.touchId == _0x6c53f384);
        if (!this._0xacc7b500(_0xd1dcba43.Value))
            _0xd1dcba43 = null;
    }

    private Touch? _0x8de45ed6(Bounds _0x46213f74)
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
            return null;
        foreach (Touch _0x1513a595 in Touch.activeTouches)
            if (_0x1513a595.ended)
            {
                Vector3 _0x1dc10da3 = Camera.main.ScreenToWorldPoint(_0x1513a595.screenPosition);
                Vector3 _0x7646621d = new(_0x1dc10da3.x, _0x1dc10da3.y, _0x46213f74.center.z);
                if (_0x46213f74.Contains(_0x7646621d) && this._0xacc7b500(_0x1513a595))
                    return _0x1513a595;
            }

        return null;
    }

    private Touch? _0x29b85b36(Bounds _0x2a130b4e)
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
            return null;
        foreach (Touch _0xf2c0a6f0 in Touch.activeTouches)
            if (!_0xf2c0a6f0.ended)
            {
                Vector3 _0x58465b88 = Camera.main.ScreenToWorldPoint(_0xf2c0a6f0.screenPosition);
                Vector3 _0xeeab3a90 = new(_0x58465b88.x, _0x58465b88.y, _0x2a130b4e.center.z);
                if (_0x2a130b4e.Contains(_0xeeab3a90) && this._0xacc7b500(_0xf2c0a6f0))
                    return _0xf2c0a6f0;
            }

        return null;
    }

    private Touch? _0xdbd04e7a()
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
            return null;
        foreach (Touch _0x107e5c3b in Touch.activeTouches)
            if (_0x107e5c3b.ended)
                if (this._0xacc7b500(_0x107e5c3b))
                    return _0x107e5c3b;
        return null;
    }

    private bool _0xacc7b500(Touch? _0x67f041d5)
    {
        if (!_0x67f041d5.HasValue)
            return false;
        Vector3 _0xda218970 = Camera.main.ScreenToWorldPoint(_0x67f041d5.Value.screenPosition);
        Vector3 _0xf67ba152 = _0xda218970;
        _0xf67ba152.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xf67ba152))
            return true;
        _0x67f041d5 = null;
        return false;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x78b99b87(Bounds _0x55890513, TouchPhase _0x9a1f7bef)
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
            return null;
        foreach (Touch _0x1113aaec in Touch.activeTouches)
            if (_0x1113aaec.phase == _0x9a1f7bef)
            {
                Vector3 _0x17564d3c = Camera.main.ScreenToWorldPoint(_0x1113aaec.screenPosition);
                Vector3 _0xc059d845 = new(_0x17564d3c.x, _0x17564d3c.y, _0x55890513.center.z);
                if (_0x55890513.Contains(_0xc059d845) && this._0xacc7b500(_0x1113aaec))
                    return _0x1113aaec;
            }

        return null;
    }

    private static _0xde350b28 _0x865f79f8;
    private bool _0x508060e5(Touch? _0xc00dfae6, Bounds _0x35c706b1, TouchPhase _0xb3fcb34d)
    {
        if (!_0xdf57c529.Instance._0xac7816f3)
        {
            _0xc00dfae6 = null;
            return false;
        }

        if (_0xc00dfae6 != null)
            if (_0xc00dfae6.Value.phase == _0xb3fcb34d)
            {
                Vector3 _0x3654794f = Camera.main.ScreenToWorldPoint(_0xc00dfae6.Value.screenPosition);
                Vector3 _0x584f442c = new(_0x3654794f.x, _0x3654794f.y, _0x35c706b1.center.z);
                if (_0x35c706b1.Contains(_0x584f442c) && this._0xacc7b500(_0xc00dfae6.Value))
                    return true;
            }

        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x865f79f8 = this.gameObject.GetComponent<_0xde350b28>();
    }
}