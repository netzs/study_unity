using UnityEngine;

public class SetLookRotation : MonoBehaviour
{
    public Transform A, B, C;
    Quaternion q = Quaternion.identity;
    void Update()
    {
 
        q.SetLookRotation(A.position, B.position);
        C.rotation = q;
        Debug.DrawLine(Vector3.zero, A.position, Color.red);
        Debug.DrawLine(Vector3.zero, B.position, Color.green);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.right * 1.5f), Color.black);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.forward * 1.5f), Color.yellow);
 
        Debug.Log ("C.right - A:" + Vector3.Angle (C.right, A.position));
        Debug.Log ("C.right - B:" + Vector3.Angle (C.right, B.position));
        Debug.Log ("C.up - B:" + Vector3.Angle (C.up, B.position));
    }

}
