using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteAfter : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
