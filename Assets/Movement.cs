using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int ranx;
    int rany;
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        
        ranx = Random.Range(-4, 4);
        rany = Random.Range(-4, 4);

        transform.position = new Vector3(12 ,rany);
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
       
        transform.position += -transform.right*Time.deltaTime;
            
        if (timer > 1500)
        {
            Destroy(gameObject);
        }
            }
}
