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
        PlayerSave data = SaveSystem.LoadPlayer();

        player.checkpoint = data.checkpoint;
        player.timer = 0.1f;
    }

    public void saveCheckpoint()
    {
        SaveSystem.SavePlayer(player);
    }
}
