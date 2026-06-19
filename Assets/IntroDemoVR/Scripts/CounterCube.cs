using UnityEngine;

public class CounterCube : MonoBehaviour
{
    public void OnCubePressed()
    {
        GameManager.Instance.AddCounter();

        int value1 =
            GameManager.Instance.GetCounterPlus(5);

        int value2 =
            GameManager.Instance.SumValues(10,20);

        Debug.Log(value1);
        Debug.Log(value2);
    }
}
