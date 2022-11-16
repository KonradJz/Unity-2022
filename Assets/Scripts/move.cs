using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movedTotal = 0f;
    public float speed = 1f;
    public bool direction = false;

    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 10.0f);
    }

    void Update()
    {
        if(movedTotal <= 10){
            speed = 1f*Time.deltaTime;
            if((movedTotal += speed) > 10){
                speed = 10 - movedTotal;
            }
            if(direction){
                speed *= -1;
            }
            
            transform.Translate(speed, 0f, 0f);
        } else {
            movedTotal = 0f;
            direction =! direction;
        }
    }
}