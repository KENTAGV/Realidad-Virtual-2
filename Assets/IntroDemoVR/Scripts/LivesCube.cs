using UnityEngine;

public class LivesCube : MonoBehaviour
{
    public void OnCubePressed()
    {
        GameManager.Instance.RemoveLife();

        bool result = GameManager.Instance.HasLives(1);

        Debug.Log(result);
    }
}
