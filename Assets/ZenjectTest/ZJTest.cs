using UnityEngine;
using Zenject;

public class ZJTest : MonoBehaviour
{
    [Inject]
    public void Constuct(A a, IC c, B b, ZjTestPrefab zjTestPrefab)
    {
        Debug.Log("Construct " + a + " " + c + " " + b.Num);

    }
}