using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padelmovement : MonoBehaviour
{
    public GameObject leftpadel;
    public GameObject rightpadel;
    public float rightpadelspeed;
    public float leftpadelspeed;
    
    public float rightpadelconstraintUp;
    public float rightpadelconstraintDown;
    
    public float leftpadelconstraintUp;
    public float leftpadelconstraintDown;
    


    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightpadel.transform.position += new Vector3(0, rightpadelspeed, 0)*Time.deltaTime;
            if (rightpadel.transform.position.y > rightpadelconstraintUp)
            {
                rightpadel.transform.position = new Vector3(rightpadel.transform.position.x, rightpadelconstraintUp, rightpadel.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rightpadel.transform.position += new Vector3(0, -rightpadelspeed, 0)*Time.deltaTime;
            if (rightpadel.transform.position.y < rightpadelconstraintDown)
            {
                rightpadel.transform.position = new Vector3(rightpadel.transform.position.x, rightpadelconstraintDown, rightpadel.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            leftpadel.transform.position += new Vector3(0, leftpadelspeed, 0)*Time.deltaTime;
            if (leftpadel.transform.position.y > leftpadelconstraintUp)
            {
                leftpadel.transform.position = new Vector3(leftpadel.transform.position.x, leftpadelconstraintUp, leftpadel.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            leftpadel.transform.position += new Vector3(0, -leftpadelspeed, 0)*Time.deltaTime;
            if (leftpadel.transform.position.y < leftpadelconstraintDown)
            {
                leftpadel.transform.position = new Vector3(leftpadel.transform.position.x, leftpadelconstraintDown, leftpadel.transform.position.z);
            }
        }
        
    }
}
