using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    // Start is called before the first frame update
    // Update is called once per frame

    public Vector3 direction = new Vector3(0, -.05f, 0);
    public int maxMovement;
    int storedMaxMovement;
    public bool bothNeeded;
    bool bothActive;
    // Start is called before the first frame update
    // Update is called once per frame
    void Start()
    {
        storedMaxMovement = maxMovement;
    }
    void FixedUpdate()
    {
        if (!bothNeeded)
            bothActive = true;
        if (bothNeeded)
        {
            if (button1.GetComponentInChildren<ButtonCheck>().activated && button2.GetComponentInChildren<ButtonCheck>().activated)
                bothActive = true;
            else 
                bothActive = false;
        }
        

        if (button1.GetComponentInChildren<ButtonCheck>().activated && maxMovement >= 0 && bothActive)
            moveWallDown();
        else if (!button1.GetComponentInChildren<ButtonCheck>().activated && maxMovement <= storedMaxMovement || !bothActive && maxMovement <= storedMaxMovement)
            moveWallUp();
        
    }

    void moveWallDown()
    {
        transform.Translate(direction);
        maxMovement--;
    }

    void moveWallUp()
    {
        gameObject.transform.Translate(-direction);
        maxMovement++;
    }
}
