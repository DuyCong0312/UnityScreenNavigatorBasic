using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

public class Modal01 : MonoBehaviour
{
    [SerializeField]
    private Button _pushButtonObj = null;
    [SerializeField]
    private Button _popButtonObj = null;

    private ModalContainer _modalContainer = null;

    void Start()
    {
        Assert.IsNotNull(_pushButtonObj);
        Assert.IsNotNull(_popButtonObj);

        _modalContainer = ModalContainer.Find("ModalContainer");
        Assert.IsNotNull(_modalContainer);

        _pushButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PushModal());
            }
            );
        _popButtonObj.onClick.AddListener(
           () =>
           {
               StartCoroutine(PopModal());
           }
           );
    }

    private IEnumerator PushModal()
    {
        var handle = _modalContainer.Push("Modal02", true);
        yield return handle;
    }

    private IEnumerator PopModal()
    {
        var handle = _modalContainer.Pop(true);
        yield return handle;
    }
}
