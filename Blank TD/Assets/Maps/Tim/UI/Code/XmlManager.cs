using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class XmlManager : MonoBehaviour
{

    private string path;
    public string fileName;
    public DataBase dataBase;

    public Slider master;
    public Slider music;
    public Slider sfx;



    GameObject gameManager;
   

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        path = Application.persistentDataPath;
        print(path);
        SetSliderValues();
    }

    public void SetSliderValues()
    {
        dataBase = Load();

        master.value = dataBase.master;
        music.value = dataBase.music;
        sfx.value = dataBase.sfx;
    }

    public void Save()
    {
        dataBase = new DataBase();

        dataBase.master = master.value;
        dataBase.music = music.value;
        dataBase.sfx = sfx.value;

        var serializer = new XmlSerializer(typeof(DataBase));
        var stream = new FileStream(path + "/" + fileName, FileMode.Create);
        serializer.Serialize(stream, dataBase);
        stream.Close();
    }

    public DataBase Load()
    {
        var serializer = new XmlSerializer(typeof(DataBase));
        var stream = new FileStream(path + "/" + fileName, FileMode.Open);
        DataBase loadedDatabase = serializer.Deserialize(stream) as DataBase;
        stream.Close();
        return loadedDatabase;
    }
}
