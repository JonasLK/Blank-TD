using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffGameobject : MonoBehaviour
{
    public int turnedOffGameObjectIndexNumber;

    void Start()
    {
        GameObject.Find("Manager").GetComponent<Manager>().TurnedOffGameObject(gameObject,turnedOffGameObjectIndexNumber);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
