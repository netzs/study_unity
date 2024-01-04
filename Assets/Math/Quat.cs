using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quat : MonoBehaviour
{
    public float x, y, z, w;

    // Update is called once per frame
    void Update()
    {
        var rot = transform.localRotation;
        rot.x = x;
        rot.y = y;
        rot.z = z;
        rot.w = w;

        transform.localRotation = rot;

    }
}
