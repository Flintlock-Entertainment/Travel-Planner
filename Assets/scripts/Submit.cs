using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Submit : MonoBehaviour
{
    [SerializeField]public TripManager tripManager;
    [SerializeField]public Game gameManager;
    [SerializeField] public GameObject report;
    [SerializeField] public GameObject reportBoard;

    private void WriteReport()
    {
        int[] data =  gameManager.messageData;
        float score =0f;
        score += abs(data[2] - tripManager.GetHistory());
        score += abs(data[3] - tripManager.GetNature());
        score += abs(data[4] - tripManager.GetShopping());
        score += abs(data[5] - tripManager.GetAttraction());
        score /= 4;
        score += data[0] - tripManager.GetPrice();
        string reportText = "Left Over: " + (data[0] - tripManager.GetPrice()) + "\n" +
            "History: " + abs(data[2] - tripManager.GetHistory()) + "\n" +
            "Nature: " + abs(data[3] - tripManager.GetNature()) + "\n" +
            "Shopping: " + abs(data[4] - tripManager.GetShopping()) + "\n" +
            "Attraction: " + abs(data[5] - tripManager.GetAttraction()) + "\n" +
            "Score: " + score + "\n" +
            "Locations:\n" + tripManager.GetLocations();
        report.GetComponent<TextMeshPro>().text = reportText;
        reportBoard.GetComponent<Transform>().position = new Vector3(0, 0, -2);
    }

    private int abs(int x)
    {
        if (x < 0)
            return -1 * x;
        return x;
    }

    public void OnMouseDown()
    {
        WriteReport();
    }
}
