using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    double ranx;
    double rany;
    public int timer;
    public GameObject Cloud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer > 500)
        {
            Instantiate(Cloud, transform.position, transform.rotation);
            timer = 0;
        }


    }
}
