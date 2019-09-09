using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgent1 : MonoBehaviour
{
    [SerializeField]
    private Transform targetPos;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = targetPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
