using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x47173a25 : MonoBehaviour
{
    private float _0x841325a7;
    private float _0x155f301b = 4;
    private TMP_Text _0x0963f49b;
    private List<string> _0x4538342d = new();
    private float _0xfcb7ae3b = 0.6f;
    private void Update()
    {
        int _0xd9d6646b = 1;
        if (this._0x4538342d.Count > 0)
        {
            string _0x40fca1de = this._0x0963f49b.text;
            foreach (string _0xd7506217 in this._0x4538342d)
                while (_0x40fca1de.Contains(_0xd7506217))
                    _0x40fca1de = _0x40fca1de.Replace(_0xd7506217, "");
            _0xd9d6646b = _0x40fca1de.Length;
        }
        else
        {
            _0xd9d6646b = this._0x0963f49b.text.Length;
        }

        float _0x8dbb158f = Mathf.Clamp(this._0x841325a7 + this._0xfcb7ae3b * _0xd9d6646b, this._0x4b5e5dd2, this._0x155f301b);
        if (!Mathf.Approximately(this._0xa886451b.aspectRatio, _0x8dbb158f))
            this._0xa886451b.aspectRatio = _0x8dbb158f;
    }

    private float _0x4b5e5dd2 = 1.5f;
    private AspectRatioFitter _0xa886451b;
}