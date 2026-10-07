using UnityEngine;

/// <summary>
/// Every tuning number of the board in one place, in WORLD units and seconds.
/// Sizes that depend on the screen are NOT here - they live in
/// <see cref = "BoardGeometry"/> and are derived from the camera.
/// </summary>
public static class _0xd9cb9715
{
    public const float LinearDamp = 2.2f;
    // -- cup -----------------------------------------------------------------
    public const float CupEntryMaxSideSpeed = 1.6f;
    public const float RailRestitution = 0.62f;
    public const float RingOrbitRadius = 0.30f;
    public const float RingTurnsMax = 2.5f;
    public const int LaunchesStart = 3;
    public static int Bands(int _0x3c5042e2)
    {
        return _0x3c5042e2 >= 2 ? 6 : 5;
    }

    // -- motion --------------------------------------------------------------
    public const float Gravity = 9.0f;
    public const float RingTurnsMin = 1.5f;
    public const int CoinsPerRing = 20;
    public const float RingOrbitSeconds = 1.6f;
    public static int Pegs(int _0xffb5f98a)
    {
        if (_0xffb5f98a <= 0)
            return 22;
        if (_0xffb5f98a == 1)
            return 26;
        if (_0xffb5f98a == 2)
            return 30;
        return 34;
    }

    public const int RingsPerBonusLaunch = 3;
    /// <summary>The one label the roman chip numerals come from - ASCII, no glyph risk.</summary>
    public static string Numeral(int _0x1457a51b)
    {
        if (_0x1457a51b <= 0)
            return _0x3a7e27f8._0x52e87dc1(new byte[1] { 143 }, 198);
        if (_0x1457a51b == 1)
            return _0x3a7e27f8._0x52e87dc1(new byte[2] { 67, 67 }, 10);
        if (_0x1457a51b == 2)
            return _0x3a7e27f8._0x52e87dc1(new byte[3] { 143, 143, 143 }, 198);
        return _0x3a7e27f8._0x52e87dc1(new byte[2] { 11, 20 }, 66);
    }

    /// <summary>Second safety net next to the accel cap: a magnet lets go after this.</summary>
    public const float MagnetHoldMax = 3.0f;
    public const float StepSeconds = 1f / 60f;
    public const int CoinsPerCup = 60;
    /// <summary>Minimum gap between two pegs, as a multiple of one cell. Tighter later.</summary>
    public static float PegGapCells(int _0x2426336d)
    {
        if (_0x2426336d <= 0)
            return 1.05f;
        if (_0x2426336d == 1)
            return 0.92f;
        return 0.80f;
    }

    // -- magnets -------------------------------------------------------------
    /// <summary>Radius of influence, expressed as a multiple of one board cell.</summary>
    public const float MagnetRadiusCells = 1.9f;
    // -- rings ---------------------------------------------------------------
    public const int RingsPerCircuit = 6;
    public const int LaunchesCap = 5;
    public const float MaxSpeed = 4.2f;
    public static int ClampCircuit(int _0xd82d5f73)
    {
        return Mathf.Clamp(_0xd82d5f73, 0, CircuitCount - 1);
    }

    // -- round length (rule C.5: a no-input run must outlive the capture window) --
    /// <summary>Below this the floor is still solid, so no launch can end early.</summary>
    public const float MinRunSeconds = 13f;
    public const float RingCaptureRadius = 0.42f;
    public const float TiltRamp = 0.18f;
    // -- circuits ------------------------------------------------------------
    public const int CircuitCount = 4;
    public const float AimSeconds = 6f;
    /// <summary>
    /// STRICTLY below <see cref = "Gravity"/>. A magnet stronger than gravity parks the
    /// ball at its equilibrium point and the run dies standing up.
    /// </summary>
    public const float MagnetPeakAccel = 6.0f;
    /// <summary>Above this the ball is released and homed at the cup so it resolves.</summary>
    public const float MaxRunSeconds = 18f;
    public const int MagnetsPerLaunch = 2;
    public const float PegRestitution = 0.55f;
    public const float BannerSeconds = 2f;
    public const float TiltAccel = 4.5f;
}

internal static class _0x3a7e27f8
{
    internal static string _0x52e87dc1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}