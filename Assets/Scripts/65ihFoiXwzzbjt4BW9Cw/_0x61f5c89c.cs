using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds one arena per round from a seed. The order is deliberately the reverse of
/// "scatter rings, then check with a solver": on a peg board almost every scattered
/// arena fails its own check and the whole thing falls back to a hardcoded level.
/// Here the ball is simulated FIRST and each ring is hung ON the recorded path, so a
/// route that collects all six exists BY CONSTRUCTION - and the next ring is placed
/// on a path that already includes the orbit of the previous one.
/// </summary>
public sealed class _0x61f5c89c
{
    public _0x8d177026 _0xd76ed80d(int _0xce69786c, int _0xffb0b636)
    {
        // System.Random, never UnityEngine.Random: the global generator is shared with
        // every other system, so "the same seed" would stop meaning the same arena.
        int _0x6a50bcb0 = (_0xd9cb9715.ClampCircuit(_0xce69786c) * 7919) ^ (_0xffb0b636 * 104729);
        System.Random _0x9c259478 = new System.Random(_0x6a50bcb0);
        for (int _0xaa38c9f3 = 0; _0xaa38c9f3 < PegAttempts; _0xaa38c9f3++)
        {
            _0x8d177026 _0x7a913451 = this._0xc0940bc5(_0xce69786c, _0x9c259478);
            if (_0x7a913451 != null)
            {
                _0x7a913451.Seed = _0x6a50bcb0;
                {
#if B_LOGS
                    {
                        Debug.Log(_0x2e425c85._0x1753e26f(new byte[15] { 152, 160, 170, 177, 160, 182, 170, 183, 158, 227, 176, 166, 166, 167, 254 }, 195) + _0x6a50bcb0.ToString() + _0x2e425c85._0x1753e26f(new byte[6] { 119, 39, 50, 48, 36, 106 }, 87) + _0x7a913451.Pegs.Count.ToString() + _0x2e425c85._0x1753e26f(new byte[7] { 241, 163, 184, 191, 182, 162, 236 }, 209) + _0x7a913451._0x1c9ec8f0.ToString() + _0x2e425c85._0x1753e26f(new byte[7] { 195, 147, 145, 140, 129, 134, 222 }, 227) + _0x7a913451.ProbeRings.ToString());
                    }
#endif
                }

                return _0x7a913451;
            }
        }

        _0x8d177026 _0xea0dcac9 = this._0x617dc57b(_0xce69786c);
        _0xea0dcac9.Seed = _0x6a50bcb0;
        {
#if B_LOGS
            {
                Debug.Log(_0x2e425c85._0x1753e26f(new byte[15] { 210, 234, 224, 251, 234, 252, 224, 253, 212, 169, 250, 236, 236, 237, 180 }, 137) + _0x6a50bcb0.ToString() + _0x2e425c85._0x1753e26f(new byte[30] { 12, 74, 73, 64, 64, 12, 78, 77, 79, 71, 12, 88, 67, 12, 88, 68, 73, 12, 95, 77, 74, 73, 88, 85, 12, 77, 94, 73, 66, 77 }, 44));
            }
#endif
        }

        return _0xea0dcac9;
    }

