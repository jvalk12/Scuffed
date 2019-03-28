using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump2 : MonoBehaviour
{

    CharacterController2D movement;
    public float distance = 4;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);


        if (Input.GetButtonDown("Jump") && !movement.m_Grounded && hit.collider!=null)
        {
            { GetComponent<Rigidbody2D>().velocity = new Vector2(speed * hit.normal.x, speed);
                //transform.localScale = transform.localScale.x == 1 ? new Vector2(-1, 1) : Vector2.one;
        }
                    }
    }
        
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,transform.position+ Vector3.right * transform.localScale.x*distance);
    }
}
