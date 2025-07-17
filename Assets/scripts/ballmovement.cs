using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddleLeft;
    public GameObject paddleRight;
    
    public float paddleleftwidth;
    public float paddlerightwidth;
    
    public float ballradius;
    
    public float ballspeed;
    public Vector3 ballvelocity;
    
    public float upboundary;
    public float downboundary;

    void Start()
    {
     ballvelocity = new Vector3(Random.Range(-100,100), Random.Range(-100,100), 0);
     ballvelocity.Normalize();
     ballvelocity *= ballspeed;
     
        
        
    }
    
    void Update()
    {
        
        ball.transform.position += ballvelocity*Time.deltaTime;
        
        if (ball.transform.position.y+ballradius > upboundary)
        {
            ball.transform.position = new Vector3(ball.transform.position.x, upboundary-ballradius, ball.transform.position.z);
            ballvelocity.y *= -1;
        }
        if (ball.transform.position.y-ballradius < downboundary)
        {
            ball.transform.position = new Vector3(ball.transform.position.x, downboundary+ballradius, ball.transform.position.z);
            ballvelocity.y *= -1;
        }

        if (ball.transform.position.x + ballradius > paddleRight.transform.position.x && ball.transform.position.x <paddleRight.transform.position.x&& Mathf.Abs(ball.transform.position.y-paddleRight.transform.position.y)<paddlerightwidth)
        {
            ball.transform.position = new Vector3(paddleRight.transform.position.x-ballradius, ball.transform.position.y, ball.transform.position.z);
            ballvelocity.x *= -1;
            
        }
        if (ball.transform.position.x - ballradius < paddleLeft.transform.position.x && ball.transform.position.x >paddleLeft.transform.position.x && Mathf.Abs(ball.transform.position.y-paddleLeft.transform.position.y)<paddleleftwidth)
        {
            ball.transform.position = new Vector3(paddleLeft.transform.position.x+ballradius, ball.transform.position.y, ball.transform.position.z);
            ballvelocity.x *= -1;
            
        }
        
        
        
    }
}
