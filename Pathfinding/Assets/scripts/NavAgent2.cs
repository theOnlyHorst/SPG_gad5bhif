using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgent2 : MonoBehaviour
{
    [SerializeField]
    private Transform[] targetPoses;

    private int currentTarget;
    

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
         agent.autoBraking = false;
        nextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
                nextPoint();
    }

    void nextPoint()
    {
        if (targetPoses.Length == 0)
                return;

        agent.destination = targetPoses[currentTarget].position;
        currentTarget = (currentTarget + 1) % targetPoses.Length;
    }
}
