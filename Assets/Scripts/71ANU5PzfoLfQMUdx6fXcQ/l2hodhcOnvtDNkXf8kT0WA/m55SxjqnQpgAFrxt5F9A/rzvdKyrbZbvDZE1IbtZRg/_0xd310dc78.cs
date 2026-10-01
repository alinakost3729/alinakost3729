using UnityEngine;
using UnityEngine.UI;

public class _0xd310dc78 : MonoBehaviour
{
    private bool _0xcc1bbbad;
    private void Start()
    {
        if (this._0xcc1bbbad)
            this._0x991a867a.onClick.AddListener(() => _0x36c8771a.Instance._0x1d6598e3());
        else
            this._0x991a867a.onClick.AddListener(() => _0x36c8771a.Instance._0x710f4cde(this._0xfb338e0d));
    }

    private void Awake()
    {
        if (this._0x991a867a == null)
            if (!this.TryGetComponent(out this._0x991a867a))
                this._0x991a867a = this.GetComponentInChildren<Button>();
    }

    private int _0xfb338e0d;
    private Button _0x991a867a;
}