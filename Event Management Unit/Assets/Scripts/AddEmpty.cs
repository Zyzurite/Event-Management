using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEmpty : MonoBehaviour
{
    public GameObject Parent;
    public int maxChildCount;
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
                for (int i = 0;Parent.transform.childCount < maxChildCount && i < maxChildCount; i++)
                {
                    GameObject child = new GameObject();
                    child.transform.parent = Parent.transform;
                }

            }
        }
    }
}
