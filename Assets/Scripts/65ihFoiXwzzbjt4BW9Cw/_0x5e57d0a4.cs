using UnityEngine;

/// <summary>
/// Every world size in the game is measured FROM THE CAMERA, never guessed and never
/// taken from a sprite's native pixel size: the generated art is 640 px at 100 pixels
/// per unit, which is 6.4 units - wider than the whole screen. One instance is built
/// per scene from the live camera and handed to whoever needs a size.
/// </summary>
public sealed class _0x5e57d0a4
{
    public readonly int Columns;
    public readonly float Cell;
    public float _0x0ab73082
    {
        get
        {
            return this.BoardWidth * 0.5f;
        }
    }

    /// <summary>Where a launched ball starts: centred just under the top rail.</summary>
    public Vector2 _0x0866b106
    {
        get
        {
            return new Vector2(0f, this.TopY - this.Cell * 0.55f);
        }
    }

    public readonly float BottomY;
    public float _0xb85f008c
    {
        get
        {
            return (this.TopY + this.BottomY) * 0.5f;
        }
    }

    private const float BottomFraction = -0.71f;
    public Vector2 _0xbfa367aa
    {
        get
        {
            return new Vector2(this.Cell * 0.46f, this.Cell * 0.46f);
        }
    }

    public Vector2 _0x7a99877f
    {
        get
        {
            return new Vector2(this.Cell * 0.22f, this.Cell * 0.22f);
        }
    }

    private const float TopFraction = 0.46f;
    private const int ColumnCount = 7;
    public Vector2 _0xa2c6687b
    {
        get
        {
            return new Vector2(this.Cell * 1.30f, this.Cell * 1.30f);
        }
    }

    /// <summary>The floor line. Below it a launch has either scored or been lost.</summary>
    public float _0xb9658bb2
    {
        get
        {
            return this.BottomY + this.Cell * 0.30f;
        }
    }

    public Vector2 _0x02ef508d
    {
        get
        {
            return new Vector2(this.BoardWidth, this.BoardHeight);
        }
    }

    public float _0x29e07d85
    {
        get
        {
            return this.Cell * 0.30f;
        }
    }

    public _0x5e57d0a4(Camera _0x37eca118)
    {
        float _0xf2ff899b = 5f;
        float _0x616012e0 = 9f / 19.5f;
        if (_0x37eca118 != null && _0x37eca118.orthographic)
        {
            _0xf2ff899b = _0x37eca118.orthographicSize;
            if (_0x37eca118.aspect > 0.01f)
                _0x616012e0 = _0x37eca118.aspect;
        }

        this.HalfHeight = _0xf2ff899b;
        this.HalfWidth = _0xf2ff899b * _0x616012e0;
        this.BoardWidth = 2f * this.HalfWidth * BoardWidthFraction;
        this.TopY = _0xf2ff899b * TopFraction;
        this.BottomY = _0xf2ff899b * BottomFraction;
        this.BoardHeight = this.TopY - this.BottomY;
        this.Columns = ColumnCount;
        this.Cell = this.BoardWidth / ColumnCount;
    }

    public Vector2 _0x74a5e015
    {
        get
        {
            return new Vector2(this.Cell * 0.28f, this.Cell * 0.28f);
        }
    }

    public float _0xd48a50b3
    {
        get
        {
            return this.BottomY + this._0x997f5fda.y;
        }
    }

    private const float BoardWidthFraction = 0.88f;
    public readonly float HalfHeight;
    /// <summary>Height of one peg band for a circuit of the given density.</summary>
    public float _0x3c1717a7(int _0x02cc78bd)
    {
        return this.BoardHeight / Mathf.Max(1, _0x02cc78bd);
    }

    /// <summary>Keeps a point far enough inside the rails to be a legal magnet slot.</summary>
    public float ClampInsideX(float _0xe3a634eb, float _0x36379312)
    {
        return Mathf.Clamp(_0xe3a634eb, this._0x995559f4 + _0x36379312, this._0x0ab73082 - _0x36379312);
    }

    public Vector2 _0xfba546bd
    {
        get
        {
            return new Vector2(this.Cell * 0.95f, this.Cell * 0.95f);
        }
    }

    public Vector2 _0x997f5fda
    {
        get
        {
            return new Vector2(this.Cell * 2.20f, this.Cell * 1.24f);
        }
    }

    public readonly float BoardWidth;
    public readonly float BoardHeight;
    public float _0x995559f4
    {
        get
        {
            return -this.BoardWidth * 0.5f;
        }
    }

    public float _0xd45cbe9e
    {
        get
        {
            return this.Cell * _0xd9cb9715.MagnetRadiusCells;
        }
    }

    public float _0x793a1b33
    {
        get
        {
            return this.Cell * 0.23f;
        }
    }

    public readonly float TopY;
    public readonly float HalfWidth;
    public Vector2 _0x312216c3
    {
        get
        {
            return new Vector2(this.Cell * 0.60f, this.Cell * 0.60f);
        }
    }
}