using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;
using UnityScreenNavigator.Runtime.Core.Page;

public class NestPage02 : MonoBehaviour
{
    [SerializeField]
    private Button _popButtonObj = null;
    [SerializeField]
    private Button _pushModalButtonObj = null;

    private PageContainer _pageContainer = null;
    private ModalContainer _modalContainer = null;

    void Start()
    {
        Assert.IsNotNull(_popButtonObj);

        _pageContainer = PageContainer.Find("NestPageContainer");
        Assert.IsNotNull(_pageContainer);
        _modalContainer = ModalContainer.Find("NestModalContainer");
        Assert.IsNotNull(_modalContainer);

        _popButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PopPage());

            }
            );
        _pushModalButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PushModal());
            }
            );
    }

    private IEnumerator PopPage()
    {
        var handle = _pageContainer.Pop(true);
        yield return handle;
    }

    private IEnumerator PushModal()
    {
        var handle = _modalContainer.Push("NestModal01", true);
        yield return handle;
    }
}