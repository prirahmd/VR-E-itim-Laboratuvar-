using UnityEngine;

public class RobotTalkController : MonoBehaviour
{
    public Animator animator;

    public void StartTalking()
    {
        animator.SetBool("talk", true);
        Invoke("StopTalking", 2f); // Ì ﬂ·„ ·„œ… 2 ÀÊ«‰Ì
    }

    void StopTalking()
    {
        animator.SetBool("talk", false);
    }
}