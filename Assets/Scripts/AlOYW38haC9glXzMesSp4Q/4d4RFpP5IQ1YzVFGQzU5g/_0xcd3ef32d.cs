using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xcd3ef32d : MonoBehaviour
{
    private Color _0x6208f104 = Color.white;
    private Vector3 _0x5c9bb03d { get; set; }

    private float _0x00c42e77 = 1;
    private Vector3 _0xc56fc1e3 { get; set; }

    private new Camera _0x5e9a027a;
    private Vector3 _0xc0243fae { get; set; }
    private Vector3 _0xf6dcbc61 { get; set; }
    private Vector3 _0x7fe1f040 { get; set; }
    private Vector3 _0xe3196fa9 { get; set; }
    private Vector3 _0xea074b32 { get; set; }
    private Vector3 _0x64636ba0 { get; set; }

    private _0x6956acee _0x8e2aa762 = _0x6956acee.Portrait;
    private void Awake()
    {
        this._0x5e9a027a = this.GetComponent<Camera>();
        _0x47671c41 = this;
        this._0x3b938034();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x6208f104;
        Matrix4x4 _0x58fe80a0 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x5e9a027a.orthographic)
        {
            float _0x7ad67307 = this._0x5e9a027a.farClipPlane - this._0x5e9a027a.nearClipPlane;
            float _0xf1544feb = (this._0x5e9a027a.farClipPlane + this._0x5e9a027a.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xf1544feb), new Vector3(this._0x5e9a027a.orthographicSize * 2 * this._0x5e9a027a.aspect, this._0x5e9a027a.orthographicSize * 2, _0x7ad67307));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x5e9a027a.fieldOfView, this._0x5e9a027a.farClipPlane, this._0x5e9a027a.nearClipPlane, this._0x5e9a027a.aspect);
        }

        Gizmos.matrix = _0x58fe80a0;
    }

    private static _0xcd3ef32d _0x47671c41;
    private float _0x385f88ae { get; set; }

    public enum _0x6956acee
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x8dfe4b36 { get; set; }
    //public bool executeInUpdate;
    private float _0x06dc2140 { get; set; }

    private void _0x3b938034()
    {
        float _0x03335675, _0xdcfdf61e, _0x37131320, _0x5d360011;
        if (this._0x8e2aa762 == _0x6956acee.Landscape)
            this._0x5e9a027a.orthographicSize = 1f / this._0x5e9a027a.aspect * this._0x00c42e77 / 2f;
        else
            this._0x5e9a027a.orthographicSize = this._0x00c42e77 / 2f;
        this._0x385f88ae = 2f * this._0x5e9a027a.orthographicSize;
        this._0x06dc2140 = this._0x385f88ae * this._0x5e9a027a.aspect;
        float _0x14fe96c3 = this._0x5e9a027a.transform.position.x;
        float _0x49019867 = this._0x5e9a027a.transform.position.y;
        _0x03335675 = _0x14fe96c3 - this._0x06dc2140 / 2;
        _0xdcfdf61e = _0x14fe96c3 + this._0x06dc2140 / 2;
        _0x37131320 = _0x49019867 + this._0x385f88ae / 2;
        _0x5d360011 = _0x49019867 - this._0x385f88ae / 2;
        this._0x5c9bb03d = new Vector3(_0x03335675, _0x5d360011, 0);
        this._0x64636ba0 = new Vector3(_0x14fe96c3, _0x5d360011, 0);
        this._0xc0243fae = new Vector3(_0xdcfdf61e, _0x5d360011, 0);
        this._0xf6dcbc61 = new Vector3(_0x03335675, _0x49019867, 0);
        this._0xe3196fa9 = new Vector3(_0x14fe96c3, _0x49019867, 0);
        this._0xea074b32 = new Vector3(_0xdcfdf61e, _0x49019867, 0);
        this._0x7fe1f040 = new Vector3(_0x03335675, _0x37131320, 0);
        this._0xc56fc1e3 = new Vector3(_0x14fe96c3, _0x37131320, 0);
        this._0x8dfe4b36 = new Vector3(_0xdcfdf61e, _0x37131320, 0);
    }
}