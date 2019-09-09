using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class NavAgent3 : MonoBehaviour
{
    
    private NavMeshAgent agent;

    private UpdateMousetargetIndicator updateMousetarget;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        updateMousetarget = GameObject.Find("Target Mouse").GetComponent<UpdateMousetargetIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
                RaycastHit hit;
                
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                    agent.destination = hit.point;
                    updateMousetarget.setPosition(hit.point);
                }
            }
    }
}
