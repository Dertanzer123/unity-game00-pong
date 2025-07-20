using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavebehavivor : MonoBehaviour
{
    public GameObject source;
    public float wavespeed;
    public Vector3 wavevelocity;
    public float lifetime;
    public float pushforce;
    
    // Start is called before the first frame update
    void Start()
    {
    Destroy(gameObject, lifetime);
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += wavevelocity*Time.deltaTime;
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("nonhit");
        if (other.gameObject.CompareTag($"ball"))
        {
            Debug.Log("hit");
            ballmovement.ballvelocity += (wavevelocity-ballmovement.ballvelocity)*pushforce*Time.deltaTime;
         
        }
    }
}
