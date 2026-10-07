using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x4a69945a;

public class _0xdf57c529 : MonoBehaviour
{
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void _0xe8e6d099(Transform _0x5c10dea7)
    {
        Transform[] _0x44a791c7 = _0x5c10dea7.GetComponentsInChildren<Transform>();
        foreach (Transform _0xbb961e3d in _0x44a791c7)
            if (_0xbb961e3d != null && DOTween.IsTweening(_0xbb961e3d))
            {
                if (this._0xac7816f3)
                    DOTween.Play(_0xbb961e3d);
                else
                    DOTween.Pause(_0xbb961e3d);
            }
    }

    [HideInInspector]
    public List<_0x5c581cb0> MoneyCountContainers = new();
    public void _0x1fc69e84()
    {
        _0xa8979062._0x72e938e8 = true;
    }

    public void _0x3e155973()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    private static void MakeGrid(List<RectTransform> _0x6025a200, AspectRatioFitter _0x3b54bdda, float _0x52dfb0cc, int _0x73c003f1, int _0xfb7913bb)
    {
        _0x3b54bdda.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x3b54bdda.aspectRatio = _0x52dfb0cc;
        foreach (RectTransform _0x75e647ca in _0x6025a200)
        {
            int _0xa42030d0 = _0x75e647ca.transform.GetSiblingIndex();
            _0x75e647ca.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xa42030d0 % _0x73c003f1) * (1f / _0x73c003f1), (_0xfb7913bb - (Mathf.FloorToInt((float)_0xa42030d0 / _0x73c003f1) % _0xfb7913bb + 1f)) * (1f / _0xfb7913bb));
            _0x75e647ca.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xa42030d0 % _0x73c003f1 + 1f) * (1f / _0x73c003f1), (_0xfb7913bb - Mathf.FloorToInt((float)_0xa42030d0 / _0x73c003f1) % _0xfb7913bb) * (1f / _0xfb7913bb));
            _0x75e647ca.offsetMin = Vector2.zero;
            _0x75e647ca.offsetMax = Vector2.zero;
        }
    }

    private void Start()
    {
        if (this._0xfd2e5a41 != _0x43fa6809.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x43fa6809.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xa8979062._0x72e938e8 = false;
            _0x2af55b18.Instance._0x0e508a2d();
            _0x36c8771a.Instance._0x710f4cde(_0xa8f07521.TUTORIAL0);
        });
    }

    private IEnumerator _0x21fb5284(int _0xbb493eea)
    {
        _0x36c8771a.Instance._0x710f4cde(_0xa8f07521.SPLASH);
        AsyncOperation _0x2f714b8e = SceneManager.LoadSceneAsync(_0xbb493eea);
        while (!_0x2f714b8e.isDone)
            yield return null;
    }

    public bool _0xac7816f3 { get; private set; }

    public Transform Environment;
    public Canvas MainCanvas;
    public void LoadSceneByIndex(int _0xdb14548e)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x21fb5284(_0xdb14548e));
    }

    public void _0xfdd151e3(bool _0x8fddfef2)
    {
        this._0xac7816f3 = _0x8fddfef2;
        this._0x932bab09(!this._0xac7816f3);
        Physics2D.simulationMode = this._0xac7816f3 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xe8e6d099(this.EnvironmentWithTweensToToggle);
    }

    public Button DeleteProgressDataButton;
    public static _0xb2ffbd97 _0xa8979062 => _0xb2ffbd97.ALL_SCENES_SETTING_SINGLETONS[Instance._0xfd2e5a41];

    public static bool IsAfterLevelComplete;
    private void _0x932bab09(bool _0xff5297d4)
    {
        Rigidbody2D[] _0xf035c226 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x505c0c22 in _0xf035c226)
            if (_0xff5297d4)
                _0x505c0c22.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x505c0c22.constraints = RigidbodyConstraints2D.None;
    }

    private static _0xb2ffbd97 GAME_INDEX_SETTINGS(int _0x7f1a38b0)
    {
        return _0xb2ffbd97.ALL_SCENES_SETTING_SINGLETONS[_0x7f1a38b0];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xdf57c529>();
        this.RootGameObject = GameObject.FindWithTag(_0x6715087b._0x8f1e2938(new byte[4] { 156, 161, 161, 186 }, 206));
        if (this._0xfd2e5a41 == _0x43fa6809.SCENE_0)
            this._0xfdd151e3(true);
        else
            this._0xfdd151e3(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x5c581cb0>(true).ToList();
    }

    private void _0x0b030afc()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x43fa6809.SCENE_0);
    }

    public int _0xfd2e5a41 => SceneManager.GetActiveScene().buildIndex;

    public static bool IsAfterLevelFailed = false;
    public Button ShowResetTutorialButton;
    private static _0xb2ffbd97 _0x040f0732 => _0xb2ffbd97.ALL_SCENES_SETTING_SINGLETONS[0];

    public Transform EnvironmentWithTweensToToggle;
    private IEnumerator _0xa5f4fe2c(string _0x6e96f38f)
    {
        _0x36c8771a.Instance._0x710f4cde(_0xa8f07521.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x3a1ba8ab = SceneManager.LoadSceneAsync(_0x6e96f38f);
        while (!_0x3a1ba8ab.isDone)
            yield return null;
    }

    public void _0x4eb7701d()
    {
        foreach (_0x5c581cb0 _0xfd5d886f in this.MoneyCountContainers)
            _0xfd5d886f._0x4bc2cc8d();
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public static _0xdf57c529 Instance;
}

internal static class _0x6715087b
{
    internal static string _0x8f1e2938(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}