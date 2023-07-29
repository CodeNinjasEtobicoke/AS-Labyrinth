using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGaol : MonoBehaviour
{
    public Transform goal;
    public Transform SecondGoal;
    private Animator animator;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            agent.destination = SecondGoal.position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (agent.hasPath)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
