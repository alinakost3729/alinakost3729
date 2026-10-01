using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The whole motion model of one launch, written once and used twice: the layout
/// builder runs it headless to RECORD a trajectory before the arena exists, and the
/// run controller steps the very same object on screen. One integrator means the
/// arena the generator proved is the arena the player gets.
/// No Rigidbody2D and no collider: the template freezes and unfreezes physics for its
/// own pause, and a hand-integrated ball is both deterministic and immune to that.
/// </summary>
public sealed class _0x7d39f0c5
{
    /// <summary>Index of the ring taken on the LAST step, or -1. Read once per step.</summary>
    public int JustTaken = -1;
    private float _0xffa82af1;
    private bool[] _0xd1a8b55f;
    private int _0x215a55e3 = -1;
    public int _0x33dcecb3
    {
        get
        {
            return this._0x215a55e3;
        }
    }

    /// <summary>After the maximum the ball is steered into the cup so the round moves on.</summary>
    private Vector2 _0xa2670f21()
    {
        if (this.RunSeconds <= _0xd9cb9715.MaxRunSeconds)
            return Vector2.zero;
        float _0x08774c9f = this._0xa1c46579.Cup.x - this.Position.x;
        return new Vector2(Mathf.Clamp(_0x08774c9f * 4f, -6f, 6f), -2f);
    }

    public Vector2 Position;
    // -- forces --------------------------------------------------------------
    private Vector2 _0xe2c9d5b3(float dt)
    {
        if (this.RunSeconds > _0xd9cb9715.MaxRunSeconds)
            return Vector2.zero;
        Vector2 _0x20598dc0 = Vector2.zero;
        float _0x4d1c1624 = this._0x3a34b6f4._0xd45cbe9e;
        for (int _0x550c34f7 = 0; _0x550c34f7 < this._0xdc34e6a8.Count; _0x550c34f7++)
        {
            if (this._0xe28ebecb[_0x550c34f7] >= _0xd9cb9715.MagnetHoldMax)
                continue;
            Vector2 delta = this._0xdc34e6a8[_0x550c34f7] - this.Position;
            float _0x64b21248 = delta.magnitude;
            if (_0x64b21248 > _0x4d1c1624 || _0x64b21248 < 0.0001f)
                continue;
            this._0xe28ebecb[_0x550c34f7] += dt;
            // Peak strength stays BELOW gravity on purpose: a stronger magnet parks the
            // ball at its equilibrium point and the launch never ends.
            float _0x05d9d8c9 = 1f - _0x64b21248 / _0x4d1c1624;
            _0x20598dc0 += delta / _0x64b21248 * (_0xd9cb9715.MagnetPeakAccel * _0x05d9d8c9);
        }

        return _0x20598dc0;
    }

    // -- outcome -------------------------------------------------------------
    private void _0xba727a68()
    {
        if (this.RunSeconds < _0xd9cb9715.MinRunSeconds)
            return;
        float _0xc732892d = this._0x3a34b6f4._0xd48a50b3;
        float _0x77eeae4f = this._0x3a34b6f4._0x997f5fda.x * 0.42f;
        bool _0xe1c69abc = Mathf.Abs(this.Position.x - this._0xa1c46579.Cup.x) <= _0x77eeae4f;
        if (this.Position.y <= _0xc732892d && this.Velocity.y < 0f && _0xe1c69abc)
        {
            bool _0x512ab1da = this.RunSeconds > _0xd9cb9715.MaxRunSeconds;
            if (_0x512ab1da || Mathf.Abs(this.Velocity.x) < _0xd9cb9715.CupEntryMaxSideSpeed)
            {
                this.State = _0xd3703dec.Scored;
                return;
            }

            // Too fast sideways: the lip throws it back out and the launch is still live.
            this.Position = new Vector2(this.Position.x, _0xc732892d + 0.01f);
            this.Velocity = new Vector2(this.Velocity.x, Mathf.Abs(this.Velocity.y) * 0.45f);
            return;
        }

        if (this.Position.y < this._0x3a34b6f4._0xb9658bb2)
            this.State = _0xd3703dec.Dropped;
    }

    // -- rings ---------------------------------------------------------------
    private void _0x01fcb431()
    {
        if (this._0xffa82af1 > 0f || this.RunSeconds > _0xd9cb9715.MaxRunSeconds)
            return;
        float _0xab20d8fd = _0xd9cb9715.RingCaptureRadius * _0xd9cb9715.RingCaptureRadius;
        for (int _0x9c8ea50b = 0; _0x9c8ea50b < this._0xa1c46579.Rings.Count; _0x9c8ea50b++)
        {
            if (this._0xd1a8b55f != null && _0x9c8ea50b < this._0xd1a8b55f.Length && this._0xd1a8b55f[_0x9c8ea50b])
                continue;
            Vector2 delta = this.Position - this._0xa1c46579.Rings[_0x9c8ea50b];
            if (delta.sqrMagnitude >= _0xab20d8fd)
                continue;
            this._0x215a55e3 = _0x9c8ea50b;
            this._0xcc5b6687 = Mathf.Atan2(delta.y, delta.x);
            float _0x08ecc487 = delta.x * this.Velocity.y - delta.y * this.Velocity.x;
            this._0x1eb6aac2 = _0x08ecc487 >= 0f ? 1f : -1f;
            this._0xa5137c36 = this._0xa1c46579._0x45cead17(_0x9c8ea50b);
            this._0xda0d5882 = 2f * Mathf.PI * this._0xa5137c36 / _0xd9cb9715.RingOrbitSeconds;
            return;
        }
    }

