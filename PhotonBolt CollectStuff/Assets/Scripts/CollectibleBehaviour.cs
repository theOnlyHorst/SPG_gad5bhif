using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehaviour : Bolt.EntityBehaviour<IMyCollectibleState>
{
    private MeshRenderer rend;

    public override void Attached()
    {
        rend = GetComponent<MeshRenderer>();
        state.AddCallback("MyCollectibleStateEnabled",OnStateEnableChange);

        if(BoltNetwork.IsServer)
        state.MyCollectibleStateEnabled = true;
    }

    private void OnTriggerEnter(Collider other) {
        if(BoltNetwork.IsServer&&other.tag == "Player" && state.MyCollectibleStateEnabled)
        {
            state.MyCollectibleStateEnabled = false;
        }
    }

    public void ReEnable()
    {
        state.MyCollectibleStateEnabled = true;
    }

    public void OnStateEnableChange()
    {
        rend.enabled = state.MyCollectibleStateEnabled;
    }
}
