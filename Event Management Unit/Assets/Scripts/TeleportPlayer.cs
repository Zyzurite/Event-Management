using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject player;
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
            other.GetComponent<SimplePlayerController>().timer = 0.1f;
        if (other.gameObject.tag == ("Weight"))
        {
            float eee = 0.5f;
            player.GetComponent<SimplePlayerController>().cubeCount += eee;

        }
    }

}
