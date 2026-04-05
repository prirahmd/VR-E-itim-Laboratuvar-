using UnityEngine;

public class TeacherGreeting : MonoBehaviour
{
    public Animator teacherAnimator;
    public GameObject messageUI;

    void OnTriggerEnter(Collider other)
    {
        teacherAnimator.SetTrigger("Greet");
        messageUI.SetActive(true);
        Invoke("HideMessage", 20f);
    }

    void HideMessage()
    {
        messageUI.SetActive(false);
    }
}