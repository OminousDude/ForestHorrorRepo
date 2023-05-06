using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    Vector3 rotation = Vector3.zero;

    float degreesPerSec = 15;

    void Update()
    {
        rotation.x = Time.deltaTime * degreesPerSec;
        transform.Rotate(rotation, Space.World);
    }
}
