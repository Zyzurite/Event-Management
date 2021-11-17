using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBreak : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterController controller = other.GetComponent<CharacterController>();

            if (controller != null)
                StartCoroutine("ColorChanger");
                
        }
        
    }

    IEnumerator ColorChanger()
    {
        GameObject platform = gameObject.transform.parent.gameObject;
        platform.GetComponent<Renderer>().material.color = Color.green;
        yield return new WaitForSeconds(.3f);
        platform.GetComponent<Renderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(.3f);
        platform.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(.3f);
        platform.SetActive(false);
    }


}
