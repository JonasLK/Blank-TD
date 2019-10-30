using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{

    public bool EscapeOpen;
    public GameObject Escape;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (EscapeOpen == false)
            {
                Escape.SetActive(true);
                EscapeOpen = true;
            }
            else
            {
                Escape.SetActive(false);
                EscapeOpen = false; 
            }
        }
    }
}
