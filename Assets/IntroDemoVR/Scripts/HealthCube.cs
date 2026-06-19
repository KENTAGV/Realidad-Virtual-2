using UnityEngine;

public class HealthCube : MonoBehaviour
{
    public void OnCubePressed()
    {
        GameManager.Instance.AddHealth();

        int value =
            GameManager.Instance.GetHealthMinus(20);

        int value2 =
            GameManager.Instance.MultiplyValues(2,3);

        Debug.Log(value);
        Debug.Log(value2);
    }
}