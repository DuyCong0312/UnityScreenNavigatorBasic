using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Page;

public class Page02 : MonoBehaviour
{
    [SerializeField]
    private Button _backButtonObj = null;
    [SerializeField]
    private Button _nextButtonObj = null;

    private PageContainer _pageContainer = null;

    void Start()
    {
        Assert.IsNotNull(_backButtonObj);
        Assert.IsNotNull(_nextButtonObj);

        _pageContainer = PageContainer.Find("PageContainer");
        Assert.IsNotNull(_pageContainer);

        _backButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PopPage());
            
            }
            );
        _nextButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PushPage());
            }
            );
    }

    private IEnumerator PushPage()
    {
        var handle = _pageContainer.Push("Page03", true);
        yield return handle;

        yield break;
    }

    private IEnumerator PopPage()
    {
        var handle = _pageContainer.Pop(true);
        yield return handle;

        yield break;
    }

}