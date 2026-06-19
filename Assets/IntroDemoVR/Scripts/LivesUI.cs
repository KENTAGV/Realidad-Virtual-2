using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private void Start()
    {
        UpdateText();

        GameManager.Instance.OnLivesChanged += UpdateText;
    }

    public void UpdateText()
    {
        livesText.text =
            "Lives: " +
            GameManager.Instance.lives;
    }
}
