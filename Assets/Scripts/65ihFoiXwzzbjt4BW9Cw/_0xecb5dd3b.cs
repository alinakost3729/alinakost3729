using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// Everything the player sees on the board itself. It owns no rules: the run
/// controller hands it a generated arena and a ball position, and this turns that
/// into sprites. Every spawnable comes from a prefab that already carries its draw
/// mode, its world size and its sorting order, so nothing is resized at runtime and
/// nothing can float above the pop canvases.
/// The frame and the vignette are created BEFORE the pegs, the rings and the ball:
/// hierarchy order is draw order, and surrounding trim built afterwards would sit on
/// top of the very contents it is meant to frame.
/// </summary>
public sealed class _0xecb5dd3b : MonoBehaviour
{
    private readonly List<Transform> _0x458bd1d0 = new List<Transform>();
    public void _0x4606e570()
    {
        DOTween.Kill(this._0x7955d87e, true);
        for (int _0x7b24b98a = this._0x7955d87e.childCount - 1; _0x7b24b98a >= 0; _0x7b24b98a--)
            Destroy(this._0x7955d87e.GetChild(_0x7b24b98a).gameObject);
        this._0x5952a2dd.Clear();
        this._0x458bd1d0.Clear();
        this._0x174f0560.Clear();
        this._0x08708afe.Clear();
        this._0x429defe6.Clear();
        this._0x8089e56a.Clear();
        this._0x37aea87a.Clear();
        this._0xedcc47f4 = 0;
        this._0xdc434c6a = null;
        this._0x28d2b4de = null;
    }

    private readonly List<Transform> _0x5952a2dd = new List<Transform>();
    public void _0x30c61fa0()
    {
        for (int _0x370c385c = 0; _0x370c385c < this._0x429defe6.Count; _0x370c385c++)
        {
            this._0x429defe6[_0x370c385c].gameObject.SetActive(false);
            this._0x37aea87a[_0x370c385c] = TrailLifeSeconds;
        }
    }

    // -- magnets and cup -----------------------------------------------------
    public void _0x387ff2ac(Vector2 _0x33796693, int _0xc5f1c1f1)
    {
        if (this._magnetPrefab == null)
            return;
        Transform _0x16c245f8 = Instantiate(this._magnetPrefab, this._0x7955d87e).transform;
        _0x16c245f8.localPosition = new Vector3(_0x33796693.x, _0x33796693.y, 0f);
        SpriteRenderer _0x746bc1cc = _0x16c245f8.GetComponent<SpriteRenderer>();
        if (_0x746bc1cc != null)
            _0x746bc1cc.color = _0xc5f1c1f1 == 0 ? _0x2910d7f9.Cyan : _0x2910d7f9.Magenta;
        this._0x08708afe.Add(_0x16c245f8);
        Vector3 _0x6667d817 = _0x16c245f8.localScale;
        _0x16c245f8.DOPunchScale(_0x6667d817 * 0.25f, 0.3f);
    }

