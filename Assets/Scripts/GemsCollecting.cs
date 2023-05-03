using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GemsCollecting : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GemsText.Gem += 1;
            Destroy(gameObject);
        }
    }
}