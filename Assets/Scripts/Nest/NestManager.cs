using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Page;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class NestManager : MonoBehaviour
{
    private PageContainer _pageContainer = null;

    void Start()
    {
        _pageContainer = PageContainer.Find("NestPageContainer");
        Assert.IsNotNull(_pageContainer);

        StartCoroutine(PushPage());

    }

    private IEnumerator PushPage()
    {
        var handle = _pageContainer.Push("NestPage01", true);
        yield return handle;
    }

}
