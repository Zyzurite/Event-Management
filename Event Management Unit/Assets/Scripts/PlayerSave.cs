using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSave
{
    
    public int checkpoint;
    public bool redKey;
    public bool blueKey;
    public bool greenKey;
    
    public PlayerSave(SimplePlayerController player)
    {
        checkpoint = player.checkpoint;
        redKey = player.redKey;
        blueKey = player.blueKey;
        greenKey = player.greenKey;

    }
}
