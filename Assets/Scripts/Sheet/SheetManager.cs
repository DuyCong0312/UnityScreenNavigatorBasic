using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Sheet;

public class SheetManager : MonoBehaviour
{
    private SheetContainer _sheetContainer;
    [SerializeField]
    private Button _buttonSheet01;
    [SerializeField]
    private Button _buttonSheet02;
    [SerializeField]
    private Button _buttonSheet03;

    void Start()
    {
        Assert.IsNotNull(_buttonSheet01);
        Assert.IsNotNull(_buttonSheet02);
        Assert.IsNotNull(_buttonSheet03);

        _sheetContainer = SheetContainer.Find("SheetContainer");
        Assert.IsNotNull(_sheetContainer);


        _buttonSheet01.onClick.AddListener(
            () =>
            {
                StartCoroutine(RegisterSheet("Sheet01"));
                StartCoroutine(ShowSheet("Sheet01"));
            }
            );
        _buttonSheet02.onClick.AddListener(
            () =>
            {
                StartCoroutine(RegisterSheet("Sheet02"));
                StartCoroutine(ShowSheet("Sheet02"));
            }
            );
        _buttonSheet03.onClick.AddListener(
            () =>
            {
                StartCoroutine(RegisterSheet("Sheet03"));
                StartCoroutine(ShowSheet("Sheet03"));
            }
            );
    }

    private IEnumerator RegisterSheet(string sheetName)
    {
        var registerHandle = _sheetContainer.Register(sheetName);
        yield return registerHandle;
    }

    private IEnumerator ShowSheet(string sheetName)
    {
        var showHandle = _sheetContainer.Show(sheetName, false);
        yield return showHandle;
    }
}