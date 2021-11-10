using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPointSet : MonoBehaviour
{
    public GameObject newWarpPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
            other.GetComponent<SimplePlayerController>().warpPoint = newWarpPoint;
    }
}
