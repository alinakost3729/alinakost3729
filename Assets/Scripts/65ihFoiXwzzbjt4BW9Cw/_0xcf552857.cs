using UnityEngine;

/// <summary>
/// The little that survives between runs: which circuit the player picked, how far
/// they have unlocked and the best ring count. Coins stay where the template keeps
/// them (SETTINGS.PlayerSYSTEM) so the template's own counters keep working.
/// Keys are fixed strings on purpose - PlayerPrefs keys are data, and deriving one
/// from a C# symbol would wipe every player's save the first time the code is
/// obfuscated under a different name.
/// </summary>
public static class _0xcf552857
{
    public static void RecordRings(int _0x617bcded)
    {
        if (_0x617bcded > _0x05ba273a)
            _0x05ba273a = _0x617bcded;
    }

    public static bool IsOpen(int _0xcf9fc396)
    {
        return _0xcf9fc396 < _0xed3e367f;
    }

    public static void AddCoins(int _0xde8a64c7)
    {
        if (_0xde8a64c7 == 0)
            return;
        _0x4a69945a._0x5dc950a9._0x02606895 = _0x4a69945a._0x5dc950a9._0x02606895 + _0xde8a64c7;
    }

    private static readonly string PickedKey = _0xa3d981d1._0xa7ec5728(new byte[20] { 240, 230, 253, 242, 224, 203, 247, 253, 230, 247, 225, 253, 224, 203, 228, 253, 247, 255, 241, 240 }, 148);
    /// <summary>How many circuits are open. Circuit one is always open, so a chip row is never empty.</summary>
    public static int _0xed3e367f
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(UnlockedKey, 1), 1, _0xd9cb9715.CircuitCount);
        }

        set
        {
            PlayerPrefs.SetInt(UnlockedKey, Mathf.Clamp(value, 1, _0xd9cb9715.CircuitCount));
        }
    }

    private static readonly string BestRingsKey = _0xa3d981d1._0xa7ec5728(new byte[16] { 63, 41, 50, 61, 47, 4, 57, 62, 40, 47, 4, 41, 50, 53, 60, 40 }, 91);
    public static int _0x05ba273a
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(BestRingsKey, 0));
        }

        set
        {
            PlayerPrefs.SetInt(BestRingsKey, Mathf.Max(0, value));
        }
    }

    public static int _0xc42aaad0
    {
        get
        {
            return _0xd9cb9715.ClampCircuit(PlayerPrefs.GetInt(PickedKey, 0));
        }

        set
        {
            PlayerPrefs.SetInt(PickedKey, _0xd9cb9715.ClampCircuit(value));
        }
    }

    private static readonly string UnlockedKey = _0xa3d981d1._0xa7ec5728(new byte[22] { 49, 39, 60, 51, 33, 10, 54, 60, 39, 54, 32, 60, 33, 10, 32, 59, 57, 58, 54, 62, 48, 49 }, 85);
    public static void UnlockAfter(int _0xab5e4328)
    {
        if (_0xab5e4328 + 2 > _0xed3e367f)
            _0xed3e367f = _0xab5e4328 + 2;
    }
}

internal static class _0xa3d981d1
{
    internal static string _0xa7ec5728(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}