using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshCustomer : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    public bool atTill = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1.3f)

        {
            if (atTill == false)
            {
                UpdateDestination();
                IterateWaypointIndex();
            }
            
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);

    }

    void IterateWaypointIndex()
    {
        
        waypointIndex++;
        if(waypointIndex== waypoints.Length)
        {
            waypointIndex = 0;
            atTill = true;
        }
    }


}
