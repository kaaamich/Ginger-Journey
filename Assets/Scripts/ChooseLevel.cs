using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void GoMenu()
    {
        SceneManager.LoadScene("Chooselevel");
    }
}
