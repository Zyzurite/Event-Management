using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool activated;
    public GameObject onLever;
    public GameObject offLever;
    public GameObject text;
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
            KeyMemory key = other.GetComponent<KeyMemory>();
            

            if (controller != null)
            {
                if (!activated && key.redKey && key.blueKey && key.greenKey)
                {
                    activated = true;
                    onLever.transform.gameObject.SetActive(true);
                    offLever.transform.gameObject.SetActive(false);

                }
                else if (activated)
                {
                    activated = false;
                    onLever.transform.gameObject.SetActive(false);
                    offLever.transform.gameObject.SetActive(true);
                }
                else
                    StartCoroutine("TextDisplay");
            }
        }
        
    }

    IEnumerator TextDisplay()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1);
        text.SetActive(false);
    }
}
