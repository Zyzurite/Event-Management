using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSet : MonoBehaviour
{
    public float time;
    public bool reset;
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
        if (other.gameObject.tag == ("Player") && other.GetComponent<SimplePlayerController>().timer <= 0.1)
            other.GetComponent<SimplePlayerController>().timer = time;
        if (other.gameObject.tag == ("Player") && reset)
            other.GetComponent<SimplePlayerController>().timer = 0.1f;
    }
}
