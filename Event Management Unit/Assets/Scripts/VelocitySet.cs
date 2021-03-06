using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocitySet : MonoBehaviour
{
    public Vector3 direction;
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
        if (other.gameObject.tag == "Player")
        {
            CharacterController controller = other.GetComponent<CharacterController>();

            if (controller != null)
            {
                other.GetComponent<SimplePlayerController>().velocity.z = direction.z;
                other.GetComponent<SimplePlayerController>().velocity.x = direction.x;
            }
                
        }
            
    }
}
