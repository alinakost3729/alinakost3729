using TMPro;
using UnityEngine;
using static _0x4a69945a;

public class _0x5c581cb0 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xdae25bcd;
            if (this.gameObject.TryGetComponent(out _0xdae25bcd))
                this.MoneyCountText = _0xdae25bcd;
        }

        this._0x4bc2cc8d();
    }

    public void _0x4bc2cc8d()
    {
        this.MoneyCountText.text = _0x5dc950a9._0x02606895.ToString();
    }

    public TMP_Text MoneyCountText;
}