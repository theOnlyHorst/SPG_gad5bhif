using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMousetargetIndicator : MonoBehaviour
{

    private MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPosition(Vector3 pos)
    {
        if(!rend.enabled)
            rend.enabled = true;
        transform.position = pos;
    }
}