    /// <summary>Drops one more trail dot at the ball and ages the rest.</summary>
    public void _0x7000f4d9(Vector2 _0xf49c05e8, float _0x30f54172)
    {
        if (this._0x429defe6.Count == 0)
            return;
        Transform _0x9ebfec28 = this._0x429defe6[this._0xedcc47f4];
        _0x9ebfec28.localPosition = new Vector3(_0xf49c05e8.x, _0xf49c05e8.y, 0f);
        _0x9ebfec28.gameObject.SetActive(true);
        this._0x37aea87a[this._0xedcc47f4] = 0f;
        this._0xedcc47f4 = (this._0xedcc47f4 + 1) % this._0x429defe6.Count;
        for (int _0x684d800e = 0; _0x684d800e < this._0x429defe6.Count; _0x684d800e++)
        {
            float _0x10ac1375 = this._0x37aea87a[_0x684d800e] + _0x30f54172;
            this._0x37aea87a[_0x684d800e] = _0x10ac1375;
            if (_0x10ac1375 >= TrailLifeSeconds)
            {
                if (this._0x429defe6[_0x684d800e].gameObject.activeSelf)
                    this._0x429defe6[_0x684d800e].gameObject.SetActive(false);
                continue;
            }

            if (_0x684d800e < this._0x8089e56a.Count)
                this._0x8089e56a[_0x684d800e].color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, Mathf.Lerp(0.9f, 0f, _0x10ac1375 / TrailLifeSeconds));
        }
    }

    private _0x5e57d0a4 _0x2e8fdc20;
    public void _0x5a6ee8e0(int _0x4728e9e6)
    {
        if (_0x4728e9e6 < 0 || _0x4728e9e6 >= this._0x458bd1d0.Count)
            return;
        Transform _0x153356c9 = this._0x458bd1d0[_0x4728e9e6];
        this._0xcbf1b99c(_0x4728e9e6, true);
        _0x153356c9.DOPunchScale(Vector3.one * 0.28f, 0.35f);
        this.Sparks(_0x153356c9.localPosition, _0x2910d7f9.Ring(_0x4728e9e6));
    }

    [SerializeField]
    private GameObject _sparkPrefab;
    private Transform _0x7955d87e;
    /// <summary>Lays out one generated arena. Called once per launch, so the board visibly changes.</summary>
    public void Show(_0x8d177026 _0x631f0a03, bool[] _0x08074dba)
    {
        this._0x4606e570();
        if (_0x631f0a03 == null || this._0x2e8fdc20 == null)
            return;
        // Trim first so it ends up UNDER the pegs, the rings and the ball.
        if (this._framePrefab != null)
        {
            Transform _0x3f8b62f9 = Instantiate(this._framePrefab, this._0x7955d87e).transform;
            _0x3f8b62f9.localPosition = new Vector3(0f, this._0x2e8fdc20._0xb85f008c, 0f);
        }

        if (this._cupPrefab != null)
        {
            this._0x28d2b4de = Instantiate(this._cupPrefab, this._0x7955d87e).transform;
            this._0x28d2b4de.localPosition = new Vector3(_0x631f0a03.Cup.x, _0x631f0a03.Cup.y, 0f);
        }

        for (int _0xd225bb0b = 0; _0xd225bb0b < _0x631f0a03.Pegs.Count; _0xd225bb0b++)
        {
            if (this._pegPrefab == null)
                break;
            Transform _0x2c846e4c = Instantiate(this._pegPrefab, this._0x7955d87e).transform;
            _0x2c846e4c.localPosition = new Vector3(_0x631f0a03.Pegs[_0xd225bb0b].x, _0x631f0a03.Pegs[_0xd225bb0b].y, 0f);
            this._0x5952a2dd.Add(_0x2c846e4c);
        }

        for (int _0x5ad4c741 = 0; _0x5ad4c741 < _0x631f0a03.Rings.Count; _0x5ad4c741++)
        {
            if (this._ringPrefab == null)
                break;
            Transform _0xc191e2be = Instantiate(this._ringPrefab, this._0x7955d87e).transform;
            _0xc191e2be.localPosition = new Vector3(_0x631f0a03.Rings[_0x5ad4c741].x, _0x631f0a03.Rings[_0x5ad4c741].y, 0f);
            SpriteRenderer _0xd2b8151d = _0xc191e2be.GetComponent<SpriteRenderer>();
            this._0x458bd1d0.Add(_0xc191e2be);
            this._0x174f0560.Add(_0xd2b8151d);
            bool _0x1fd1f0d0 = _0x08074dba != null && _0x5ad4c741 < _0x08074dba.Length && _0x08074dba[_0x5ad4c741];
            this._0xcbf1b99c(_0x5ad4c741, _0x1fd1f0d0);
        }

        this._0x9612e185();
        if (this._ballPrefab != null)
        {
            this._0xdc434c6a = Instantiate(this._ballPrefab, this._0x7955d87e).transform;
            this._0xdc434c6a.localPosition = new Vector3(this._0x2e8fdc20._0x0866b106.x, this._0x2e8fdc20._0x0866b106.y, 0f);
        }
    }

    private void Sparks(Vector3 _0x697fe0e9, Color _0x861c2e03)
    {
        if (this._sparkPrefab == null)
            return;
        float _0x01504fda = this._0x2e8fdc20 != null ? this._0x2e8fdc20.Cell * 0.78f : 0.45f;
        for (int _0xf79bb5ca = 0; _0xf79bb5ca < SparksPerRing; _0xf79bb5ca++)
        {
            Transform _0x39eadb76 = Instantiate(this._sparkPrefab, this._0x7955d87e).transform;
            _0x39eadb76.localPosition = _0x697fe0e9;
            SpriteRenderer _0x3f959eef = _0x39eadb76.GetComponent<SpriteRenderer>();
            if (_0x3f959eef != null)
            {
                _0x3f959eef.color = _0x861c2e03;
                _0x3f959eef.DOFade(0f, 0.35f);
            }

            float _0xeb90aa61 = _0xf79bb5ca * (2f * Mathf.PI / SparksPerRing);
            Vector3 _0x56900b8e = _0x697fe0e9 + new Vector3(Mathf.Cos(_0xeb90aa61), Mathf.Sin(_0xeb90aa61), 0f) * _0x01504fda;
            GameObject _0x3122afdd = _0x39eadb76.gameObject;
            _0x39eadb76.DOLocalMove(_0x56900b8e, 0.35f).OnComplete(() => Destroy(_0x3122afdd));
        }
    }

    [SerializeField]
    private GameObject _ringPrefab;
    private readonly List<SpriteRenderer> _0x174f0560 = new List<SpriteRenderer>();
    public void Initialize(_0x5e57d0a4 _0x5d236c38)
    {
        this._0x2e8fdc20 = _0x5d236c38;
        this._0x7955d87e = this.transform;
    }

    private int _0xedcc47f4;
    private readonly List<Transform> _0x429defe6 = new List<Transform>();
    public void _0x5a09ab1b(int _0xc6d821f5)
    {
        if (_0xc6d821f5 < 0 || _0xc6d821f5 >= this._0x458bd1d0.Count)
            return;
        Transform _0x33407501 = this._0x458bd1d0[_0xc6d821f5];
        DOTween.Kill(_0x33407501, true);
        _0x33407501.localScale = Vector3.one;
        _0x33407501.DOScale(Vector3.one * 1.12f, 0.18f).SetLoops(2, LoopType.Yoyo);
    }

    private readonly List<SpriteRenderer> _0x8089e56a = new List<SpriteRenderer>();
    [SerializeField]
    private GameObject _framePrefab;
    private const int TrailLength = 24;
    private readonly List<float> _0x37aea87a = new List<float>();
    // -- ball ----------------------------------------------------------------
    public void _0xb40dc64a(Vector2 _0x3ae63eb6)
    {
        if (this._0xdc434c6a != null)
            this._0xdc434c6a.localPosition = new Vector3(_0x3ae63eb6.x, _0x3ae63eb6.y, 0f);
    }

    private Transform _0x28d2b4de;
    private const int SparksPerRing = 8;
    [SerializeField]
    private GameObject _pegPrefab;
    // -- rings ---------------------------------------------------------------
    private void _0xcbf1b99c(int _0xacde04b0, bool _0x00579601)
    {
        if (_0xacde04b0 < 0 || _0xacde04b0 >= this._0x174f0560.Count)
            return;
        SpriteRenderer _0x8e5a9d42 = this._0x174f0560[_0xacde04b0];
        Transform _0x479fd044 = this._0x458bd1d0[_0xacde04b0];
        if (_0x8e5a9d42 == null || _0x479fd044 == null)
            return;
        Color _0x0a5fa6a8 = _0x2910d7f9.Ring(_0xacde04b0);
        _0x8e5a9d42.color = _0x2910d7f9.WithAlpha(_0x0a5fa6a8, _0x00579601 ? 0.25f : 1f);
        DOTween.Kill(_0x479fd044, true);
        _0x479fd044.localScale = Vector3.one;
        if (!_0x00579601)
            _0x479fd044.DOScale(Vector3.one * 1.06f, 1.1f).SetLoops(-1, LoopType.Yoyo);
    }

    // -- trail ---------------------------------------------------------------
    private void _0x9612e185()
    {
        if (this._trailPrefab == null)
            return;
        for (int _0x47325d76 = 0; _0x47325d76 < TrailLength; _0x47325d76++)
        {
            Transform _0x75ff716e = Instantiate(this._trailPrefab, this._0x7955d87e).transform;
            SpriteRenderer _0x07d5c6b4 = _0x75ff716e.GetComponent<SpriteRenderer>();
            if (_0x07d5c6b4 != null)
            {
                _0x07d5c6b4.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0f);
                this._0x8089e56a.Add(_0x07d5c6b4);
            }

            _0x75ff716e.gameObject.SetActive(false);
            this._0x429defe6.Add(_0x75ff716e);
            this._0x37aea87a.Add(TrailLifeSeconds);
        }
    }

    private readonly List<Transform> _0x08708afe = new List<Transform>();
    public void _0x1e04a9e8()
    {
        if (this._0xdc434c6a == null)
            return;
        SpriteRenderer _0xc0ce1a64 = this._0xdc434c6a.GetComponent<SpriteRenderer>();
        if (_0xc0ce1a64 != null)
            _0xc0ce1a64.DOFade(0f, 0.25f);
        this._0x7955d87e.DOShakePosition(0.25f, 0.06f);
    }

    [SerializeField]
    private GameObject _trailPrefab;
    public void _0xe360cfa2()
    {
        if (this._0xdc434c6a == null)
            return;
        Vector3 _0x44a0c7c1 = this._0xdc434c6a.localScale;
        DOTween.Kill(this._0xdc434c6a, true);
        this._0xdc434c6a.localScale = _0x44a0c7c1;
        this._0xdc434c6a.DOScale(_0x44a0c7c1 * 1.3f, 0.12f).SetLoops(2, LoopType.Yoyo);
    }

    private const float TrailLifeSeconds = 1.8f;
    public void _0x18ff96bc()
    {
        if (this._0x28d2b4de == null)
            return;
        this._0x28d2b4de.DOPunchPosition(new Vector3(0f, this._0x2e8fdc20 != null ? this._0x2e8fdc20.Cell * 0.14f : 0.08f, 0f), 0.3f);
        SpriteRenderer _0x3f72f118 = this._0x28d2b4de.GetComponent<SpriteRenderer>();
        if (_0x3f72f118 == null)
            return;
        _0x3f72f118.color = _0x2910d7f9.Gold;
        _0x3f72f118.DOColor(_0x2910d7f9.Green, 0.4f);
    }

    [SerializeField]
    private GameObject _cupPrefab;
    private Transform _0xdc434c6a;
    [SerializeField]
    private GameObject _magnetPrefab;
    [SerializeField]
    private GameObject _ballPrefab;
}