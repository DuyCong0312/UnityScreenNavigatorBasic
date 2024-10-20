using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Page;

public class Page03 : MonoBehaviour
{
    [SerializeField]
    private Button _backButtonObj = null;

    private PageContainer _pageContainer = null;

    void Start()
    {
        Assert.IsNotNull(_backButtonObj);

        _pageContainer = PageContainer.Find("PageContainer");
        Assert.IsNotNull(_pageContainer);

        _backButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PopPage());
            }
            );
    }

    private IEnumerator PopPage()
    {
        var handle = _pageContainer.Pop(true);
        yield return handle;

        yield break;
    }

}