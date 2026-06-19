using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private void Start()
    {
        // El script se suscribe a sí mismo a los eventos del GameManager
        GameManager.Instance.OnCounterChanged += PlayCounterSound;
        GameManager.Instance.OnHealthChanged += PlayHealthSound;
        GameManager.Instance.OnLivesChanged += PlayLivesSound;
    }

    public void PlayCounterSound()
    {
        Debug.Log("Counter Sound");
    }

    public void PlayHealthSound()
    {
        Debug.Log("Health Sound");
    }

    public void PlayLivesSound()
    {
        Debug.Log("Lives Sound");
    }
}
