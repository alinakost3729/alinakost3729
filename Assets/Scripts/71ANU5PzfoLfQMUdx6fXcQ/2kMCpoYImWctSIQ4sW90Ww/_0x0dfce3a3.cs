using UnityEngine;

public class _0x0dfce3a3 : MonoBehaviour
{
    public bool IsTutorialEnabled;
    public bool IsSkipSplashEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x0dfce3a3>();
            DontDestroyOnLoad(this.gameObject);
            this._0xacf407b1();
        }
        else
        {
            this._0x1c00b42c();
            Destroy(this.gameObject);
        }
    }

    public static _0x0dfce3a3 Instance;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsBestScoreEnabled;
    public bool IsCheckScoreEnabled;
    private void _0xacf407b1()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTimerEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsStoryEnabled;
    private void _0x1c00b42c()
    {
    }
}