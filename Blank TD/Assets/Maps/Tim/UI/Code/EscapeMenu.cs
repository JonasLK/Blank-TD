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
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Escape.SetActive(false);
                EscapeOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
