using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    bool playerActivated;
    bool cubeActivated;
    public bool activated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerActivated || cubeActivated)
            activated = true;
        else
            activated = false;

        ChangeColor();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            playerActivated = true;
        //if (other.gameObject.tag == "Weight")
            //cubeActivated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && !cubeActivated)
            playerActivated = false;
        if (other.gameObject.tag == "Player" && cubeActivated)
            playerActivated = false;
        if (other.gameObject.tag == "Weight" && !playerActivated)
            cubeActivated = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Weight")
            cubeActivated = true;
        else
            cubeActivated = false;
    }

    void ChangeColor()
    {
        if (activated)
            transform.parent.GetComponent<Renderer>().material.color = Color.green;
        else
            transform.parent.GetComponent<Renderer>().material.color = Color.red;
    }
}
