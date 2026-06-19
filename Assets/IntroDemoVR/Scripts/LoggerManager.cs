using UnityEngine;

public class LoggerManager : MonoBehaviour
{
    private void Start()
    {
        // El script se suscribe a sí mismo a los eventos del GameManager
        GameManager.Instance.OnCounterChanged += LogCounter;
        GameManager.Instance.OnHealthChanged += LogHealth;
        GameManager.Instance.OnLivesChanged += LogLives;
    }

    public void LogCounter()
    {
        Debug.Log("Counter Changed");
    }

    public void LogHealth()
    {
        Debug.Log("Health Changed");
    }

    public void LogLives()
    {
        Debug.Log("Lives Changed");
    }
}
