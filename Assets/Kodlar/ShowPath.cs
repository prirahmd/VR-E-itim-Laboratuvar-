using UnityEngine;

public class ShowPath : MonoBehaviour
{
    public GameObject yellowPath;

    public void ShowYellowPath()
    {
        yellowPath.SetActive(true);
    }
}