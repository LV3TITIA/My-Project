using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class BarmaidNavMeshAgentControler : MonoBehaviour
{
    [SerializeField]
    private Transform goal;

    //[SerializeField]
    //private GameObject WinMenu;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //destination = agent.destination;
        agent.SetDestination(goal.position);
        //WinMenu = GetComponentInChildren<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            //_arrived = true;
            //Debug.Log("You're Win !");
            // WinMenu.SetActive(true);
            MenuManager.instance.OnPlayerWin();
        }
    }
    public MenuManager menuManager;
    private NavMeshAgent agent;
    private Vector3 destination;
    //private bool _arrived = false;
}
