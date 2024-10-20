using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Page; 
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class PageManager : MonoBehaviour
{
    private PageContainer _pageContainer = null;

    void Start()
    {
        _pageContainer = PageContainer.Find("PageContainer");
        Assert.IsNotNull(_pageContainer);

        StartCoroutine(PushPage());
 
    }

    private IEnumerator PushPage()
    {
        var handle = _pageContainer.Push("Page01", true);
        yield return handle;
    }

}
