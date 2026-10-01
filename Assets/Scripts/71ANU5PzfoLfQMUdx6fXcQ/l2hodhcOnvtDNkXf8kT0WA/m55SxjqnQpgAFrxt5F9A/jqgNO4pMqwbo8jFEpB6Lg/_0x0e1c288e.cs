using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0e1c288e : MonoBehaviour
{
    private void _0xda9ca4fb()
    {
        if (this.OuterBackground != null)
        {
            Image _0xae9523b2 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xae9523b2, true);
            _0xae9523b2.DOFade(0f, this.ScaleDuration);
        }
    }

    public GameObject Content;
    public void _0x8fec137b()
    {
        this._0xda9ca4fb();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0xb5c7560c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x9fab0033 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x9fab0033, true);
            _0x9fab0033.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text HeaderText;
    private void _0xe12d4880()
    {
        if (this.OuterBackground != null)
        {
            Image _0xba307a7a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xba307a7a, true);
            _0xba307a7a.DOFade(1f, 0f);
        }
    }

    public TMP_Text MainText;
    private void _0x2abd8fcd()
    {
        if (this.OuterBackground != null)
        {
            Image _0xe6ffb033 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xe6ffb033, true);
            _0xe6ffb033.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public void Show()
    {
        this._0x2abd8fcd();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x36c8771a.Instance._0x44d9bb97(_0x36c8771a.Instance.CurrentPanelIndex);
            });
        }
    }

    private bool _0x5ac7a624 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xb5c7560c();
    }

    public Ease Ease = Ease.OutSine;
    public GameObject OuterBackground;
    public void _0x648ab213()
    {
        this._0xe12d4880();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x36c8771a.Instance._0x44d9bb97(_0x36c8771a.Instance.CurrentPanelIndex);
    }

    public bool IsScaledDownOnAwake = true;
    public float ScaleDuration = 0.4f;
}