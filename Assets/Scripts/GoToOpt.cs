using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GoToOpt : MonoBehaviour
{
   public void GoMenu() 
   {
      SceneManager.LoadScene("Settings");
   }
}