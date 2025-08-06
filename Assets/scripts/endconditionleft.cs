using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endconditionleft : MonoBehaviour
{
    public GameObject uıController;
    public GameObject gamecontroller;


    void OnTriggerEnter2D(Collider2D other)
         {
        uıController.GetComponent<uıController>().addScoreright();
        gamecontroller.GetComponent<ballmovement>().newgame();
    }
}
