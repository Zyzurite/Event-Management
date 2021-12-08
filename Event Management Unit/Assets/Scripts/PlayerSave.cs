using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSave
{
    
    public int checkpoint;
    
    public PlayerSave(SimplePlayerController player)
    {
        checkpoint = player.checkpoint;
    }
}
