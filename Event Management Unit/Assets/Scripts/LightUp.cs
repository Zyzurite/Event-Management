using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour
{
    public bool redLight;
    public bool blueLight;
    public bool greenLight;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (redLight)
            if (Player.GetComponent<KeyMemory>().redKey)
                gameObject.GetComponent<Renderer>().material.color = Color.green;
        if (blueLight)
            if (Player.GetComponent<KeyMemory>().blueKey)
                gameObject.GetComponent<Renderer>().material.color = Color.green;
        if (greenLight)
            if (Player.GetComponent<KeyMemory>().greenKey)
                gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
