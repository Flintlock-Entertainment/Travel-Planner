using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationData : MonoBehaviour
{
    [SerializeField] public string locName;
    [SerializeField] public int history;
    [SerializeField] public int nature;
    [SerializeField] public int shopping;
    [SerializeField] public int attraction;
    [SerializeField] public int price;

    public string DataToString()
    {
        return "Name: " + locName + "\n" +
            "Price: " + price + "$\n" +
            "Intrests:\n" +
            "* History: " + history + "/5\n" +
            "* Nature: " + nature + "/5\n" +
            "* Shopping: " + shopping + "/5\n" +
            "* Attraction: " + attraction + "/5\n";
    }


}
