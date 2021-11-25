using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteAfter : MonoBehaviour
{
    public float timer;
    private float storedTimer;
    // Start is called before the first frame update
    void Awake()
    {
        storedTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer-= Time.deltaTime;
        if (timer <= 0)
        {
            gameObject.SetActive(false);
            timer = storedTimer;
        }
        
    }
}
