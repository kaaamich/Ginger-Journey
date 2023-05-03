using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{
    private SpriteRenderer star;
    void Start()
    {
    star = GetComponent <SpriteRenderer> ();
    Destroy(gameObject, 3f);
    }
}