using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

public class Modal00 : MonoBehaviour
{
    [SerializeField]
    private Button _pushButtonObj = null;

    private ModalContainer _modalContainer = null;

    void Start()
    {
        Assert.IsNotNull(_pushButtonObj);

        _modalContainer = ModalContainer.Find("ModalContainer");
        Assert.IsNotNull(_modalContainer);

        _pushButtonObj.onClick.AddListener(
            () =>
            {
                StartCoroutine(PushModal());
            }
            );
    }

    private IEnumerator PushModal()
    {
        var handle = _modalContainer.Push("Modal01", true);
        yield return handle;
    }
}
