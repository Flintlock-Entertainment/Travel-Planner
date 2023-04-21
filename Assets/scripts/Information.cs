using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class Information : MonoBehaviour
{
    [SerializeField] public string text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = default;
    }

    private void OnEnable()
    {
        GetComponent<TextMeshPro>().text = text;
    }

    private void OnDisable()
    {
        GetComponent<TextMeshPro>().text = default;
    }
}
