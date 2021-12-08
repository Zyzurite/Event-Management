using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    private SimplePlayerController player;
    private void Start()
    {
        player = gameObject.GetComponent<SimplePlayerController>();
        
    }
    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void loadCheckpoint()
    {
        player.timer = 0.1f;
        PlayerSave data = SaveSystem.LoadPlayer();
        player.checkpoint = data.checkpoint;
        player.greenKey = data.greenKey;
        player.blueKey = data.blueKey;
        player.redKey = data.redKey;
    }

    public void saveCheckpoint()
    {
        SaveSystem.SavePlayer(player);
    }
}
