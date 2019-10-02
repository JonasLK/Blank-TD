using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static GameObject healthCanvas;

    private void Awake()
    {
        healthCanvas = GameObject.Find("healthCanvas");
    }
}
