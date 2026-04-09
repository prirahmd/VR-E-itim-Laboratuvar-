using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadQuizByDistance : MonoBehaviour
{
    public Transform player;
    public Transform targetPoint;
    public string quizSceneName = "Kuis";
    public float loadDistance = 0.5f;

    private bool hasLoaded = false;

    void Update()
    {
        if (hasLoaded || player == null || targetPoint == null)
            return;

        float distance = Vector3.Distance(player.position, targetPoint.position);
        Debug.Log("Distance to target = " + distance);

        if (distance <= loadDistance)
        {
            hasLoaded = true;
            Debug.Log("Loading scene: " + quizSceneName);
            SceneManager.LoadScene(quizSceneName);
        }
    }
}