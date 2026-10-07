using UnityEngine;
using UnityEngine.UI;

public class _0xffa90e86 : MonoBehaviour
{
    public bool IsShowLastPop;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x2af55b18.Instance._0xb88f5fbb();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x2af55b18.Instance._0x0e508a2d());
        else
            this.Button.onClick.AddListener(() => _0x2af55b18.Instance._0x2b580bcf(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}