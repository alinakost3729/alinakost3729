using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x0db7238f : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xdf57c529.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xdf57c529.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}