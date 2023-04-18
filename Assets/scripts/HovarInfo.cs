using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HovarInfo : MonoBehaviour
{
    private LocationData data;
    [SerializeField] public Information window;
    private void Start()
    {
        data = GetComponent<LocationData>();
        window = GameObject.FindGameObjectWithTag("informationPanel").GetComponent<Information>();
    }
    private void OnMouseEnter()
    {
        Debug.Log("mouse over");
        window.text = data.DataToString();
        window.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        Debug.Log("mouse left");
        window.gameObject.SetActive(false);
    }
}
