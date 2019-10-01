using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer masterMixer;
    public AudioMixerGroup test;

    private void Start()
    {
        Test();
    }

    public void SetMasterVolume(float masterLvl)
    {
        masterMixer.SetFloat("masterVolume", masterLvl);
    }

    public void SetSfxVolume(float sfxLvl)
        {
        masterMixer.SetFloat("sfxVolume", sfxLvl);
        }

    public void SetMusicVolume(float musicLvl)
        {
        masterMixer.SetFloat("musicVolume", musicLvl);
        }

    void Test()
    {
        float mv;
        masterMixer.GetFloat("masterVolume", out mv);
        float muv;
        masterMixer.GetFloat("musicVolume", out muv);
        float sv;
        masterMixer.GetFloat("sfxVolume", out sv);
    }

}
