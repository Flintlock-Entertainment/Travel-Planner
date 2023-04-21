using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public GameObject clientMessage;
    public GameObject tripPlan;
    public int[] messageData = new int[6];
    public int[] planData = new int[6];
    // Start is called before the first frame update
    void Start()
    {
        messageData = new int[] { 3000, 2, 4, 5, 2, 3 };
        clientMessage = GameObject.FindGameObjectWithTag("clientMessage");
        writeClientMessage();
        tripPlan = GameObject.FindGameObjectWithTag("planText");
    }

    void writeClientMessage()
    {
        string message = "Badget: " + messageData[0] + "$\n" +
            "Time: " + messageData[1] + " days\n" +
            "Intrests\n" +
            "* History: " + messageData[2] + "/5\n" +
            "* Nature: " + messageData[3] + "/5\n" +
            "* Shopping: " + messageData[4] + "/5\n" +
            "* Attraction: " + messageData[5] + "/5\n";
        clientMessage.GetComponent<TextMeshPro>().text = message;
    }
}
