using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(SimplePlayerController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.checkpoint";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerSave data = new PlayerSave(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerSave LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.checkpoint";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSave data = formatter.Deserialize(stream) as PlayerSave;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found");
            return null;
        }
    }
}
