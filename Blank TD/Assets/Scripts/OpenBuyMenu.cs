using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBuyMenu : MonoBehaviour
{
    public GameObject buyMenu;
    public Manager manager;
    public bool noFakeStart;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
    }

    public void Update()
    {
        if(noFakeStart == false)
        {
            if (manager.arrayFilled == true)
            {
                FakeStart();
                noFakeStart = true;
            }
        }
    }

    void FakeStart()
    {
        buyMenu = manager.turnedOffGameObjects[2];
    }
    
    public void Openbuymenu()
    {
        if (buyMenu.activeSelf == false)
        {
            buyMenu.SetActive(true);
        }
        else
        {
            Closebuymenu();
        }
    }
    public void Closebuymenu()
    {
        buyMenu.SetActive(false);
    }
}