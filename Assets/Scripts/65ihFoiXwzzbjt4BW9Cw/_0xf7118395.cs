using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// One tilt pad. Holding it leans the board; letting go lets it level out again. The
/// pad lights its own border while held, so the screenshot shows which way the board
/// is leaning and the press is never a silent one.
/// </summary>
public sealed class _0xf7118395 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private Image _border;
    public void OnPointerUp(PointerEventData _0x0d5533e8)
    {
        if (this._border != null)
            this._border.color = this._0x34f2ce85;
        if (this._run != null)
            this._run._0x295c2cbe(this._direction);
    }

    private Color _0x98a9534b = Color.white;
    private void OnDisable()
    {
        if (this._border != null)
            this._border.color = this._0x34f2ce85;
        if (this._run != null)
            this._run._0x295c2cbe(this._direction);
    }

    public void Initialize(_0xefee6086 _0x541cbeba, Image _0x096ecb0c, float _0x5c9f16e7, Color _0xafdc7549, Color _0x24d5a07e)
    {
        this._run = _0x541cbeba;
        this._border = _0x096ecb0c;
        this._direction = _0x5c9f16e7;
        this._0x34f2ce85 = _0xafdc7549;
        this._0x98a9534b = _0x24d5a07e;
        if (this._border != null)
            this._border.color = _0xafdc7549;
    }

    [SerializeField]
    private _0xefee6086 _run;
    private Color _0x34f2ce85 = Color.white;
    [SerializeField]
    private float _direction = 1f;
    public void OnPointerDown(PointerEventData _0x6f2f4dae)
    {
        if (this._border != null)
            this._border.color = this._0x98a9534b;
        if (this._run != null)
            this._run._0x73054ce3(this._direction);
    }
}