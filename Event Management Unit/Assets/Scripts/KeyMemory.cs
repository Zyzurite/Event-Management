using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMemory : MonoBehaviour
{
    public bool redKey;
    public bool blueKey;
    public bool greenKey;
    private SimplePlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<SimplePlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        redKey = player.redKey;
        blueKey = player.blueKey;
        greenKey = player.greenKey;
    }
}