    private readonly _0x5e57d0a4 _0x483e07e0;
    private const int PegAttempts = 20;
    private void _0xae9b7a5f(_0x8d177026 _0xba9f5d4e, int _0xe2f0a5b9, System.Random _0x28d4347b)
    {
        int _0x2e2edced = _0xba9f5d4e.Bands;
        int _0x11c392cb = _0xd9cb9715.Pegs(_0xe2f0a5b9);
        float _0x0345e37f = this._0x483e07e0._0x3c1717a7(_0x2e2edced);
        float _0xca295b60 = this._0x483e07e0.Cell * _0xd9cb9715.PegGapCells(_0xe2f0a5b9);
        float _0xc762509b = this._0x483e07e0.Cell * 0.55f;
        float _0xda93329a = this._0x483e07e0._0x995559f4 + _0xc762509b;
        float _0x5ce9ab88 = this._0x483e07e0._0x0ab73082 - _0xc762509b;
        for (int _0xfebe4e3f = 0; _0xfebe4e3f < _0x2e2edced; _0xfebe4e3f++)
        {
            int _0x560b54fa = _0x2e2edced - _0xfebe4e3f;
            int want = Mathf.Clamp(_0x11c392cb / Mathf.Max(1, _0x560b54fa), 4, 6);
            _0x11c392cb -= want;
            float _0xb1d287fb = this._0x483e07e0.TopY - (_0xfebe4e3f + 0.85f) * _0x0345e37f;
            // Odd bands are nudged by half a cell so no two rows read as a grid.
            float _0x88c2f60a = (_0xfebe4e3f % 2 == 0) ? 0f : this._0x483e07e0.Cell * 0.5f;
            List<float> _0x1486b7fb = new List<float>();
            for (int _0x6cd145da = 0; _0x6cd145da < 40 && _0x1486b7fb.Count < want; _0x6cd145da++)
            {
                float _0x11cc9a17 = Mathf.Lerp(_0xda93329a, _0x5ce9ab88, (float)_0x28d4347b.NextDouble()) + _0x88c2f60a;
                _0x11cc9a17 = Mathf.Clamp(_0x11cc9a17, _0xda93329a, _0x5ce9ab88);
                bool _0x0fc71758 = true;
                for (int _0xc059092e = 0; _0xc059092e < _0x1486b7fb.Count; _0xc059092e++)
                {
                    if (Mathf.Abs(_0x1486b7fb[_0xc059092e] - _0x11cc9a17) < _0xca295b60)
                    {
                        _0x0fc71758 = false;
                        break;
                    }
                }

                if (_0x0fc71758)
                    _0x1486b7fb.Add(_0x11cc9a17);
            }

            for (int _0xce65281e = 0; _0xce65281e < _0x1486b7fb.Count; _0xce65281e++)
                _0xba9f5d4e.Pegs.Add(new Vector2(_0x1486b7fb[_0xce65281e], _0xb1d287fb + ((float)_0x28d4347b.NextDouble() - 0.5f) * _0x0345e37f * 0.18f));
        }
    }

    /// <summary>Picks a point of the recorded path inside a height window that clears rings and pegs.</summary>
    private bool _0x3ba74da1(_0x8d177026 _0xea054239, List<Vector2> _0x10feaf42, float _0x88a6e5f2, float _0x89e077e8, System.Random _0xfe603723, out Vector2 _0x47eb3ded)
    {
        List<Vector2> _0x1195ede1 = new List<Vector2>();
        float _0x4775deb4 = this._0x483e07e0.Cell * 1.55f;
        float _0xc0762e9b = this._0x483e07e0._0x793a1b33 + _0xd9cb9715.RingOrbitRadius + this._0x483e07e0._0x29e07d85;
        for (int _0xf0c02e93 = 4; _0xf0c02e93 < _0x10feaf42.Count; _0xf0c02e93++)
        {
            Vector2 _0x698f824b = _0x10feaf42[_0xf0c02e93];
            if (_0x698f824b.y < _0x88a6e5f2 || _0x698f824b.y > _0x89e077e8)
                continue;
            if (_0x698f824b.x < this._0x483e07e0._0x995559f4 + _0x4775deb4 * 0.5f || _0x698f824b.x > this._0x483e07e0._0x0ab73082 - _0x4775deb4 * 0.5f)
                continue;
            bool _0xaf5597d0 = true;
            for (int _0x538c105d = 0; _0x538c105d < _0xea054239.Rings.Count; _0x538c105d++)
            {
                if ((_0xea054239.Rings[_0x538c105d] - _0x698f824b).sqrMagnitude < _0x4775deb4 * _0x4775deb4)
                {
                    _0xaf5597d0 = false;
                    break;
                }
            }

            if (_0xaf5597d0)
            {
                for (int _0x27f7c690 = 0; _0x27f7c690 < _0xea054239.Pegs.Count; _0x27f7c690++)
                {
                    if ((_0xea054239.Pegs[_0x27f7c690] - _0x698f824b).sqrMagnitude < _0xc0762e9b * _0xc0762e9b)
                    {
                        _0xaf5597d0 = false;
                        break;
                    }
                }
            }

            if (_0xaf5597d0)
                _0x1195ede1.Add(_0x698f824b);
        }

        if (_0x1195ede1.Count == 0)
        {
            _0x47eb3ded = Vector2.zero;
            return false;
        }

        _0x47eb3ded = _0x1195ede1[_0xfe603723.Next(_0x1195ede1.Count)];
        return true;
    }

