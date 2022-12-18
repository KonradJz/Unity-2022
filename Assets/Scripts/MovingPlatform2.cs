using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour
{
    // Kolekcja przechowująca waypointy (punkty) do odwiedzenia
    public List<Vector3> waypoints;

    // Aktualnie odwiedzany waypoint
    private int currentWaypoint = 0;

    // Czy platforma ma zawrócić po dojściu do ostatniego waypointa
    public bool loop = true;

    // Prędkość poruszania się platformy
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Jeśli platforma ma jeszcze waypointy do odwiedzenia
        if (currentWaypoint < waypoints.Count)
        {
            // Oblicz dystans do aktualnego waypointa
            float distance = Vector3.Distance(transform.position, waypoints[currentWaypoint]);

            // Jeśli dystans jest mniejszy niż odległość, jaką może pokonać platforma w jednej klatce, przesuń ją do aktualnego waypointa
            if (distance > speed * Time.deltaTime)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint], speed * Time.deltaTime);
            }
            else
            {
                // Jeśli platforma dotarła do waypointa, przejdź do następnego lub zawróć
                if (currentWaypoint == waypoints.Count - 1 && loop)
                {
                    // Zmień kierunek i zacznij od początku
                    currentWaypoint = 0;
                }
                else
                {
                    currentWaypoint++;
                }
            }
        }
    }
}