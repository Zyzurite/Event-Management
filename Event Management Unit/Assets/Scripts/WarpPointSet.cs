using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPointSet : MonoBehaviour
{
    public GameObject newWarpPoint;
    public int checkpointNumber;
    private SimplePlayerController playerData;
    private void OnTriggerEnter(Collider other)
    {
        playerData = other.GetComponent<SimplePlayerController>();
        if (other.gameObject.tag == ("Player") && playerData.checkpoint < checkpointNumber)
        {
            playerData.checkpoint += 1;
        }
    }
}
