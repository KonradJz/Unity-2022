using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform targer;
    public Vector3 offset;

    void Update()
    {
        transform.position = targer.position + offset;
    }
}
