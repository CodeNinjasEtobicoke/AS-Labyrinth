using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal1;
    private Animator animator1;
    private NavMeshAgent agent1;
    // Start is called before the first frame update
    void Start()
    {
        animator1 = GetComponentInChildren<Animator>();
        agent1 = GetComponent<NavMeshAgent>();
        agent1.destination = goal1.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (agent1.hasPath)
        {
            animator1.SetBool("isRunning", true);
        }
        else
        {
            animator1.SetBool("isRunning", false);
        }
    }
}
