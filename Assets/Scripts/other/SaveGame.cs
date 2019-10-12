using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveGame
{
    // check out this video to lern more about this system https://www.youtube.com/watch?v=XOjd_qU2Ido
    public static void saveData(MovmentController controller)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Player.Save";
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, controller);
        stream.Close();
    }
    public static GameData LoadData()
    {
        string path = Application.persistentDataPath + "/Player.Save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Progress not found in" + path);
            return null;
        }
    }
}
