using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherriesCollecting : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CherriesText.Cherry += 1;
            Destroy(gameObject);
        }
    }
}
