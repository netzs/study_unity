using UnityEngine;
using Zenject;

public class TestSoInstaller : ScriptableObjectInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("Install bindings SO");
    }
}