using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    public float speed = 0f;
    public float steps = 0f;
    public int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0) {
            if (steps <= 10) {
                 speed = 1f * Time.deltaTime;
                if ((steps += speed) > 10) {
                    speed = 10 - steps;
                }
                
                transform.Translate(speed, 0f, 0f);
            } else {
                direction = 1;
                steps = 0;
            }
        } 

        if (direction == 1) {
            if (steps <= 10) {
                 speed = 1f * Time.deltaTime;
                if ((steps += speed) > 10) {
                    speed = 10 - steps;
                }
                
                transform.Translate(0f, 0f, speed);
            } else {
                direction = 2;
                steps = 0;
            }
        }

        if (direction == 2) {
            if (steps <= 10) {
                speed = 1f * Time.deltaTime;
                if ((steps += speed) > 10) {
                    speed = 10 - steps;
                }

                speed *= -1;
                
                transform.Translate(speed, 0f, 0f);
            } else {
                direction = 3;
                steps = 0;
            }
        }
        
        if (direction == 3) {
            if (steps <= 10) {
                speed = 1f * Time.deltaTime;
                if ((steps += speed) > 10) {
                    speed = 10 - steps;
                }

                speed *= -1;
                
                transform.Translate(0f, 0f, speed);
            } else {
                direction = 0;
                steps = 0;
            }
        }
    }
}
