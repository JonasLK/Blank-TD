using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildFloor : MonoBehaviour
{
    public GameObject g1;
    public Vector3 v1;
    public int lXB;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lXB*lXB; i++)
        {
            Instantiate(g1, v1, Quaternion.identity);
            v1.x += 1;
            if (v1.x == lXB)
            {
                v1.z += 1;
                if (v1.z == lXB)
                {
                    v1.y += 1;
                }
                v1.x = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
