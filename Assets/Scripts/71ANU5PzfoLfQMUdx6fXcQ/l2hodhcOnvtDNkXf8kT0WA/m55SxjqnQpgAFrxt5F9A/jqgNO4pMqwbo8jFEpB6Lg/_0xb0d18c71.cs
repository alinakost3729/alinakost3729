using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xb0d18c71 : MonoBehaviour
{
    private static bool _0x275ae6ff = false;
    private void _0x0e1afdc3()
    {
        this.AnimationSlider.value = 0.05f;
        _0x275ae6ff = !_0x275ae6ff;
        this.AnimSliderSequence = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xad84ea58 => this.AnimationSlider.value = _0xad84ea58, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            if (!_0xf2129c2e._0x206625e7._0xf3277790)
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[Test] Timer out -> move to scene");
                    }
#endif
                }

                _0xf2129c2e._0x206625e7._0xbdc7ac42();
            }
        });
    }

    public Sequence AnimSliderSequence;
    public Slider AnimationSlider;
    public void _0x30ad11fd()
    {
        this._0x9b4ec686();
        bool _0x676e3abf = _0x275ae6ff;
        this.AnimSliderSequence = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xad84ea58 => this.AnimationSlider.value = _0xad84ea58, _0x676e3abf ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x275ae6ff = !_0x275ae6ff;
    }

    public GameObject Error;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xb0d18c71>();
    }

    public void _0x9b4ec686()
    {
        this.AnimSliderSequence?.Kill();
        this.AnimationSlider.value = _0x275ae6ff ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Background;
    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Content;
    public float FirstAnimationTime = 10.0f;
    public static _0xb0d18c71 Instance;
    public void _0x8584beac()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this.AnimSliderSequence?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x275ae6ff = false;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x4a69945a._0x43fa6809.SCENE_0 && !_0x275ae6ff)
        {
            this._0x0e1afdc3();
        }
        else
        {
            this._0x30ad11fd();
        }
    }
}