using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollect : MonoBehaviour
{
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
                other.GetComponent<SimplePlayerController>().cubeCount += 1;
                transform.parent.Translate(100, 100, 100);
                Destroy(transform.parent.gameObject, 0.1f);
            }
        }
    }
}
