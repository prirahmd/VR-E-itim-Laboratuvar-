using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Animator animator;
    private bool isMoving = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        // ���� ��������� ��������
        if (animator != null)
        {
            animator.speed = 0;
        }
    }

    public void MoveNow()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            isMoving = true;

            // ���� ���������
            if (animator != null)
            {
                animator.speed = 1;
            }
        }
    }

    void Update()
    {
        if (isMoving && !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            isMoving = false;

            // ���� ��������� ��� ����
            if (animator != null)
            {
                animator.speed = 0;
            }
        }
    }
}