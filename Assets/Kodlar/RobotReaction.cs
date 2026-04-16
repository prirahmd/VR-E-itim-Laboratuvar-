using UnityEngine;

public class RobotReaction : MonoBehaviour
{
    public Animator animator;

    public void OnMessageSent()
    {
        if (animator != null)
        {
            animator.SetTrigger("Talk");
        }
    }
}