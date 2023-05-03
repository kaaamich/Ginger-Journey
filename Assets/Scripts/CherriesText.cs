using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CherriesText : MonoBehaviour
{
    public static int Cherry;
    Text text;
    void Start()
    {
        Cherry = 0;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Cherry.ToString() + "/3";
    }
}