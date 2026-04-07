using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void MoveNow()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}