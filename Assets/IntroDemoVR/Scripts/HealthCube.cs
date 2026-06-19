using UnityEngine;

public class HealthCube : MonoBehaviour
{
    public void OnCubePressed()
    {
        GameManager.Instance.AddHealth();

        int hp =
            GameManager.Instance.GetHealthMinus(20);

        Debug.Log(hp);
    }
}