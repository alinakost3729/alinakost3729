using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// One generated arena: where the pegs stand, where the six rings hang, where the cup
/// sits and where the two magnets drop if the player never touches the board. Pure
/// data - it is produced by <see cref = "CircuitLayoutBuilder"/> and read by the view
/// and the run controller, and it never reaches back into the scene.
/// </summary>
public sealed class _0x8d177026
{
    public int Seed;
    public int _0x1c9ec8f0
    {
        get
        {
            return this.Rings.Count;
        }
    }

    public readonly List<Vector2> Pegs = new List<Vector2>();
    public readonly List<Vector2> DefaultMagnets = new List<Vector2>();
    public float _0x45cead17(int _0xaa96368c)
    {
        if (_0xaa96368c < 0 || _0xaa96368c >= this.RingTurns.Count)
            return _0xd9cb9715.RingTurnsMin;
        return this.RingTurns[_0xaa96368c];
    }

    /// <summary>How many rings the no-input probe collects - the review run sees at least this.</summary>
    public int ProbeRings;
    public readonly List<float> RingTurns = new List<float>();
    public int Bands;
    public Vector2 Cup;
    /// <summary>True when the seeded generator gave up and the safety arena was used.</summary>
    public bool IsFallback;
    public readonly List<Vector2> Rings = new List<Vector2>();
}