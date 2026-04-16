using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetPointDistanceLoad : MonoBehaviour
{
    public Transform player;
    public string sceneName = "laboratuvar";
    public float triggerDistance = 1.5f;

    private bool hasLoaded = false;

    void Update()
    {
        if (hasLoaded || player == null) return;

        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= triggerDistance)
        {
            hasLoaded = true;
            SceneManager.LoadScene(sceneName);
        }
    }
}