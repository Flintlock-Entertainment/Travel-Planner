using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TripManager : MonoBehaviour
{
    private int totalPrice;
    private int numOfLocations;
    private int historyScore;
    private int natureScore;
    private int shoppingScore;
    private int attractionScore;
    private string locations;


    public void AddLocation(LocationData data)
    {
        totalPrice += data.price;
        numOfLocations++;
        historyScore += data.history;
        natureScore += data.nature;
        shoppingScore += data.shopping;
        attractionScore += data.attraction;
        locations += "\n" + data.locName;
        updatePanel();
    }

    public void RemoveLocation(LocationData data)
    {
        totalPrice -= data.price;
        numOfLocations--;
        historyScore -= data.history;
        natureScore -= data.nature;
        shoppingScore -= data.shopping;
        attractionScore -= data.attraction;
        //locations += "\n" + data.locName;
        updatePanel();
    }

    private void updatePanel()
    {
            GetComponent<TextMeshPro>().text =  "locations: " + locations + "\n" +
            "Total Price: " + totalPrice + "$\n" +
            "Intrests:\n" +
            "* History: " + historyScore / numOfLocations + "/5\n" +
            "* Nature: " + natureScore / numOfLocations + "/5\n" +
            "* Shopping: " + shoppingScore / numOfLocations + "/5\n" +
            "* Attraction: " + attractionScore / numOfLocations + "/5\n";
    }

    public int GetPrice()
    {
        return totalPrice;
    }
    public int GetHistory()
    {
        return historyScore / numOfLocations;
    }
    public int GetNature()
    {
        return natureScore / numOfLocations;
    }
    public int GetShopping()
    {
        return shoppingScore / numOfLocations;
    }
    public int GetAttraction()
    {
        return attractionScore / numOfLocations;
    }

    public string GetLocations()
    {
        return locations;
    }
}
