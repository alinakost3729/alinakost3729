using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// The tap target that covers the board. It turns a screen tap into a world point and
/// hands it to the run controller, which decides whether a magnet may stand there.
/// The pointer comes from the UI event system, so this works on the new Input System
/// without touching the legacy Input class or the template's private input helper.
/// </summary>
public sealed class _0x119067d7 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData _0xdb2addff)
    {
        if (this._run == null || _0xdb2addff == null)
            return;
        Camera _0xecb49590 = Camera.main;
        if (_0xecb49590 == null)
            return;
        Vector3 _0xfc1bc0d8 = new Vector3(_0xdb2addff.position.x, _0xdb2addff.position.y, -_0xecb49590.transform.position.z);
        Vector3 _0x297d935e = _0xecb49590.ScreenToWorldPoint(_0xfc1bc0d8);
        this._run._0x0b86869a(new Vector2(_0x297d935e.x, _0x297d935e.y));
    }

    [SerializeField]
    private _0xefee6086 _run;
    public void Initialize(_0xefee6086 _0xa5476ee6)
    {
        this._run = _0xa5476ee6;
    }
}