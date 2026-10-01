using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x4a69945a;

public class _0x36c8771a : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x36c8771a>();
    }

    public static _0x36c8771a Instance;
    private void Start()
    {
        this._0x6d61e1a3();
    }

    public bool IsShowSplashOnStart = true;
    private void SwitchSplash()
    {
        if (_0x0dfce3a3.Instance.IsTutorialEnabled && !_0xdf57c529._0xa8979062._0x72e938e8)
            this._0x710f4cde(_0xa8f07521.TUTORIAL0);
        else
            this._0x710f4cde(_0xa8f07521.DEFAULT);
    }

    public int CurrentPanelIndex;
    public void _0x710f4cde(int _0x26243889)
    {
        this._0x3254cfe7(_0x26243889);
        this._0x095242f8(_0x26243889);
        this.CurrentPanelIndex = _0x26243889;
        this.Panels[_0x26243889].Show();
    }

    public void _0x44d9bb97(int _0x8e6a0dda)
    {
        if (_0x8e6a0dda == _0xa8f07521.SPLASH && _0xdf57c529.Instance._0xfd2e5a41 != _0x43fa6809.SCENE_0)
            _0xb0d18c71.Instance._0x30ad11fd();
        if (_0xdf57c529.Instance._0xfd2e5a41 != _0x43fa6809.SCENE_0)
        {
            if (_0x8e6a0dda == _0xa8f07521.SPLASH || _0x8e6a0dda == _0xa8f07521.TUTORIAL0)
                _0xdf57c529.Instance._0xfdd151e3(false);
            else if (_0x8e6a0dda == _0xa8f07521.DEFAULT)
                _0xdf57c529.Instance._0xfdd151e3(true);
        }
    }

    private void _0x132475a1(int _0x233e75b0)
    {
        this._0x3254cfe7(_0x233e75b0);
        this._0x095242f8(_0x233e75b0);
        this.CurrentPanelIndex = _0x233e75b0;
        this.Panels[_0x233e75b0]._0x648ab213();
    }

    private void _0x3254cfe7(int _0x6e14d4de)
    {
        this.LastPanelIndexes.Add(_0x6e14d4de);
        this.CurrentPanelIndex = _0x6e14d4de;
        for (int _0xeb2cfcb1 = 0; _0xeb2cfcb1 < this.Panels.Count; _0xeb2cfcb1++)
            if (_0xeb2cfcb1 != _0x6e14d4de && this.Panels[_0xeb2cfcb1] != null)
                this.Panels[_0xeb2cfcb1]._0x8fec137b();
    }

    public void _0x1d6598e3()
    {
        this.LastPanelIndexes.RemoveAll(_0x9db2b44f => _0x9db2b44f == this.CurrentPanelIndex);
        int _0xe346414c = this.LastPanelIndexes.Last();
        this._0x095242f8(_0xe346414c);
        this._0x30ebef2b(_0xe346414c);
        this.CurrentPanelIndex = _0xe346414c;
        this.Panels[_0xe346414c].Show();
    }

    private void _0x6d61e1a3()
    {
        this._0x132475a1(_0xa8f07521.SPLASH);
        if (_0xdf57c529.Instance._0xfd2e5a41 == _0x43fa6809.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xb0d18c71.Instance.DefaultAnimationTime);
        }
    }

    public float ScaleDuration = 0.4f;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x095242f8(int _0x9e9dbd59)
    {
        if (_0x9e9dbd59 == _0xa8f07521.SPLASH)
            _0xb0d18c71.Instance._0x9b4ec686();
        if (_0xdf57c529.Instance._0xfd2e5a41 == _0x43fa6809.SCENE_0)
        {
        }
    }

    private _0x0e1c288e _0x196b3b07(int _0x5befbca3)
    {
        return this.Panels[_0x5befbca3];
    }

    private void _0x30ebef2b(int _0xf51d8d0d)
    {
        this.LastPanelIndexes.Add(_0xf51d8d0d);
        this.CurrentPanelIndex = _0xf51d8d0d;
        for (int _0xb777df70 = 0; _0xb777df70 < this.Panels.Count; _0xb777df70++)
            if (_0xb777df70 != _0xf51d8d0d && this.Panels[_0xb777df70] != null)
                this.Panels[_0xb777df70]._0x8fec137b();
    }

    public List<_0x0e1c288e> Panels;
    public float StaticBlurMaterialInitialValue;
}