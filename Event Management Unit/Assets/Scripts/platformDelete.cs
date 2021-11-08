using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDelete : MonoBehaviour
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
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            player.GetComponent<SimplePlayerController>().cubeCount += 1;
            other.transform.position = new Vector3(100,100,100);
            Destroy(other.gameObject, 0.1f);
        }
    }
}