    /// <summary>
    /// Arms a fresh launch. <paramref name = "collected"/> is kept BY REFERENCE so rings
    /// taken on an earlier launch stay taken - without that a six-ring circuit could
    /// never be finished inside three launches.
    /// </summary>
    public void _0xf6576928(bool[] _0x5c626f23, IList<Vector2> _0x9c7d622f)
    {
        this._0xd1a8b55f = _0x5c626f23;
        this._0xdc34e6a8.Clear();
        this._0xe28ebecb.Clear();
        if (_0x9c7d622f != null)
        {
            for (int _0x9cadfb9d = 0; _0x9cadfb9d < _0x9c7d622f.Count; _0x9cadfb9d++)
            {
                this._0xdc34e6a8.Add(_0x9c7d622f[_0x9cadfb9d]);
                this._0xe28ebecb.Add(0f);
            }
        }

        this.Position = this._0x3a34b6f4._0x0866b106;
        this.Velocity = new Vector2(0f, -0.4f);
        this.RunSeconds = 0f;
        this.State = _0xd3703dec.Flying;
        this.JustTaken = -1;
        this._0x215a55e3 = -1;
        this._0xffa82af1 = 0f;
    }

    public _0xd3703dec State = _0xd3703dec.Flying;
    private void _0x55c5db28()
    {
        float _0x65c03618 = this._0x3a34b6f4._0x29e07d85;
        float _0x23996d5b = this._0x3a34b6f4._0x995559f4 + _0x65c03618;
        float _0xe863326a = this._0x3a34b6f4._0x0ab73082 - _0x65c03618;
        float _0x10561118 = this._0x3a34b6f4.TopY - _0x65c03618;
        if (this.Position.x < _0x23996d5b)
        {
            this.Position = new Vector2(_0x23996d5b, this.Position.y);
            this.Velocity = new Vector2(Mathf.Abs(this.Velocity.x) * _0xd9cb9715.RailRestitution, this.Velocity.y);
        }
        else if (this.Position.x > _0xe863326a)
        {
            this.Position = new Vector2(_0xe863326a, this.Position.y);
            this.Velocity = new Vector2(-Mathf.Abs(this.Velocity.x) * _0xd9cb9715.RailRestitution, this.Velocity.y);
        }

        if (this.Position.y > _0x10561118)
        {
            this.Position = new Vector2(this.Position.x, _0x10561118);
            this.Velocity = new Vector2(this.Velocity.x, -Mathf.Abs(this.Velocity.y) * _0xd9cb9715.RailRestitution);
        }

        float _0xea0dc317 = this._0x3a34b6f4._0xb9658bb2 + _0x65c03618;
        if (this.RunSeconds < _0xd9cb9715.MinRunSeconds && this.Position.y < _0xea0dc317)
        {
            this.Position = new Vector2(this.Position.x, _0xea0dc317);
            this.Velocity = new Vector2(this.Velocity.x, Mathf.Abs(this.Velocity.y) * _0xd9cb9715.RailRestitution + 1.2f);
        }
    }

    private float _0xda0d5882;
    private float _0xcc5b6687;
    public enum _0xd3703dec
    {
        Flying = 0,
        Scored = 1,
        Dropped = 2,
    }

    public float RunSeconds;
    public Vector2 Velocity;
    private readonly _0x8d177026 _0xa1c46579;
    // -- collisions ----------------------------------------------------------
    private void _0xbe128d2a()
    {
        float _0x8ede1fd9 = this._0x3a34b6f4._0x29e07d85 + this._0x3a34b6f4._0x793a1b33;
        float _0x26085516 = _0x8ede1fd9 * _0x8ede1fd9;
        for (int _0x0c912902 = 0; _0x0c912902 < this._0xa1c46579.Pegs.Count; _0x0c912902++)
        {
            Vector2 delta = this.Position - this._0xa1c46579.Pegs[_0x0c912902];
            float _0x959eaf9b = delta.sqrMagnitude;
            if (_0x959eaf9b >= _0x26085516 || _0x959eaf9b < 0.000001f)
                continue;
            Vector2 _0x48f86a3f = delta / Mathf.Sqrt(_0x959eaf9b);
            this.Position = this._0xa1c46579.Pegs[_0x0c912902] + _0x48f86a3f * _0x8ede1fd9;
            this.Velocity = Vector2.Reflect(this.Velocity, _0x48f86a3f) * _0xd9cb9715.PegRestitution;
        }
    }

