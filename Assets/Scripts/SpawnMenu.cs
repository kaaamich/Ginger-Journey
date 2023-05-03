using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenu : MonoBehaviour
{
    public GameObject box;
    
    void Start (){
        StartCoroutine (spawn());
    }

    IEnumerator spawn(){
        while(true){
            Vector3 pos = Camera.main.ScreenToWorldPoint (new Vector3 (Random.Range (0, Screen.width), Random.Range (0, Screen.height), Camera.main.farClipPlane / 2));
            Instantiate (box, pos, Quaternion.identity);
            yield return new WaitForSeconds (2.5f);
        }
    }
}