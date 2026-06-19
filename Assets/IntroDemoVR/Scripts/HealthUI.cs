using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    private void Start()
    {
        UpdateText();

        GameManager.Instance.OnHealthChanged += UpdateText;
    }

    public void UpdateText()
    {
        healthText.text =
            "Health: " +
            GameManager.Instance.health;
    }
}
