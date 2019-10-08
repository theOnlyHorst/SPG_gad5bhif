using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBehaviour : Bolt.EntityBehaviour<IMyPlayerState>
{
    private NavMeshAgent agent;

    private BoltEntity ent;
    public override void Attached()
    {
        state.SetTransforms(state.MyPlayerStateTransform,transform);
        agent = GetComponent<NavMeshAgent>();
        ent = GetComponent<BoltEntity>();
    }

    public override void SimulateOwner()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
                
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                agent.destination = hit.point;
            }
        }
    }
   
    private void OnTriggerEnter(Collider other) {
        if(ent.IsOwner&&other.tag == "Collectible")
        {
            state.MyPlayerStatePoints++;
            Debug.Log(state.MyPlayerStatePoints);
        }
    }
}