    private const float ProbeCeilingSeconds = 26f;
    /// <summary>
    /// The two magnets that drop by themselves when nobody touches the board. They sit
    /// ON the proven path, and the choice is then re-simulated: a pair that would cost
    /// the hands-off run its rings is thinned to one, then to none. The review capture
    /// is a hands-off run, so this is what decides whether it shows rings being taken.
    /// </summary>
    private void _0x8e8dd654(_0x8d177026 _0x656e1ec1, List<Vector2> _0xb558f6cf, System.Random _0xd46ac79e)
    {
        List<Vector2> _0xff759ac8 = new List<Vector2>();
        int _0x8d05416d = Mathf.Clamp(_0xb558f6cf.Count / 3 + _0xd46ac79e.Next(-12, 12), 6, _0xb558f6cf.Count - 2);
        int _0x5750aabb = Mathf.Clamp(_0xb558f6cf.Count * 2 / 3 + _0xd46ac79e.Next(-12, 12), _0x8d05416d + 6, _0xb558f6cf.Count - 2);
        float _0xb3a49418 = this._0x483e07e0.Cell * 0.8f;
        _0xff759ac8.Add(new Vector2(this._0x483e07e0.ClampInsideX(_0xb558f6cf[_0x8d05416d].x, _0xb3a49418), _0xb558f6cf[_0x8d05416d].y));
        _0xff759ac8.Add(new Vector2(this._0x483e07e0.ClampInsideX(_0xb558f6cf[_0x5750aabb].x, _0xb3a49418), _0xb558f6cf[_0x5750aabb].y));
        for (int _0x627c002b = _0xff759ac8.Count; _0x627c002b >= 0; _0x627c002b--)
        {
            List<Vector2> _0x37aa0146 = new List<Vector2>();
            for (int _0x81fdc2cf = 0; _0x81fdc2cf < _0x627c002b; _0x81fdc2cf++)
                _0x37aa0146.Add(_0xff759ac8[_0x81fdc2cf]);
            int _0xe54f928e;
            float _0x618c438d;
            bool _0xd37eaa53;
            this._0x8e52fc6d(_0x656e1ec1, _0x37aa0146, out _0xe54f928e, out _0x618c438d, out _0xd37eaa53);
            if (_0xe54f928e >= 4 || _0x627c002b == 0)
            {
                _0x656e1ec1.DefaultMagnets.Clear();
                _0x656e1ec1.DefaultMagnets.AddRange(_0x37aa0146);
                _0x656e1ec1.ProbeRings = _0xe54f928e;
                return;
            }
        }
    }

