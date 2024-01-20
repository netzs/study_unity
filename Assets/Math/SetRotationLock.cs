using UnityEngine;

public class SetRotationLock : MonoBehaviour
{
    public Transform A, B, C, D, E;
    Vector3 axis = Vector3.zero;
    float xSpeed = 0.0f, ySpeed = 0.0f, zSpeed = 0.0f;

    void Update()
    {
        xSpeed += 22.5f * Time.deltaTime;
        ySpeed += 30.0f * Time.deltaTime;
        zSpeed += 70.5f * Time.deltaTime;
        A.eulerAngles = new Vector3(xSpeed, ySpeed, zSpeed);
        Debug.DrawLine(A.position, A.position + axis, Color.red);
        Debug.DrawLine(A.position, A.position + A.forward * 5, Color.blue);


        var frw = A.forward;

        var qb = B.rotation;
        qb.SetLookRotation(new Vector3(frw.x, frw.y, 0), Vector3.up);
        B.rotation = qb;
        var qc = C.rotation;
        qc.SetLookRotation(new Vector3(frw.x, 0, frw.z), Vector3.up);
        C.rotation = qc;
        var qd = D.rotation;
        qd.SetLookRotation(new Vector3(0, frw.y, frw.z), Vector3.up);
        D.rotation = qd;

        var right = A.rotation * Vector3.right;
        var forward = Vector3.Cross(right, Vector3.up);
        
        Debug.DrawLine(A.position, A.position + right * 3, Color.green);
        Debug.DrawLine(A.position, A.position + forward * 3, Color.white);
        
        var qe = E.rotation;
        qe.SetLookRotation(new Vector3(0, 0, frw.z), Vector3.up);
        E.rotation = qe;
    }
}