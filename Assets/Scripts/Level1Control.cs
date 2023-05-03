using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Control : MonoBehaviour
{
    public GameObject cherry1, cherry2, cherry3;
    public static int open_cherry1, open_cherry2, open_cherry3;
    void Start()
    {
        open_cherry1 = PlayerPrefs.GetInt("cheeries1", 1);
        open_cherry2 = PlayerPrefs.GetInt("cheeries2", 1);
        open_cherry3 = PlayerPrefs.GetInt("cheeries3", 1);
    }

    // Update is called once per frame
    //switch case peredelat`
    void Update()
    {
        if (open_cherry1 == 1)
        {
            cherry1.SetActive(false);
        }

        if (open_cherry1 == 2)
        {
            cherry1.SetActive(true);
        }

        if (open_cherry2 == 1)
        {
            cherry2.SetActive(false);
        }

        if (open_cherry2 == 2)
        {
            cherry2.SetActive(true);
        }

        if (open_cherry3 == 1)
        {
            cherry3.SetActive(false);
        }

        if (open_cherry3 == 2)
        {
            cherry3.SetActive(true);
        }


        // ===================


        if (CherriesText.Cherry >= 1)
        {
            openCherry1();
        }

        if (CherriesText.Cherry >= 2)
        {
            openCherry2();
        }

        if (CherriesText.Cherry >= 3)
        {
            openCherry3();
        }
    }


    public void openCherry1()
    {
        open_cherry1 = 2;
        PlayerPrefs.SetInt("cherries1", open_cherry1);
    }

    public void openCherry2()
    {
        open_cherry2 = 2;
        PlayerPrefs.SetInt("cherries2", open_cherry2);
    }

    public void openCherry3()
    {
        open_cherry3 = 2;
        PlayerPrefs.SetInt("cherries3", open_cherry3);
    }
}

