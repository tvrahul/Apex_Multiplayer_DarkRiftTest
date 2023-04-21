using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.UIElements;
using System;
using UnityEditor;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;
    [SerializeField] Color backgroundActiveColor;
    [SerializeField] Color handleActiveColor;
    UnityEngine.UI.Image backgroundImage, handleImage;
    private Color backgroundDefaultColor, handleDefaultColor;
    UnityEngine.UI.Toggle toggle;
    Vector2 handlePosition;

    public int TargetObj;
    public GameObject[] characterList;


    void Awake()
    {
        toggle = GetComponent<UnityEngine.UI.Toggle>();

        handlePosition = uiHandleRectTransform.anchoredPosition;

        backgroundImage = uiHandleRectTransform.parent.GetComponent<UnityEngine.UI.Image>();
        handleImage = uiHandleRectTransform.GetComponent<UnityEngine.UI.Image>();

        backgroundDefaultColor = backgroundImage.color;
        handleDefaultColor = handleImage.color;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }


    void OnSwitch(bool on)
    {
        uiHandleRectTransform.DOAnchorPos(on ? handlePosition * -1 : handlePosition, .4f).SetEase(Ease.InOutBack);
       
        backgroundImage.DOColor(on ? backgroundActiveColor : backgroundDefaultColor, .6f);

        handleImage.DOColor(on ? handleActiveColor : handleDefaultColor, .4f);
        CustomizeChar(on);
    }

    public void CustomizeChar(bool on)
    {
        if (on == true)
        {
            characterList[TargetObj].SetActive(true);

            var response = CollectionPrefs.CharIndexList(TargetObj, true);

            CollectionPrefs.SetInts("CharacterIndexList", response);
        }
        else
        {
            characterList[TargetObj].SetActive(false);

            var response = CollectionPrefs.CharIndexList(TargetObj, false);

            CollectionPrefs.SetInts("CharacterIndexList", response);
        }
    }

    void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener(OnSwitch);
    }
}