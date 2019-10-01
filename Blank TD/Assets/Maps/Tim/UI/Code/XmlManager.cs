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

    public AudioMixer masterMixer;


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
       
    }

    public void Save()
    {
        dataBase = new DataBase();

        masterMixer.GetFloat("masterVolume", out dataBase.masterVolume);
        masterMixer.GetFloat("musicVolume", out dataBase.music);
        masterMixer.GetFloat("sfxVolume", out dataBase.sfx);

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
