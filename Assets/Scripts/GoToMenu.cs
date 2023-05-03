using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GoToMenu : MonoBehaviour
{
   public void GoMenu() 
   {
      SceneManager.LoadScene("Menu");
   }
}