using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatScreen : MonoBehaviour
{
    public Text roundsSurvived;
    public WaveSpawner waveManager;

    void Start()
    {
        waveManager = GameObject.FindGameObjectWithTag("WaveManager").GetComponent<WaveSpawner>();
        roundsSurvived = GetComponentInChildren<Text>();
    }
    
    public void UpdateRoundsSurvived()
    {
        roundsSurvived.text = "You survived " + waveManager.waveCounter.ToString() + " waves";
    }
}