using TMPro;
using UnityEngine;

public class CounterUI : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    private void Start()
    {
        UpdateText();

        GameManager.Instance.OnCounterChanged += UpdateText;
    }

    public void UpdateText()
    {
        counterText.text =
            "Counter: " +
            GameManager.Instance.counter;
    }
}
