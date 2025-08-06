using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endconditionright : MonoBehaviour
{
   
    public GameObject uıController;
    public GameObject gamecontroller;


    void OnTriggerEnter2D(Collider2D other)
    {
        uıController.GetComponent<uıController>().addScoreleft();
        gamecontroller.GetComponent<ballmovement>().newgame();
    }
    
}
