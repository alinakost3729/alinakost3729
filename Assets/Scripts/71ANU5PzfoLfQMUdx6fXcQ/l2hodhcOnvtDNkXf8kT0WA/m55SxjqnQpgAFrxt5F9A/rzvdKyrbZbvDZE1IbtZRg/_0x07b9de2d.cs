using UnityEngine;
using UnityEngine.UI;

public class _0x07b9de2d : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xdf57c529.Instance._0xfdd151e3(this.IsPhysicsRunOnClick));
    }

    public Button Button;
}