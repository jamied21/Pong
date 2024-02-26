using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2AI : MonoBehaviour
{
    //To enable AI
    //In Unity untick Racket Player 2 script
    //Tick Racket Player 2AI Script

    public float movementSpeed;
    public GameObject ball;

    private void FixedUpdate() { 

        //Gets AI to move racket up or down depending on the ball's y distance being
        //higher than 50 compared to the positon of the racket
        if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50) {

            if(transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movementSpeed;
            }
            else { GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movementSpeed; }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    }
}
