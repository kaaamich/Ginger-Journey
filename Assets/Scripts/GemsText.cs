using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemsText : MonoBehaviour
{
    public static int Gem;
    Text text;
    void Start()
    {
        Gem = 0;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Gem.ToString();
    }
}