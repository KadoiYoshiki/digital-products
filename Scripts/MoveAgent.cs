using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class MoveAgent : MonoBehaviour
{
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        GotoNextPoint();
    }

    //private void Update()
    //{
        //if (agent.remainingDistance < 0.5f)
        //{
            //GotoNextPoint();
        //}
    //}
    
    void GotoNextPoint()
    {
        var nextPoint = new Vector3(0.0f, 0.0f, 0.0f);

        agent.SetDestination(nextPoint);
    }
}
