using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public int rotation;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.eulerAngles = new Vector3(
    this.transform.eulerAngles.x + rotation,
    this.transform.eulerAngles.y,
    this.transform.eulerAngles.z
);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
