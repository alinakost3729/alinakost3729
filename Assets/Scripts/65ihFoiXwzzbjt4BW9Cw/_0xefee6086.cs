using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The board scene's director: it owns the round, the arena and the ball, and it is
/// the only thing that decides when a card is shown.
/// Two rules shape the whole loop. A launch that nobody touches still has to fly and
/// still has to collect - the review capture never presses anything - and the round
/// has to outlive the capture window, which is why a launch is floated by the board
/// brake until its minimum and steered home after its maximum instead of being cut
/// short. Nothing here is found by name: the template is reached through its own
/// public singletons and everything else arrives as a serialized reference.
/// </summary>
public sealed class _0xefee6086 : MonoBehaviour
{
    private const float MagnetClearance = 0.8f;
    private void Update()
    {
        _0xdf57c529 _0xc86f3cd0 = _0xdf57c529.Instance;
        if (_0xc86f3cd0 != null && !_0xc86f3cd0._0xac7816f3)
            return;
        float delta = Time.deltaTime;
        this._0x1c058020 += delta;
        if (this._0x3ef89194 == _0xcff55387.Aim)
        {
            // The round never waits on input it may never get.
            if (this._0x1c058020 >= _0xd9cb9715.AimSeconds)
                this._0x86a37764();
            return;
        }

        if (this._0x3ef89194 == _0xcff55387.Banner)
        {
            if (this._0x1c058020 >= _0xd9cb9715.BannerSeconds)
            {
                this._0xb8088254++;
                this._0x492aca97();
            }

            return;
        }

        if (this._0x3ef89194 != _0xcff55387.Run || this._0x0cfc28f8 == null)
            return;
        this._0xf5e3fe29 = Mathf.MoveTowards(this._0xf5e3fe29, this._0xb86930f1, delta / _0xd9cb9715.TiltRamp);
        this._0x7819dee8 += delta;
        int _0x34832344 = 0;
        while (this._0x7819dee8 >= _0xd9cb9715.StepSeconds && _0x34832344 < 8)
        {
            this._0x7819dee8 -= _0xd9cb9715.StepSeconds;
            _0x34832344++;
            this._0x0cfc28f8.Step(_0xd9cb9715.StepSeconds, this._0xf5e3fe29);
            if (this._0x0cfc28f8.JustTaken >= 0)
                this._0x4106744a(this._0x0cfc28f8.JustTaken);
            if (this._0x0cfc28f8.State != _0x7d39f0c5._0xd3703dec.Flying)
                break;
        }

        if (this._board != null)
        {
            this._board._0xb40dc64a(this._0x0cfc28f8.Position);
            this._board._0x7000f4d9(this._0x0cfc28f8.Position, delta);
            if (this._0x0cfc28f8._0x8823ac6d)
                this._board._0x5a09ab1b(this._0x0cfc28f8._0x33dcecb3);
        }

        if (this._0x0cfc28f8.State != _0x7d39f0c5._0xd3703dec.Flying)
            this._0x94842996(this._0x0cfc28f8.State == _0x7d39f0c5._0xd3703dec.Scored);
    }

    /// <summary>
    /// This game's own top bar. The template's LEFT_BUTTON and RIGHT_BUTTON are NOT
    /// reused for it: the pipeline stage that clears template leftovers switches those
    /// two off by name every run, so anything re-skinned onto them disappears before the
    /// build is photographed. Ours are separate objects with their own handlers, and the
    /// template pair is left entirely alone for that stage to take away.
    /// </summary>
    private void _0x40d8cdf5(Transform _0x545b9fe0)
    {
        Button _0xc9b40d1d = this._0x9f33bade(_0x545b9fe0, _0x2a80a88d._0x22928aad(new byte[10] { 118, 85, 87, 95, 118, 65, 64, 64, 91, 90 }, 52), this._backIcon, new Vector2(0.11f, 0.963f));
        _0xc9b40d1d.onClick.AddListener(() => this._0xffb4e9fb());
        Button _0x3b6be67e = this._0x9f33bade(_0x545b9fe0, _0x2a80a88d._0x22928aad(new byte[11] { 207, 254, 234, 236, 250, 221, 234, 235, 235, 240, 241 }, 159), this._pauseIcon, new Vector2(0.89f, 0.963f));
        _0x3b6be67e.onClick.AddListener(() => this._0xcad5521f());
    }

