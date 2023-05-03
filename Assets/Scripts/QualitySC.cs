using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualitySC : MonoBehaviour
{
public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
}
