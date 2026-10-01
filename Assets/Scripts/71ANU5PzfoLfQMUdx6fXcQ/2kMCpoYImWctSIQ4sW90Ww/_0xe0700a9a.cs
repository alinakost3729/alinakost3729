using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xe0700a9a : MonoBehaviour
{
    public void _0x436490c7()
    {
        _0xdf57c529.Instance._0xfdd151e3(true);
        _0xdf57c529.Instance.LoadSceneByIndex(_0x4a69945a._0x43fa6809.SCENE_0);
    }

    public List<Button> PauseButtons = new();
    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public bool IsGameEnd;
    public void _0xdcac81d2()
    {
        if (_0x0dfce3a3.Instance.IsOnlyWinGameEndEnabled)
            this._0xf62c0f79();
        if (!this.IsGameEnd)
        {
            this._0xe8c852a4();
            _0xdf57c529.IsAfterLevelComplete = false;
            _0xdf57c529.IsAfterLevelFailed = true;
            _0x9fc78e23 _0xad9aff07 = _0x2af55b18.Instance._0x6e27dfcb(_0x4a69945a._0x7e52c9eb.LOSE).GetComponent<_0x9fc78e23>();
            if (_0x0dfce3a3.Instance.IsCheckScoreEnabled)
                _0xad9aff07.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xadfc73db}";
            else
                _0xad9aff07.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xad9aff07.ContentAdditionalText.text = $"{0}";
            _0x4a69945a._0x5dc950a9._0x02606895 += 0;
            _0x2af55b18.Instance._0x2b580bcf(_0x4a69945a._0x7e52c9eb.LOSE);
        }
    }

    private IEnumerator _0x616b5556()
    {
        this._0x6ea02c26();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xdf57c529.Instance._0xfd2e5a41 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xdf57c529.Instance._0xac7816f3)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x6ea02c26();
            }
        }

        if (!this.IsGameEnd)
            this._0xdcac81d2();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public int CustomTargetScore = 10;
    public void _0x87ae5c97(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xa09078e7();
            this._0x16380a1e();
        }
    }

    public List<TMP_Text> ScoreText = new();
    private void _0x694eaffc()
    {
        if (this.ScoreCurrent >= this._0xadfc73db)
            this._0xf62c0f79();
        else
            this._0xdcac81d2();
    }

    private int _0xc3281712 => this.ScoreCurrent;

    private void _0xa09078e7()
    {
        if (_0x0dfce3a3.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x0cf6a979 => _0x0cf6a979.text = $"{this.ScoreCurrent}/{this._0xadfc73db}");
        else
            this.ScoreText.ForEach(_0x0cf6a979 => _0x0cf6a979.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> LevelNumberText = new();
    [HideInInspector]
    public int TimeLeft;
    private void _0x16380a1e()
    {
        if (this.ScoreCurrent > _0xdf57c529._0xa8979062._0x3560f525)
            _0xdf57c529._0xa8979062._0x3560f525 = this.ScoreCurrent;
        if (_0x0dfce3a3.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xadfc73db)
                this._0xf62c0f79();
    }

    private int _0xbe44bdd3 => this.CustomTimeInitial + _0xdf57c529._0xa8979062._0x0dca841a * 10;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xbe44bdd3;
        this.CurrentGameIndex = _0xdf57c529.Instance._0xfd2e5a41;
        foreach (Button _0x6eda1d3b in this.HomeButtons)
            _0x6eda1d3b.onClick.AddListener(() =>
            {
                this._0x436490c7();
            });
        foreach (Button _0x0c2fc01a in this.PauseButtons)
            _0x0c2fc01a.onClick.AddListener(() =>
            {
                _0xdf57c529.Instance._0xfdd151e3(false);
                _0x2af55b18.Instance._0x2b580bcf(_0x4a69945a._0x7e52c9eb.PAUSE);
            });
        this._0xa09078e7();
        this.LevelNumberText.ForEach(_0x0cf6a979 => _0x0cf6a979.text = $"LVL {_0xdf57c529._0xa8979062._0x0dca841a + 1}");
        if (_0x0dfce3a3.Instance.IsTimerEnabled)
        {
            this._0x6ea02c26();
            this.StartCoroutine(this._0x616b5556());
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    private void _0x6ea02c26()
    {
        this.TimerText.ForEach(_0x0cf6a979 => _0x0cf6a979.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x13dee5f6._0xc564960f(new byte[6] { 88, 88, 105, 15, 70, 70 }, 53)));
    }

    public void _0xf62c0f79()
    {
        if (!this.IsGameEnd)
        {
            this._0xe8c852a4();
            _0xdf57c529.IsAfterLevelComplete = true;
            _0xdf57c529.IsAfterLevelFailed = false;
            _0x9fc78e23 _0xef73d1a8 = _0x2af55b18.Instance._0x6e27dfcb(_0x4a69945a._0x7e52c9eb.WIN).GetComponent<_0x9fc78e23>();
            if (_0x0dfce3a3.Instance.IsCheckScoreEnabled)
                _0xef73d1a8.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xadfc73db}";
            else
                _0xef73d1a8.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x0dfce3a3.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x4a69945a._0x5dc950a9._0x02606895)
                    _0x4a69945a._0x5dc950a9._0x02606895 = this.ScoreCurrent;
                _0xef73d1a8.ContentAdditionalText.text = $"{_0x4a69945a._0x5dc950a9._0x02606895}";
            }
            else
            {
                _0xef73d1a8.ContentAdditionalText.text = $"{this._0xc3281712}";
                _0x4a69945a._0x5dc950a9._0x02606895 += this._0xc3281712;
            }

            if (_0x0dfce3a3.Instance.IsLevelIncrementOnWin)
                ++_0xdf57c529._0xa8979062._0x0dca841a;
            _0x2af55b18.Instance._0x2b580bcf(_0x4a69945a._0x7e52c9eb.WIN);
        }
    }

    private int _0xadfc73db => this.CustomTargetScore + _0xdf57c529._0xa8979062._0x0dca841a * 10;

    private static _0xe0700a9a _0xe43598bf;
    private void _0xe8c852a4()
    {
        this.IsGameEnd = true;
        _0xdf57c529.IsAfterLevelComplete = true;
    }

    private void Awake()
    {
        _0xe43598bf = this.gameObject.GetComponent<_0xe0700a9a>();
    }

    public List<Button> HomeButtons = new();
    public int CustomTimeInitial = 30;
}

internal static class _0x13dee5f6
{
    internal static string _0xc564960f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}