using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xad8460bf : MonoBehaviour
{
    private void _0x55ce9ede()
    {
        if (this._0xcf86bbea.canvasRenderer.GetColor() != this._0x720d1e21.canvasRenderer.GetColor())
            this._0x720d1e21.canvasRenderer.SetColor(this._0xcf86bbea.canvasRenderer.GetColor());
    }

    private Image _0xcf86bbea;
    private TMP_Text _0x720d1e21;
    private void Update()
    {
        this._0x55ce9ede();
    }
}