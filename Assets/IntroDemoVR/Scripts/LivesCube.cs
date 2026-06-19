using UnityEngine;

public class LivesCube : MonoBehaviour
{
    public void OnCubePressed()
    {
        GameManager.Instance.RemoveLife();

        bool hasLife =
            GameManager.Instance.HasLives(1);

        Debug.Log(hasLife);
    }
}
