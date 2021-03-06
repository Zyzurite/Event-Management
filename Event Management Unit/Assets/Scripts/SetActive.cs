using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject block;
    public bool deactivate;
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
                if (deactivate)
                    block.SetActive(false);
                else 
                    block.SetActive(true);
            }

        }

    }
}
