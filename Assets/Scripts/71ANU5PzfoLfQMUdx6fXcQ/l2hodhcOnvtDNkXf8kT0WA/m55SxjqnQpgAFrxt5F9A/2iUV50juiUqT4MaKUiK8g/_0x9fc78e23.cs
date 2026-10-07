using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9fc78e23 : MonoBehaviour
{
    public bool IsOnlyYScale;
    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentHeaderText;
    public Image ContentImage;
    public Ease ease = Ease.OutSine;
    public float scaleDuration = 0.4f;
    public TMP_Text ContentMainText;
    private void _0x646f2b95()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0x2af55b18.Instance._0x0e508a2d();
    }

    public TMP_Text ContentAdditionalText;
    public void _0x4c0634c3()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0xfd7eb51c => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x646f2b95();
    }

    public GameObject Content;
}