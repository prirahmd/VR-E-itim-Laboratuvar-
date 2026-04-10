using UnityEngine;

public class PathController : MonoBehaviour
{
    public GameObject yellowPathObject;

    public void EnableYellowPath()
    {
        yellowPathObject.SetActive(true);
    }
}