    // -- headless simulation -------------------------------------------------
    private List<Vector2> _0x8e52fc6d(_0x8d177026 _0xf2956eca, IList<Vector2> _0x87d922cd, out int _0x3a9248dc, out float _0xaa156073, out bool _0x446c4c2b)
    {
        _0x7d39f0c5 _0x16fe65af = new _0x7d39f0c5(this._0x483e07e0, _0xf2956eca);
        bool[] _0xb18fce31 = new bool[_0xd9cb9715.RingsPerCircuit];
        _0x16fe65af._0xf6576928(_0xb18fce31, _0x87d922cd);
        List<Vector2> _0xe65550d1 = new List<Vector2>();
        _0x3a9248dc = 0;
        _0xaa156073 = 0f;
        _0x446c4c2b = false;
        bool _0x94f86940 = false;
        float _0x17b73bfd = this._0x483e07e0._0xd48a50b3;
        float _0xab4f2210 = _0x16fe65af.Position.y;
        int _0xaf87170a = Mathf.CeilToInt(ProbeCeilingSeconds / _0xd9cb9715.StepSeconds);
        for (int _0x28ec0c3b = 0; _0x28ec0c3b < _0xaf87170a; _0x28ec0c3b++)
        {
            _0x16fe65af.Step(_0xd9cb9715.StepSeconds, 0f);
            _0xe65550d1.Add(_0x16fe65af.Position);
            if (_0x16fe65af.JustTaken >= 0)
                _0x3a9248dc++;
            if (!_0x94f86940 && _0xab4f2210 > _0x17b73bfd && _0x16fe65af.Position.y <= _0x17b73bfd)
            {
                _0x94f86940 = true;
                _0xaa156073 = _0x16fe65af.Position.x;
            }

            _0xab4f2210 = _0x16fe65af.Position.y;
            if (_0x16fe65af.State != _0x7d39f0c5._0xd3703dec.Flying)
            {
                _0x446c4c2b = _0x16fe65af.State == _0x7d39f0c5._0xd3703dec.Scored;
                break;
            }
        }

        if (!_0x94f86940)
            _0xaa156073 = _0xe65550d1.Count > 0 ? _0xe65550d1[_0xe65550d1.Count - 1].x : 0f;
        return _0xe65550d1;
    }

    // -- one generation attempt ----------------------------------------------
    private _0x8d177026 _0xc0940bc5(int _0x1c0ae447, System.Random _0x4c3ac37f)
    {
        _0x8d177026 _0x0a29e259 = new _0x8d177026();
        _0x0a29e259.Bands = _0xd9cb9715.Bands(_0x1c0ae447);
        this._0xae9b7a5f(_0x0a29e259, _0x1c0ae447, _0x4c3ac37f);
        _0x0a29e259.Cup = new Vector2(0f, this._0x483e07e0.BottomY + this._0x483e07e0._0x997f5fda.y * 0.5f);
        float _0x836594e5 = this._0x483e07e0._0x3c1717a7(_0x0a29e259.Bands);
        for (int _0x7d90e4d2 = 0; _0x7d90e4d2 < _0xd9cb9715.RingsPerCircuit; _0x7d90e4d2++)
        {
            int _0xf34a1b62;
            float _0x23df3e18;
            bool _0x00c38879;
            List<Vector2> _0x87e840b6 = this._0x8e52fc6d(_0x0a29e259, null, out _0xf34a1b62, out _0x23df3e18, out _0x00c38879);
            if (_0x87e840b6.Count < 60)
                return null;
            int _0x69338526 = Mathf.Min(_0x0a29e259.Bands - 1, _0x7d90e4d2 * _0x0a29e259.Bands / _0xd9cb9715.RingsPerCircuit);
            float _0x6de007c4 = this._0x483e07e0.TopY - _0x69338526 * _0x836594e5;
            float _0x6a971441 = _0x6de007c4 - _0x836594e5;
            Vector2 _0x64b3887b;
            if (!this._0x3ba74da1(_0x0a29e259, _0x87e840b6, _0x6a971441, _0x6de007c4, _0x4c3ac37f, out _0x64b3887b))
            {
                if (!this._0x3ba74da1(_0x0a29e259, _0x87e840b6, this._0x483e07e0._0xd48a50b3, this._0x483e07e0.TopY, _0x4c3ac37f, out _0x64b3887b))
                    return null;
            }

            _0x0a29e259.Rings.Add(_0x64b3887b);
            _0x0a29e259.RingTurns.Add(Mathf.Lerp(_0xd9cb9715.RingTurnsMin, _0xd9cb9715.RingTurnsMax, (float)_0x4c3ac37f.NextDouble()));
        }

        // The cup goes under where the ball actually arrives once all six rings are on
        // the path - not under a guessed centre line.
        int _0x22343795;
        float _0x7064513b;
        bool _0x43c31ddb;
        List<Vector2> _0xdc7d3878 = this._0x8e52fc6d(_0x0a29e259, null, out _0x22343795, out _0x7064513b, out _0x43c31ddb);
        if (_0xdc7d3878.Count < 60 || _0x22343795 < _0xd9cb9715.RingsPerCircuit)
            return null;
        float _0x0b78e2a8 = this._0x483e07e0._0x997f5fda.x * 0.5f + this._0x483e07e0.Cell * 0.2f;
        _0x0a29e259.Cup = new Vector2(this._0x483e07e0.ClampInsideX(_0x7064513b, _0x0b78e2a8), this._0x483e07e0.BottomY + this._0x483e07e0._0x997f5fda.y * 0.5f);
        this._0x8e8dd654(_0x0a29e259, _0xdc7d3878, _0x4c3ac37f);
        return _0x0a29e259;
    }

