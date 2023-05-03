using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelD : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D (Collider2D other)
    	{ if (other.tag == "Player" )
        	{
          SceneManager.LoadScene("Level1Done");
        	}
	}
}