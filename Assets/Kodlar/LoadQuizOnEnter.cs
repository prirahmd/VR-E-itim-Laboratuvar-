using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadQuizOnEnter : MonoBehaviour
{
    public string quizSceneName = "Kuis";
    private bool hasLoaded = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger by: " + other.name + " | tag: " + other.tag);

        if (hasLoaded) return;

        if (other.CompareTag("Player"))
        {
            hasLoaded = true;
            Debug.Log("Loading scene: " + quizSceneName);
            SceneManager.LoadScene(quizSceneName);
        }
    }
}