    private readonly List<Vector2> _0xdc34e6a8 = new List<Vector2>();
    private float _0x1eb6aac2 = 1f;
    private readonly _0x5e57d0a4 _0x3a34b6f4;
    public IList<Vector2> _0x41941cb2
    {
        get
        {
            return this._0xdc34e6a8;
        }
    }

    private float _0xa5137c36;
    public _0x7d39f0c5(_0x5e57d0a4 _0x10ba62d0, _0x8d177026 _0x9aab6ae9)
    {
        this._0x3a34b6f4 = _0x10ba62d0;
        this._0xa1c46579 = _0x9aab6ae9;
    }

    private readonly List<float> _0xe28ebecb = new List<float>();
    private void _0x6d6f9a3f(float _0x5cfa4d75)
    {
        Vector2 _0xad9a8743 = this._0xa1c46579.Rings[this._0x215a55e3];
        float delta = this._0xda0d5882 * _0x5cfa4d75;
        this._0xcc5b6687 += this._0x1eb6aac2 * delta;
        this._0xa5137c36 -= delta / (2f * Mathf.PI);
        float _0xeb069bbb = _0xd9cb9715.RingOrbitRadius;
        this.Position = _0xad9a8743 + new Vector2(Mathf.Cos(this._0xcc5b6687), Mathf.Sin(this._0xcc5b6687)) * _0xeb069bbb;
        Vector2 _0x0094a8ac = new Vector2(-Mathf.Sin(this._0xcc5b6687), Mathf.Cos(this._0xcc5b6687)) * this._0x1eb6aac2;
        this.Velocity = _0x0094a8ac * (this._0xda0d5882 * _0xeb069bbb);
        if (this._0xa5137c36 > 0f)
            return;
        int _0xb1b84888 = this._0x215a55e3;
        this._0x215a55e3 = -1;
        this._0xffa82af1 = 0.35f;
        if (this._0xd1a8b55f != null && _0xb1b84888 < this._0xd1a8b55f.Length)
            this._0xd1a8b55f[_0xb1b84888] = true;
        this.JustTaken = _0xb1b84888;
        // Always leave a ring heading DOWN the board: a purely tangential release can
        // send the ball back up forever and the launch would never resolve.
        Vector2 _0x4ccbad42 = this.Velocity;
        if (_0x4ccbad42.y > -0.6f)
            _0x4ccbad42.y = -0.6f;
        this.Velocity = _0x4ccbad42;
    }

    public bool _0x8823ac6d
    {
        get
        {
            return this._0x215a55e3 >= 0;
        }
    }

    /// <summary>
    /// The board brake. Until the launch has lasted its minimum, the field under the
    /// cup pushes the ball back up into the pegs instead of letting it resolve, so a
    /// run can never be over before anyone has seen it.
    /// </summary>
    private Vector2 _0x85811137()
    {
        if (this.RunSeconds >= _0xd9cb9715.MinRunSeconds)
            return Vector2.zero;
        float _0xb840007b = this._0x3a34b6f4._0xd48a50b3 + this._0x3a34b6f4.Cell;
        if (this.Position.y > _0xb840007b)
            return Vector2.zero;
        float _0x5a0659ec = Mathf.Clamp01((_0xb840007b - this.Position.y) / Mathf.Max(0.0001f, this._0x3a34b6f4.Cell));
        return new Vector2(0f, _0xd9cb9715.Gravity * 1.8f * _0x5a0659ec);
    }

    /// <summary>One fixed integration step. <paramref name = "tilt"/> is -1..1.</summary>
    public void Step(float dt, float _0x20c4c9c6)
    {
        this.JustTaken = -1;
        if (this.State != _0xd3703dec.Flying)
            return;
        this.RunSeconds += dt;
        if (this._0xffa82af1 > 0f)
            this._0xffa82af1 -= dt;
        if (this._0x215a55e3 >= 0)
        {
            this._0x6d6f9a3f(dt);
            return;
        }

        Vector2 _0xd0839e23 = new Vector2(_0x20c4c9c6 * _0xd9cb9715.TiltAccel, -_0xd9cb9715.Gravity);
        _0xd0839e23 += this._0xe2c9d5b3(dt);
        _0xd0839e23 += this._0x85811137();
        _0xd0839e23 += this._0xa2670f21();
        this.Velocity += _0xd0839e23 * dt;
        this.Velocity *= Mathf.Clamp01(1f - _0xd9cb9715.LinearDamp * dt);
        if (this.Velocity.sqrMagnitude > _0xd9cb9715.MaxSpeed * _0xd9cb9715.MaxSpeed)
            this.Velocity = this.Velocity.normalized * _0xd9cb9715.MaxSpeed;
        this.Position += this.Velocity * dt;
        this._0xbe128d2a();
        this._0x55c5db28();
        this._0x01fcb431();
        this._0xba727a68();
    }
}