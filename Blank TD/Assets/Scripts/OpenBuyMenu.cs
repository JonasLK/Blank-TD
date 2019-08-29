using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBuyMenu : MonoBehaviour
{
    public GameObject buyMenu;
    // Start is called before the first frame update
    void Start()
    {
        buyMenu = GameObject.FindGameObjectWithTag("BuyMenu");
    }

    // Update is called once per frame
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