using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToAngleAxis : MonoBehaviour
{
    public Transform A, B;
    float angle;
    Vector3 axis = Vector3.zero;
    float xSpeed = 0.0f, ySpeed = 0.0f, zSpeed = 0.0f;

    void Update()
    {
        xSpeed += 2.5f * Time.deltaTime;
        ySpeed += 10.0f * Time.deltaTime;
        zSpeed += 20.5f * Time.deltaTime;
        A.eulerAngles = new Vector3(xSpeed, ySpeed, zSpeed);
        A.rotation.ToAngleAxis(out angle, out axis);
        B.rotation = Quaternion.AngleAxis(angle, axis);
    }
}