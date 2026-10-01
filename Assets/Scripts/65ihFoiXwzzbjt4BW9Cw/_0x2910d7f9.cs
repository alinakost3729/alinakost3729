using UnityEngine;

/// <summary>
/// The single source of colour for this game. Both scenes, every plate, label and
/// sprite tint read from here, so the menu and the board cannot drift apart.
/// Every TEXT colour listed here is light on purpose: the shared TMP material
/// outlines each glyph with <see cref = "Outline"/>, and a dark face would merge into
/// its own outline and read as a smudge.
/// </summary>
public static class _0x2910d7f9
{
    public static readonly Color Surface = new Color(0.0863f, 0.1255f, 0.2902f, 1f);
    public static readonly Color Magenta = new Color(0.9373f, 0.3098f, 0.5686f, 1f);
    public static readonly Color SurfaceDim = new Color(0.0471f, 0.0667f, 0.1569f, 1f);
    public static readonly Color Disabled = new Color(0.2275f, 0.2667f, 0.4078f, 1f);
    public static readonly Color TextSecondary = new Color(0.5333f, 0.5725f, 0.7216f, 1f);
    /// <summary>The six ring tints, in the order the rings are collected.</summary>
    public static Color Ring(int _0x247c0336)
    {
        int _0x48ce2235 = _0x247c0336 % 6;
        if (_0x48ce2235 < 0)
            _0x48ce2235 += 6;
        if (_0x48ce2235 == 0 || _0x48ce2235 == 4)
            return Cyan;
        if (_0x48ce2235 == 1 || _0x48ce2235 == 5)
            return Magenta;
        if (_0x48ce2235 == 2)
            return Gold;
        return Green;
    }

    /// <summary>Same hue, different opacity - used for glows, tracks and dimmed chips.</summary>
    public static Color WithAlpha(Color _0x2c1e6275, float _0x88352b05)
    {
        _0x2c1e6275.a = _0x88352b05;
        return _0x2c1e6275;
    }

    public static readonly Color Card = new Color(0.0784f, 0.1098f, 0.2353f, 1f);
    public static readonly Color MagentaDeep = new Color(0.7686f, 0.2353f, 0.4471f, 1f);
    public static readonly Color Gold = new Color(0.9608f, 0.7686f, 0.2706f, 1f);
    public static readonly Color Green = new Color(0.4980f, 0.8196f, 0.2902f, 1f);
    public static readonly Color Outline = new Color(0.0275f, 0.0431f, 0.1098f, 1f);
    public static readonly Color BaseDeep = new Color(0.0392f, 0.0588f, 0.1333f, 1f);
    // Surfaces - never used as a text colour.
    public static readonly Color Base = new Color(0.0627f, 0.0863f, 0.1843f, 1f);
    // Text.
    public static readonly Color TextPrimary = new Color(0.9686f, 0.9686f, 1f, 1f);
    // Accents - safe as text as well as fills.
    public static readonly Color Cyan = new Color(0.1451f, 0.7882f, 0.9373f, 1f);
}