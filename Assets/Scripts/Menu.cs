using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
   public void StartPressed() 
   {
      SceneManager.LoadScene("Level_1");
   }
   public void ExitPressed()
   {
      Application.Quit();
      Debug.Log("Exit Pressed");
   }
}