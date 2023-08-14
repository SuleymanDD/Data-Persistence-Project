using System.IO;
using UnityEngine;

public class CManager : MonoBehaviour
{
    public static CManager Instance;
    public string nameText;
    public int highScore;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string nameText;
        public int highScore;
    }
    public void SaveThis()
    {
        SaveData data = new SaveData();
        data.nameText = nameText;
        data.highScore = highScore;

        string json=JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadThis()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            nameText = data.nameText;
            highScore = data.highScore;
        }
    }

}
