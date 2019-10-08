using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[BoltGlobalBehaviour]
public class NetworkCallback : Bolt.GlobalEventListener
{
    private static readonly int startOffsetCollSpawnX = -4;

    private static readonly int startOffsetCollSpawnZ = -5;

    private static readonly float offsetPos = 3;

    public override void SceneLoadLocalDone(string scene)
    {

        if(BoltNetwork.IsServer)
        {
            for(int i=0;i<20;i++)
            {
                var spawnPos = new Vector3(startOffsetCollSpawnX+i%4*offsetPos,-1,startOffsetCollSpawnZ+i/4*offsetPos);
                BoltNetwork.Instantiate(BoltPrefabs.Collectible,spawnPos,Quaternion.identity);
            }
        }
        else
        {
            var spawnPos = new Vector3(Random.Range(-4,4),-1,Random.Range(-4,4));

            BoltNetwork.Instantiate(BoltPrefabs.Player, spawnPos, Quaternion.identity);
        }

        


    }

    
}
