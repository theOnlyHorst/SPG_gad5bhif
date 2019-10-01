using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[BoltGlobalBehaviour]
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    
    public override void SceneLoadLocalDone(string scene)
    {
        var spawnPos = new Vector3(Random.Range(-4,4),0,Random.Range(-4,4));

        BoltNetwork.Instantiate(BoltPrefabs.MyCube, spawnPos, Quaternion.identity);
    }


}
