using UnityEngine;
using UnityEngine.UI;

public class _0xba4b0388 : MonoBehaviour
{
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x36c8771a.Instance._0x710f4cde(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xdf57c529.Instance._0x1fc69e84());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x36c8771a.Instance._0x710f4cde(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x36c8771a.Instance._0x710f4cde(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xdf57c529.Instance._0x1fc69e84());
        }
    }

    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
}