using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioOption[] audioOptions;
    private enum AudioGroups { Master, Music, SFX };

    void Awake()
    {
        instance = GetComponent<AudioManager>();
    }

    void Start()
    {
        for (int i = 0; i < audioOptions.Length; i++)
        {
            audioOptions[i].Initialize();
        }
    }

}

[System.Serializable]
public class AudioOption
{
    public Slider slider;
    public GameObject redX;
    public string exposedParam;

    public void Initialize()
    {
        slider.value = PlayerPrefs.GetFloat(exposedParam);
    }
}