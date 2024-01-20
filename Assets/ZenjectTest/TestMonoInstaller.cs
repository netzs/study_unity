using UnityEngine;
using Zenject;

public class TestMonoInstaller : MonoInstaller
{
    public Object prefab;
    public override void InstallBindings()
    {
        Debug.Log("Install bindings mono");
        Container.Bind<A>().AsSingle();
        Container.Bind<IC>().To<C>().AsSingle();
        Container.Bind<B>().FromFactory<FC>().AsTransient();

        Container.Bind<ZjTestPrefab>().FromComponentInNewPrefab(prefab).AsTransient();
    }
}

public class FC :  IFactory<B>
{
    private int counter = 0;
    public B Create()
    {
        counter++;
        return new B(counter);
    }
}

public class A
{
    public A()
    {
        Debug.Log("create A");
    }
}
public class B
{
    public readonly int Num;

    public B(int num)
    {
        Num = num;
        Debug.Log("create B:" + num);
    }
}

public interface IC
{
}

public class C : IC
{
    public C()
    {
        Debug.Log("create C");
    }
}