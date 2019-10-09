using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBuyMenu : MonoBehaviour
{
    public GameObject buyMenu;
    public Manager manager;
    
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
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