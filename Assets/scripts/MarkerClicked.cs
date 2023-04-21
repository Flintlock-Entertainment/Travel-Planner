using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerClicked : MonoBehaviour
{
    private LocationData data;
    private TripManager tripPlan;
    private bool wasClicked;

    private void Start()
    {
        data = GetComponent<LocationData>();
        tripPlan = GameObject.FindGameObjectWithTag("planText").GetComponent<TripManager>();
        wasClicked = false;
    }

    private void OnMouseDown()
    {
        Debug.Log("clicked");
        if (wasClicked)
        {
            tripPlan.RemoveLocation(data);
        }
        else
        {
            tripPlan.AddLocation(data);
        }
        wasClicked = !wasClicked;
    }
}
