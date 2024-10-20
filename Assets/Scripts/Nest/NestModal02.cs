using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

public class NestModal02 : MonoBehaviour
{
    [SerializeField]
    private Button _popButtonObj = null;

    private ModalContainer _modalContainer = null;

    void Start()
    {
        Assert.IsNotNull(_popButtonObj);

        _modalContainer = ModalContainer.Find("NestModalContainer");
        Assert.IsNotNull(_modalContainer);

        _popButtonObj.onClick.AddListener(
           () =>
           {
               StartCoroutine(PopModal());
           }
           );
    }

    private IEnumerator PopModal()
    {
        var handle = _modalContainer.Pop(true);
        yield return handle;
    }
}
