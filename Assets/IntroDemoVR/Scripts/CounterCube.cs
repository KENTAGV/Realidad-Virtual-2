using UnityEngine;

public class CounterCube : MonoBehaviour
{
    public void OnCubePressed()
    {
        GameManager.Instance.AddCounter();

        GameManager.Instance.AddScore(10);

        int result =
            GameManager.Instance.GetCounterPlus(5);

        Debug.Log(result);
    }
}
