using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x4a69945a;

public class _0x2af55b18 : MonoBehaviour
{
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2af55b18>();
    }

    public static _0x2af55b18 Instance;
    private void _0x5072c73a()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0xb88f5fbb()
    {
        this.LastPopIndexes.RemoveAll(_0x9db2b44f => _0x9db2b44f == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x0e508a2d();
        else
            this._0x2b580bcf(this.LastPopIndexes.Last());
    }

    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x9fc78e23 _0x47cfbb60 in this.Pops)
            if (_0x47cfbb60 != null)
                _0x47cfbb60.gameObject.SetActive(true);
    }

    private void _0x995a8ad3(bool _0xcffe9466 = false)
    {
        for (int _0x104e37c1 = 0; _0x104e37c1 < this.Pops.Count; ++_0x104e37c1)
            if (this.Pops[_0x104e37c1] != null && !(_0x104e37c1 == this.CurrentPopIndex && _0xcffe9466))
                this.Pops[_0x104e37c1]._0x4c0634c3();
    }

    public List<GameObject> GameObjectsToHide;
    public int CurrentPopIndex;
    public _0x9fc78e23 _0x6e27dfcb(int _0xca81e405)
    {
        return this.Pops[_0xca81e405];
    }

    public void _0x2b580bcf(int _0xf10c051f)
    {
        this.CurrentPopIndex = _0xf10c051f;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x995a8ad3(true);
        this._0x8de1336e();
        this.Pops[_0xf10c051f].Show();
        foreach (GameObject _0x9cd25dff in this.GameObjectsToHide)
            _0x9cd25dff.SetActive(false);
    }

    private void _0x8de1336e()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    public void _0x0e508a2d()
    {
        this.LastPopIndexes.Clear();
        this._0x995a8ad3();
        foreach (GameObject _0x97405f24 in this.GameObjectsToHide)
            if (_0x97405f24 != null)
                _0x97405f24.SetActive(true);
        this._0x5072c73a();
    }

    public List<int> LastPopIndexes = new();
    public List<_0x9fc78e23> Pops;
}