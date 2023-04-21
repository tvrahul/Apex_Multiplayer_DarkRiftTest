using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharLegs : MonoBehaviour
{

    public GameObject[] LegsCharacters;
    public Image[] IconBackgroundImage;

    public int Index;

    public Image CurrentImage;
    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;


    public void ChangeCharLegsProperty()
    {
        foreach (Image iconBackgroundImage in IconBackgroundImage)
        {
            iconBackgroundImage.sprite = CurrentImageSprite;
        }

        CurrentImage.sprite = ActiveImage;

        foreach (GameObject headCharacters in LegsCharacters)
        {
            headCharacters.SetActive(false);
        }

        PlayerPrefs.SetInt("LegsCharProperty", Index);
        LegsCharacters[Index].SetActive(true);
    }
}
