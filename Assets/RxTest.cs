using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class RxTest : MonoBehaviour
{
    public Button btStart;
    public Button btStop;

    void Start()
    {
        var btStartSubscribe = btStart.OnClickAsObservable().Subscribe(_ =>
        {
            Debug.Log("click");
        });
        btStop.OnClickAsObservable().Subscribe(_ =>
        {
            Debug.Log("stop");
            btStartSubscribe.Dispose();
        });

        ObservableWWW.Get("ya.ru").Subscribe(a =>
        {
            Debug.Log(a);
        });

    }

}