using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x4a69945a
{
    public static class _0x7e52c9eb
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0xb2ffbd97
    {
        private static readonly _0xb2ffbd97 _0xfa6679e2 = new();
        public static readonly _0xb2ffbd97[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xfa6679e2,
            _0xfa6679e2,
            _0xfa6679e2,
        };
        private int _0xf4607d8d => 0;
        private int _0xb2e66f8a => 10;
        private string _0x403de36d => _0x7ecec9b0._0xd9b42906(new byte[4] { 112, 88, 83, 72 }, 61);
        private string _0xe74abce8 => _0x7ecec9b0._0xd9b42906(new byte[8] { 211, 218, 201, 218, 211, 228, 175, 226 }, 159);

        private int _0xe2370cf0
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x7ecec9b0._0xd9b42906(new byte[25] { 54, 0, 7, 7, 16, 27, 1, 50, 25, 26, 23, 20, 25, 54, 29, 20, 5, 1, 16, 7, 60, 27, 17, 16, 13 }, 117)))
                    PlayerPrefs.SetInt(_0x7ecec9b0._0xd9b42906(new byte[25] { 52, 2, 5, 5, 18, 25, 3, 48, 27, 24, 21, 22, 27, 52, 31, 22, 7, 3, 18, 5, 62, 25, 19, 18, 15 }, 119), 0);
                return PlayerPrefs.GetInt(_0x7ecec9b0._0xd9b42906(new byte[25] { 69, 115, 116, 116, 99, 104, 114, 65, 106, 105, 100, 103, 106, 69, 110, 103, 118, 114, 99, 116, 79, 104, 98, 99, 126 }, 6));
            }

            set => PlayerPrefs.SetInt(_0x7ecec9b0._0xd9b42906(new byte[25] { 163, 149, 146, 146, 133, 142, 148, 167, 140, 143, 130, 129, 140, 163, 136, 129, 144, 148, 133, 146, 169, 142, 132, 133, 152 }, 224), value);
        }

        public int _0x0dca841a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x403de36d}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x403de36d}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x403de36d}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x403de36d}CurrentLevelIndex", value);
        }

        public int _0x3560f525
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x403de36d}BestScore"))
                    this._0x3560f525 = 0;
                return PlayerPrefs.GetInt($"{this._0x403de36d}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x403de36d}BestScore", value);
        }

        public bool _0x72e938e8
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x403de36d}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x403de36d}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x403de36d}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x403de36d}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x43fa6809
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x5dc950a9
    {
        public static int _0x02606895
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x7ecec9b0._0xd9b42906(new byte[5] { 45, 1, 7, 0, 29 }, 110)))
                    PlayerPrefs.SetInt(_0x7ecec9b0._0xd9b42906(new byte[5] { 241, 221, 219, 220, 193 }, 178), 0);
                return PlayerPrefs.GetInt(_0x7ecec9b0._0xd9b42906(new byte[5] { 164, 136, 142, 137, 148 }, 231));
            }

            set
            {
                PlayerPrefs.SetInt(_0x7ecec9b0._0xd9b42906(new byte[5] { 180, 152, 158, 153, 132 }, 247), value);
                _0xdf57c529.Instance._0x4eb7701d();
            }
        }
    }

    public static class _0xa8f07521
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x7ecec9b0
{
    internal static string _0xd9b42906(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}