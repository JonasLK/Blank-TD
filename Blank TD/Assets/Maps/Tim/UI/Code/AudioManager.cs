using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer masterMixer;

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

}
