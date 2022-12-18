using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // referencja do obiektu drzwi
    public GameObject door;

    public GameObject player;
    // zmienna przechowująca informację, czy drzwi są otwarte
    private bool isOpen = false;
    // odległość, po której drzwi się otworzą
    public float distanceToOpen = 2.0f; 

    void Update()
    {
        // sprawdzenie, czy gracz jest odpowiednio blisko jednej ze stron drzwi
        if (Vector3.Distance(door.transform.position, player.transform.position) < distanceToOpen)
        {
            // jeżeli tak, to otwórz drzwi (jeżeli nie są już otwarte)
            if (!isOpen)
            {
                door.transform.Translate(Vector3.right * Time.deltaTime * 2);
                isOpen = true;
            }
        }
        else
        {
            // jeżeli gracz jest za daleko, to zamknij drzwi (jeżeli nie są już zamknięte)
            if (isOpen)
            {
                door.transform.Translate(Vector3.left * Time.deltaTime * 2);
                isOpen = false;
            }
        }
    }
}
