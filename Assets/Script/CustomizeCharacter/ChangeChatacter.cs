using System.Collections.Generic;
//using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Progress;

public class ChangeChatacter : MonoBehaviour
{
    public GameObject[] HeadCharacters;
    public Image[] IconBackgroundImage;

    public int Index;

    public Image CurrentImage;
    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    public List<int> CharTorsoRemoveIndex = new();
    public List<int> BeardAndSunGlassIndex = new();


    public void ChangeCharProperty()
    {
        foreach (Image iconBackgroundImage in IconBackgroundImage)
        {
            iconBackgroundImage.sprite = CurrentImageSprite;
        }

        foreach (GameObject headCharacters in HeadCharacters)
        {
            headCharacters.SetActive(false);
        }

        StaticVar.IsRemovedHeadMenuCrossProperty = true;

        if (CharTorsoRemoveIndex.Count > 0)
        {
            StaticVar.IsRemovedHeadMenuCrossProperty = false;

            //Head menu click cross icon toggle checkbox value set false
            //02-03-2023
            for (int x = 0; x < BeardAndSunGlassIndex.Count; x++)
            {
                IconBackgroundImage[BeardAndSunGlassIndex[x]].GetComponent<Toggle>().isOn = false;
            }

            //Head menu click cross icon remove toggle icon value in TorsoCharProperty
            //02-03-2023
            for (int i = 0; i < CharTorsoRemoveIndex.Count; i++)
            {
                var response = ChangeCharTorso.CharIndexList(CharTorsoRemoveIndex[i], false);
                StaticVar.SetInts("TorsoCharProperty", response);
            }
            StaticVar.IsRemovedHeadMenuCrossProperty = true;
        }

        CurrentImage.sprite = ActiveImage;

        PlayerPrefs.SetInt("HeadCharProperty", Index);
        HeadCharacters[Index].SetActive(true);
    }

    /// <summary>
    /// This function use to head menu toggle icon click remove cross icon property
    /// 02-03-2023
    /// </summary>
    public void ToggleCheckRemoveCrossActive()
    {
        if(StaticVar.IsRemovedHeadMenuCrossProperty == true)
        {
            HeadCharacters[0].SetActive(false);
            IconBackgroundImage[0].sprite = CurrentImageSprite;
        }
    }
}
