using UnityEngine;

public class HideGuide : MonoBehaviour
{
    public GameObject guideBoard;
    public GameObject redPath;

    public void CloseGuide()
    {
        guideBoard.SetActive(false);
        redPath.SetActive(true);
    }
}