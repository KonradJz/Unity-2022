using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;

    public float speed = 1f;

    private Vector3 currentTarget; 

    void Start()
    {
        currentTarget = endPoint.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        if (transform.position == endPoint.position)
        {
            currentTarget = startPoint.position;
        }
        else if (transform.position == startPoint.position)
        {
            currentTarget = endPoint.position;
        }
    }
}
