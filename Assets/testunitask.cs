using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class testunitask : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    
    void Start()
    {

        Test();
    }

    private async void Test()
    {
        await TripleClick();
    }

    private async UniTask TripleClick()
    {
        await button.OnClickAsync();
        await button.OnClickAsync();
        await button.OnClickAsync();
        Debug.Log("Three times clicked");
    }
 
}
