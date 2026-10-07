using UnityEngine;

/// <summary>
/// One switch for a whole group of this game's OWN interface, held as a serialized
/// reference so nothing is ever looked up by name. The run controller uses it to take
/// the control strip off screen while a result card is up and to bring it back after.
/// </summary>
public sealed class _0x9b81c05a : MonoBehaviour
{
    public bool _0x4f2e2b1e
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    public void Initialize(GameObject _0x373792f9)
    {
        this._content = _0x373792f9;
    }

    [SerializeField]
    private GameObject _content;
    public void _0x473981d5(bool _0x54d562cf)
    {
        if (this._content != null)
            this._content.SetActive(_0x54d562cf);
    }
}