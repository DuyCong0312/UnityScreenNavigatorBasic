using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityScreenNavigator.Runtime.Core.Modal;

public class ModalManager : MonoBehaviour
{
    private ModalContainer _modalContainer = null;

    void Start()
    {
        _modalContainer = ModalContainer.Find("ModalContainer");
        Assert.IsNotNull(_modalContainer);

        StartCoroutine(PushModal());
    }

    private IEnumerator PushModal()
    {
        var handle = _modalContainer.Push("Modal00", true);
        yield return handle;
    }
}
