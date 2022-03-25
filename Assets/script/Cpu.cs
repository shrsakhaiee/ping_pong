using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cpu : MonoBehaviour
{
    float speed = 30;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Ball_y = Ball.transform.position.y;
        float Ball_x = Ball.transform.position.x;
        float Racket_y = transform.position.y;
        float Racket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
        float direction;

        if(Ball_x > 0)
        {
            if(Ball_y + Racket_h < Racket_y)
          {
            direction = -1;

          }
         else if(Ball_y  - Racket_h > Racket_y)
          {
             direction = 1;

          }
         else
           {
            direction = 0;

           }
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
        

        }
        
    }
}