    [SerializeField]
    private Sprite _plate;
    /// <summary>
    /// Raises the pause card. The card is fetched BEFORE it is raised for two reasons:
    /// the template's own accessor indexes its list without checking, so an index this
    /// template never shipped would throw on the player's tap, and a card raised before
    /// it has been given this game's wording shows the template's for a frame.
    /// </summary>
    private void _0xcad5521f()
    {
        _0x2af55b18 _0x44b1dbe1 = _0x2af55b18.Instance;
        if (_0x44b1dbe1 == null || _0x44b1dbe1.Pops == null || _0x4a69945a._0x7e52c9eb.PAUSE >= _0x44b1dbe1.Pops.Count)
            return;
        _0x9fc78e23 _0x1a50bb07 = _0x44b1dbe1._0x6e27dfcb(_0x4a69945a._0x7e52c9eb.PAUSE);
        if (_0x1a50bb07 == null)
            return;
        this._0x8f87d4d7(this._0x8491f48d());
        _0xdf57c529 _0x20f4731e = _0xdf57c529.Instance;
        if (_0x20f4731e != null)
            _0x20f4731e._0xfdd151e3(false);
        _0x44b1dbe1._0x2b580bcf(_0x4a69945a._0x7e52c9eb.PAUSE);
    }

    private int _0x892985ef;
    [SerializeField]
    private _0xd8561052 _pops;
    private int _0xdb8e0e2f;
    private bool[] _0x5475af86;
    private const float ControlY = 0.115f;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, true);
    }

    // -- read-outs -----------------------------------------------------------
    private int _0x8491f48d()
    {
        int _0xa95bce0c = 0;
        for (int _0xd74314d3 = 0; _0xd74314d3 < this._0x5475af86.Length; _0xd74314d3++)
        {
            if (this._0x5475af86[_0xd74314d3])
                _0xa95bce0c++;
        }

        return _0xa95bce0c;
    }

    private void Start()
    {
        Camera _0xb141e2c3 = Camera.main;
        this._0xb1a6bd4d = new _0x5e57d0a4(_0xb141e2c3);
        this._0x34a38d93 = new _0x61f5c89c(this._0xb1a6bd4d);
        this._0x0cfc28f8 = null;
        this._0x892985ef = _0xcf552857._0xc42aaad0;
        this._0x5475af86 = new bool[_0xd9cb9715.RingsPerCircuit];
        this._0x2c7775b2 = _0xd9cb9715.LaunchesStart;
        this._0xdb8e0e2f = _0xd9cb9715.LaunchesStart;
        this._0xb8088254 = 1;
        this._0x19e20099 = 0;
        if (this._cleaner != null)
            this._cleaner._0x413b69ac();
        this._0x7bb958ac();
        this._0x492aca97();
    }

    private void _0x4e7b3a72()
    {
        int _0xfc0dc586 = this._0x8491f48d();
        if (this._hud != null)
        {
            this._hud._0x3de40eba(_0xfc0dc586, _0xd9cb9715.RingsPerCircuit);
            this._hud.SetLaunches(Mathf.Max(0, this._0xdb8e0e2f), this._0x2c7775b2);
            this._hud._0x185ed9ad(_0x4a69945a._0x5dc950a9._0x02606895);
        }

        this._0x8f87d4d7(_0xfc0dc586);
    }

    private void _0x86a37764()
    {
        if (this._0x3ef89194 != _0xcff55387.Aim)
            return;
        if (this._overlay != null)
            this._overlay._0xb722a39f();
        // Whatever the player did not place, the generator placed for them: the arena
        // was proven with these very points, so a hands-off launch still collects.
        for (int _0x5db82afb = this._0x4f84a850.Count; _0x5db82afb < _0xd9cb9715.MagnetsPerLaunch; _0x5db82afb++)
        {
            if (_0x5db82afb >= this._0x5181c5fb.DefaultMagnets.Count)
                break;
            Vector2 _0x30efe72a = this._0x5181c5fb.DefaultMagnets[_0x5db82afb];
            this._0x4f84a850.Add(_0x30efe72a);
            if (this._board != null)
                this._board._0x387ff2ac(_0x30efe72a, _0x5db82afb);
        }

        this._0x0cfc28f8 = new _0x7d39f0c5(this._0xb1a6bd4d, this._0x5181c5fb);
        this._0x0cfc28f8._0xf6576928(this._0x5475af86, this._0x4f84a850);
        this._0x7819dee8 = 0f;
        this._0x3ef89194 = _0xcff55387.Run;
        this._0x1c058020 = 0f;
        this._0x874b50da(false);
        if (this._board != null)
        {
            this._board._0x30c61fa0();
            this._board._0xb40dc64a(this._0x0cfc28f8.Position);
            this._board._0xe360cfa2();
        }
    }

    /// <summary>
    /// All three cards are kept current, not just the one about to open: pause is
    /// raised by the template's own button at a moment this controller never hears
    /// about, and a stale card is the one the reviewer would photograph.
    /// </summary>
    private void _0x8f87d4d7(int _0xed6ae56d)
    {
        if (this._pops == null)
            return;
        string _0xf06c7759 = _0x2a80a88d._0x22928aad(new byte[6] { 194, 217, 222, 215, 195, 176 }, 144) + _0xed6ae56d.ToString() + _0x2a80a88d._0x22928aad(new byte[1] { 18 }, 61) + _0xd9cb9715.RingsPerCircuit.ToString();
        string _0xbc697b93 = _0x2a80a88d._0x22928aad(new byte[9] { 35, 46, 58, 33, 44, 39, 42, 60, 79 }, 111) + Mathf.Max(0, this._0xdb8e0e2f).ToString() + _0x2a80a88d._0x22928aad(new byte[1] { 246 }, 217) + this._0x2c7775b2.ToString();
        this._pops._0x344efdc4(_0x4a69945a._0x7e52c9eb.WIN, _0x2a80a88d._0x22928aad(new byte[15] { 75, 65, 90, 75, 93, 65, 92, 40, 75, 68, 77, 73, 90, 77, 76 }, 8), _0xf06c7759, _0x2a80a88d._0x22928aad(new byte[7] { 134, 138, 140, 139, 150, 229, 238 }, 197) + this._0x19e20099.ToString(), new string[] { _0x2a80a88d._0x22928aad(new byte[12] { 168, 163, 190, 178, 198, 165, 175, 180, 165, 179, 175, 178 }, 230), _0x2a80a88d._0x22928aad(new byte[4] { 238, 230, 237, 246 }, 163) });
        this._pops._0x344efdc4(_0x4a69945a._0x7e52c9eb.LOSE, _0x2a80a88d._0x22928aad(new byte[12] { 226, 232, 243, 226, 244, 232, 245, 129, 237, 238, 242, 245 }, 161), _0xf06c7759, _0xbc697b93, new string[] { _0x2a80a88d._0x22928aad(new byte[5] { 135, 144, 129, 135, 140 }, 213), _0x2a80a88d._0x22928aad(new byte[4] { 243, 251, 240, 235 }, 190) });
        this._pops._0x344efdc4(_0x4a69945a._0x7e52c9eb.PAUSE, _0x2a80a88d._0x22928aad(new byte[6] { 224, 241, 229, 227, 245, 244 }, 176), _0xf06c7759, _0xbc697b93, new string[] { _0x2a80a88d._0x22928aad(new byte[6] { 77, 90, 76, 74, 82, 90 }, 31), _0x2a80a88d._0x22928aad(new byte[4] { 227, 235, 224, 251 }, 174) });
    }

    private void TiltPad(Transform _0xdc4126de, string _0x779af18e, string _0x070800dd, float _0xef77f0f4, float _0xa7131e2c)
    {
        RectTransform _0x6a038f51 = _0x4538f874.Node(_0xdc4126de, _0x779af18e, new Vector2(_0xef77f0f4, 0.5f), new Vector2(360f, 170f));
        Image _0x20dbddc7 = _0x6a038f51.gameObject.AddComponent<Image>();
        _0x20dbddc7.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.35f);
        _0x20dbddc7.raycastTarget = true;
        if (this._plate != null)
        {
            _0x20dbddc7.sprite = this._plate;
            _0x20dbddc7.type = Image.Type.Sliced;
        }

        RectTransform _0x8fee9081 = _0x4538f874.Stretch(_0x6a038f51, _0x779af18e + _0x2a80a88d._0x22928aad(new byte[4] { 231, 200, 205, 205 }, 161));
        _0x8fee9081.offsetMin = new Vector2(6f, 6f);
        _0x8fee9081.offsetMax = new Vector2(-6f, -6f);
        Image _0x1d919d6c = _0x8fee9081.gameObject.AddComponent<Image>();
        _0x1d919d6c.color = _0x2910d7f9.Surface;
        _0x1d919d6c.raycastTarget = false;
        if (this._plate != null)
        {
            _0x1d919d6c.sprite = this._plate;
            _0x1d919d6c.type = Image.Type.Sliced;
        }

        _0x4538f874.Label(_0x6a038f51, _0x779af18e + _0x2a80a88d._0x22928aad(new byte[5] { 221, 240, 243, 244, 253 }, 145), _0x070800dd, new Vector2(0.5f, 0.5f), new Vector2(320f, 110f), 48f, _0x2910d7f9.TextPrimary, TextAlignmentOptions.Center);
        _0xf7118395 _0xdebfa4f7 = _0x6a038f51.gameObject.AddComponent<_0xf7118395>();
        _0xdebfa4f7.Initialize(this, _0x20dbddc7, _0xa7131e2c, _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.35f), _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 1f));
    }

    private _0x8d177026 _0x5181c5fb;
    [SerializeField]
    private Sprite _backIcon;
    private float _0x7819dee8;
    private _0x5e57d0a4 _0xb1a6bd4d;
    private void _0xffb4e9fb()
    {
        _0xdf57c529 _0x68528e00 = _0xdf57c529.Instance;
        if (_0x68528e00 == null)
            return;
        _0x68528e00._0xfdd151e3(true);
        _0x68528e00.LoadSceneByIndex(_0x4a69945a._0x43fa6809.SCENE_0);
    }

    // -- input, called back from the tap layer and the pads -------------------
    /// <summary>
    /// A magnet may not stand on top of a ring, the cup or a rail: it would either
    /// swallow the ball at the exact point the arena was proven through, or pin it
    /// against the wall.
    /// </summary>
    public void _0x0b86869a(Vector2 _0x495c7f9b)
    {
        if (this._0x3ef89194 != _0xcff55387.Aim || this._0x5181c5fb == null)
            return;
        if (this._overlay != null && this._overlay._0x6ed82c3c)
            return;
        if (this._0x4f84a850.Count >= _0xd9cb9715.MagnetsPerLaunch)
            return;
        if (_0x495c7f9b.y > this._0xb1a6bd4d.TopY || _0x495c7f9b.y < this._0xb1a6bd4d._0xd48a50b3)
            return;
        if (Mathf.Abs(_0x495c7f9b.x) > this._0xb1a6bd4d._0x0ab73082 - MagnetClearance * 0.5f)
            return;
        for (int _0xdebfa529 = 0; _0xdebfa529 < this._0x5181c5fb.Rings.Count; _0xdebfa529++)
        {
            if ((this._0x5181c5fb.Rings[_0xdebfa529] - _0x495c7f9b).sqrMagnitude < MagnetClearance * MagnetClearance)
                return;
        }

        if ((this._0x5181c5fb.Cup - _0x495c7f9b).sqrMagnitude < MagnetClearance * MagnetClearance)
            return;
        for (int _0xb5e7905d = 0; _0xb5e7905d < this._0x4f84a850.Count; _0xb5e7905d++)
        {
            if ((this._0x4f84a850[_0xb5e7905d] - _0x495c7f9b).sqrMagnitude < MagnetClearance * MagnetClearance)
                return;
        }

        int _0x6e35ce5b = this._0x4f84a850.Count;
        this._0x4f84a850.Add(_0x495c7f9b);
        if (this._board != null)
            this._board._0x387ff2ac(_0x495c7f9b, _0x6e35ce5b);
    }

    private void _0x94842996(bool _0xf2528923)
    {
        if (this._board != null)
        {
            if (_0xf2528923)
                this._board._0x18ff96bc();
            else
                this._board._0x1e04a9e8();
        }

        if (_0xf2528923)
        {
            this._0x19e20099 += _0xd9cb9715.CoinsPerCup;
            _0xcf552857.AddCoins(_0xd9cb9715.CoinsPerCup);
        }

        this._0xdb8e0e2f--;
        // The refillable side of the round: three rings in one launch buy another one,
        // so the six-ring target stays reachable by playing rather than by luck.
        if (this._0x114c9a7c >= _0xd9cb9715.RingsPerBonusLaunch && this._0x2c7775b2 < _0xd9cb9715.LaunchesCap)
        {
            this._0x2c7775b2++;
            this._0xdb8e0e2f++;
        }

        int _0xdc4c623f = this._0x8491f48d();
        _0xcf552857.RecordRings(_0xdc4c623f);
        this._0x4e7b3a72();
        if (_0xdc4c623f >= _0xd9cb9715.RingsPerCircuit && _0xf2528923)
        {
            this._0x203849c5(true, _0xdc4c623f);
            return;
        }

        if (this._0xdb8e0e2f <= 0)
        {
            this._0x203849c5(false, _0xdc4c623f);
            return;
        }

        this._0x3ef89194 = _0xcff55387.Banner;
        this._0x1c058020 = 0f;
        this._0x874b50da(false);
        if (this._hud != null)
        {
            string _0xe1bb0b3b = _0xf2528923 ? _0x2a80a88d._0x22928aad(new byte[6] { 145, 138, 141, 132, 227, 187 }, 195) + this._0x114c9a7c.ToString() + _0x2a80a88d._0x22928aad(new byte[10] { 132, 137, 132, 232, 229, 241, 234, 231, 236, 132 }, 164) + (this._0x2c7775b2 - this._0xdb8e0e2f + 1).ToString() + _0x2a80a88d._0x22928aad(new byte[4] { 5, 106, 99, 5 }, 37) + this._0x2c7775b2.ToString() : _0x2a80a88d._0x22928aad(new byte[9] { 115, 112, 125, 125, 17, 125, 126, 98, 101 }, 49);
            this._hud._0x9f5c1a0b(_0xe1bb0b3b);
        }
    }

    private int _0x2c7775b2;
    private void _0x203849c5(bool _0x140f8bcd, int _0x07497950)
    {
        this._0x3ef89194 = _0xcff55387.Ended;
        this._0x874b50da(false);
        if (this._stripGate != null)
            this._stripGate._0x473981d5(false);
        if (this._hud != null)
            this._hud._0x9f5c1a0b(_0x140f8bcd ? _0x2a80a88d._0x22928aad(new byte[15] { 123, 113, 106, 123, 109, 113, 108, 24, 123, 116, 125, 121, 106, 125, 124 }, 56) : _0x2a80a88d._0x22928aad(new byte[16] { 95, 94, 49, 93, 80, 68, 95, 82, 89, 84, 66, 49, 93, 84, 87, 69 }, 17));
        if (_0x140f8bcd)
            _0xcf552857.UnlockAfter(this._0x892985ef);
        this._0x8f87d4d7(_0x07497950);
        _0x2af55b18 _0xb30b78fe = _0x2af55b18.Instance;
        if (_0xb30b78fe != null)
            _0xb30b78fe._0x2b580bcf(_0x140f8bcd ? _0x4a69945a._0x7e52c9eb.WIN : _0x4a69945a._0x7e52c9eb.LOSE);
    }

    // -- construction --------------------------------------------------------
    private void _0x7bb958ac()
    {
        _0x36c8771a _0xd976b913 = _0x36c8771a.Instance;
        if (_0xd976b913 == null || _0xd976b913.Panels == null || _0x4a69945a._0xa8f07521.DEFAULT >= _0xd976b913.Panels.Count)
            return;
        _0x0e1c288e _0xc8bde6e4 = _0xd976b913.Panels[_0x4a69945a._0xa8f07521.DEFAULT];
        if (_0xc8bde6e4 == null || _0xc8bde6e4.Content == null)
            return;
        Transform _0xfb9f9545 = _0xc8bde6e4.Content.transform;
        // The board tap layer is created FIRST so it sits under every control: a hit
        // area laid over the buttons would eat their presses.
        Image _0xc305f9be = _0x4538f874.HitLayer(_0xfb9f9545, _0x2a80a88d._0x22928aad(new byte[13] { 70, 107, 101, 118, 96, 80, 101, 116, 72, 101, 125, 97, 118 }, 4), new Vector2(0f, 0.22f), new Vector2(1f, 0.86f));
        _0x119067d7 _0xfe165b5b = _0xc305f9be.gameObject.AddComponent<_0x119067d7>();
        _0xfe165b5b.Initialize(this);
        if (this._board != null)
            this._board.Initialize(this._0xb1a6bd4d);
        if (this._hud != null)
            this._hud._0xbc2ff4b9(_0xfb9f9545, this._plate);
        RectTransform _0x9bdd180a = _0x4538f874.Node(_0xfb9f9545, _0x2a80a88d._0x22928aad(new byte[12] { 117, 89, 88, 66, 68, 89, 90, 101, 66, 68, 95, 70 }, 54), new Vector2(0.5f, ControlY), new Vector2(1242f, 300f));
        _0x9bdd180a.anchoredPosition = Vector2.zero;
        if (this._stripGate != null)
            this._stripGate.Initialize(_0x9bdd180a.gameObject);
        this._0x92ae9dbb = _0x4538f874.Stretch(_0x9bdd180a, _0x2a80a88d._0x22928aad(new byte[8] { 132, 172, 168, 150, 177, 183, 172, 181 }, 197));
        Button _0x814484e3 = _0x4538f874.Cta(this._0x92ae9dbb, _0x2a80a88d._0x22928aad(new byte[6] { 174, 131, 151, 140, 129, 138 }, 226), _0x2a80a88d._0x22928aad(new byte[6] { 89, 84, 64, 91, 86, 93 }, 21), new Vector2(0.5f, 0.5f), new Vector2(700f, 170f), _0x2910d7f9.Magenta, _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.9f), _0x2910d7f9.TextPrimary, 62f, this._plate);
        _0x814484e3.onClick.AddListener(() => this._0x86a37764());
        this._0x8dfb3770 = _0x4538f874.Stretch(_0x9bdd180a, _0x2a80a88d._0x22928aad(new byte[8] { 1, 38, 61, 0, 39, 33, 58, 35 }, 83));
        this.TiltPad(this._0x8dfb3770, _0x2a80a88d._0x22928aad(new byte[8] { 1, 60, 57, 33, 25, 48, 51, 33 }, 85), _0x2a80a88d._0x22928aad(new byte[7] { 38, 38, 58, 86, 95, 92, 78 }, 26), 0.16f, -1f);
        this.TiltPad(this._0x8dfb3770, _0x2a80a88d._0x22928aad(new byte[9] { 249, 196, 193, 217, 255, 196, 202, 197, 217 }, 173), _0x2a80a88d._0x22928aad(new byte[8] { 211, 200, 198, 201, 213, 161, 191, 191 }, 129), 0.84f, 1f);
        this._0x8dfb3770.gameObject.SetActive(false);
        if (this._overlay != null)
            this._overlay._0xfed66db8(_0xfb9f9545);
        this._0x40d8cdf5(_0xfb9f9545);
        this._0x4e7b3a72();
    }

    private enum _0xcff55387
    {
        Aim = 0,
        Run = 1,
        Banner = 2,
        Ended = 3,
    }

    private _0x61f5c89c _0x34a38d93;
    [SerializeField]
    private _0x9b81c05a _stripGate;
    [SerializeField]
    private _0xecb5dd3b _board;
    private void _0x4106744a(int _0xe908b1b2)
    {
        this._0x114c9a7c++;
        this._0x19e20099 += _0xd9cb9715.CoinsPerRing;
        _0xcf552857.AddCoins(_0xd9cb9715.CoinsPerRing);
        if (this._board != null)
            this._board._0x5a6ee8e0(_0xe908b1b2);
        this._0x4e7b3a72();
    }

    private _0xcff55387 _0x3ef89194 = _0xcff55387.Aim;
    public void _0x73054ce3(float _0x969b5a24)
    {
        this._0xb86930f1 = _0x969b5a24;
    }

    private readonly List<Vector2> _0x4f84a850 = new List<Vector2>();
    private int _0x19e20099;
    [SerializeField]
    private _0x3e85366c _cleaner;
    private void _0x874b50da(bool _0x898dd7f3)
    {
        if (this._stripGate != null)
            this._stripGate._0x473981d5(true);
        if (this._0x92ae9dbb != null)
            this._0x92ae9dbb.gameObject.SetActive(_0x898dd7f3);
        if (this._0x8dfb3770 != null)
            this._0x8dfb3770.gameObject.SetActive(!_0x898dd7f3 && this._0x3ef89194 == _0xcff55387.Run);
    }

    private RectTransform _0x8dfb3770;
    private Button _0x9f33bade(Transform _0x9d5d34c9, string _0xa5eb251f, Sprite _0x8ada1d18, Vector2 _0x71c363dc)
    {
        RectTransform _0x484b2c49 = _0x4538f874.Node(_0x9d5d34c9, _0xa5eb251f, _0x71c363dc, new Vector2(120f, 120f));
        Image _0x87a2355e = _0x484b2c49.gameObject.AddComponent<Image>();
        _0x87a2355e.color = _0x2910d7f9.WithAlpha(_0x2910d7f9.Cyan, 0.85f);
        _0x87a2355e.raycastTarget = true;
        if (this._plate != null)
        {
            _0x87a2355e.sprite = this._plate;
            _0x87a2355e.type = Image.Type.Sliced;
        }

        RectTransform _0x8e5a5e54 = _0x4538f874.Stretch(_0x484b2c49, _0xa5eb251f + _0x2a80a88d._0x22928aad(new byte[4] { 8, 39, 34, 34 }, 78));
        _0x8e5a5e54.offsetMin = new Vector2(5f, 5f);
        _0x8e5a5e54.offsetMax = new Vector2(-5f, -5f);
        Image _0x771b23c0 = _0x8e5a5e54.gameObject.AddComponent<Image>();
        _0x771b23c0.color = _0x2910d7f9.Surface;
        _0x771b23c0.raycastTarget = false;
        if (this._plate != null)
        {
            _0x771b23c0.sprite = this._plate;
            _0x771b23c0.type = Image.Type.Sliced;
        }

        if (_0x8ada1d18 != null)
            _0x4538f874.Picture(_0x484b2c49, _0xa5eb251f + _0x2a80a88d._0x22928aad(new byte[4] { 7, 45, 33, 32 }, 78), new Vector2(0.5f, 0.5f), new Vector2(62f, 62f), _0x8ada1d18, _0x2910d7f9.Cyan);
        Button _0x0b04a065 = _0x484b2c49.gameObject.AddComponent<Button>();
        _0x0b04a065.targetGraphic = _0x771b23c0;
        return _0x0b04a065;
    }

    private _0x7d39f0c5 _0x0cfc28f8;
    [SerializeField]
    private _0xcfca063d _hud;
    private float _0xf5e3fe29;
    private float _0x1c058020;
    [SerializeField]
    private Sprite _pauseIcon;
    // -- round flow ----------------------------------------------------------
    private void _0x492aca97()
    {
        this._0x5181c5fb = this._0x34a38d93._0xd76ed80d(this._0x892985ef, this._0xb8088254);
        this._0x4f84a850.Clear();
        this._0x114c9a7c = 0;
        this._0xf5e3fe29 = 0f;
        this._0xb86930f1 = 0f;
        if (this._board != null)
            this._board.Show(this._0x5181c5fb, this._0x5475af86);
        this._0x3ef89194 = _0xcff55387.Aim;
        this._0x1c058020 = 0f;
        this._0x874b50da(true);
        if (this._hud != null)
            this._hud._0x4887fe49();
        if (this._0xb8088254 == 1 && this._overlay != null)
            this._overlay._0x5206dbcd();
        this._0x4e7b3a72();
    }

    [SerializeField]
    private _0x8d15ea07 _overlay;
    public void _0x295c2cbe(float _0xd1f46d8b)
    {
        if (Mathf.Approximately(this._0xb86930f1, _0xd1f46d8b))
            this._0xb86930f1 = 0f;
    }

    private int _0xb8088254;
    private float _0xb86930f1;
    private RectTransform _0x92ae9dbb;
    private int _0x114c9a7c;
}

internal static class _0x2a80a88d
{
    internal static string _0x22928aad(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}