    // -- safety arena --------------------------------------------------------
    /// <summary>
    /// Only ever reached when twenty seeded attempts in a row failed. It is a backstop,
    /// not the game: every real round comes out of the generator above.
    /// </summary>
    private _0x8d177026 _0x617dc57b(int _0x10546891)
    {
        _0x8d177026 _0xe870b784 = new _0x8d177026();
        _0xe870b784.Bands = _0xd9cb9715.Bands(_0x10546891);
        _0xe870b784.IsFallback = true;
        float _0x1af57e77 = this._0x483e07e0.Cell;
        float _0x122a4cef = this._0x483e07e0._0x3c1717a7(_0xe870b784.Bands);
        for (int _0x170bb5d3 = 0; _0x170bb5d3 < _0xe870b784.Bands; _0x170bb5d3++)
        {
            float _0x9692dea9 = this._0x483e07e0.TopY - (_0x170bb5d3 + 0.85f) * _0x122a4cef;
            int _0x3e7b0cee = 5;
            float _0x37ce087a = (this._0x483e07e0.BoardWidth - _0x1af57e77 * 1.4f) / (_0x3e7b0cee - 1);
            float _0x429e0725 = this._0x483e07e0._0x995559f4 + _0x1af57e77 * 0.7f + (_0x170bb5d3 % 2 == 0 ? 0f : _0x1af57e77 * 0.3f);
            for (int _0x556bdf2d = 0; _0x556bdf2d < _0x3e7b0cee; _0x556bdf2d++)
                _0xe870b784.Pegs.Add(new Vector2(Mathf.Clamp(_0x429e0725 + _0x37ce087a * _0x556bdf2d, this._0x483e07e0._0x995559f4 + _0x1af57e77 * 0.5f, this._0x483e07e0._0x0ab73082 - _0x1af57e77 * 0.5f), _0x9692dea9));
        }

        for (int _0x1310fc8d = 0; _0x1310fc8d < _0xd9cb9715.RingsPerCircuit; _0x1310fc8d++)
        {
            float _0x3c2d3aea = (_0x1310fc8d + 0.5f) / _0xd9cb9715.RingsPerCircuit;
            float _0x9876d635 = Mathf.Lerp(this._0x483e07e0.TopY - _0x1af57e77, this._0x483e07e0._0xd48a50b3 + _0x1af57e77, _0x3c2d3aea);
            float _0x5b050c9e = (_0x1310fc8d % 2 == 0 ? -1f : 1f) * _0x1af57e77 * 1.1f;
            _0xe870b784.Rings.Add(new Vector2(_0x5b050c9e, _0x9876d635));
            _0xe870b784.RingTurns.Add(_0xd9cb9715.RingTurnsMin);
        }

        _0xe870b784.Cup = new Vector2(0f, this._0x483e07e0.BottomY + this._0x483e07e0._0x997f5fda.y * 0.5f);
        _0xe870b784.DefaultMagnets.Add(new Vector2(-_0x1af57e77 * 0.9f, this._0x483e07e0.TopY - _0x122a4cef * 1.4f));
        _0xe870b784.DefaultMagnets.Add(new Vector2(_0x1af57e77 * 0.9f, this._0x483e07e0.TopY - _0x122a4cef * 3.1f));
        _0xe870b784.ProbeRings = 0;
        return _0xe870b784;
    }

    public _0x61f5c89c(_0x5e57d0a4 _0x23ef64a7)
    {
        this._0x483e07e0 = _0x23ef64a7;
    }
}

internal static class _0x2e425c85
{
    internal static string _0x1753e26f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}