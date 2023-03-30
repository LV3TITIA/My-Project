using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BarmaidNavMeshAgentControler : MonoBehaviour
{
    [SerializeField]
    private Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //destination = agent.destination;
        agent.SetDestination(goal.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            //_arrived = true;
            Debug.Log("You're Win !");
        }
    }


    private NavMeshAgent agent;
    private Vector3 destination;
    private bool _arrived = false;
}
