using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Page;

public class Page01 : MonoBehaviour
{
    [SerializeField]
    private Button _nextButtonObj = null;

    private PageContainer _pageContainer = null;

    void Start()
    {
        Assert.IsNotNull(_nextButtonObj);

        _pageContainer = PageContainer.Find("PageContainer");
        Assert.IsNotNull(_pageContainer);

        _nextButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PushPage());
            
            }
            );
    }

    private IEnumerator PushPage()
    {
        var handle = _pageContainer.Push("Page02", true);
        yield return handle;

        yield break;
    }
}