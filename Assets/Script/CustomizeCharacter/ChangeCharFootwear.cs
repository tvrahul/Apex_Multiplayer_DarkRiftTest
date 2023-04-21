using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharFootwear : MonoBehaviour
{
    public GameObject[] FootwearCharacters;
    public Image[] IconBackgroundImage;

    public int Index;

    public Image CurrentImage;
    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    public void ChangeCharFootwearProperty()
    {
        foreach (Image iconBackgroundImage in IconBackgroundImage)
        {
            iconBackgroundImage.sprite = CurrentImageSprite;
        }

        CurrentImage.sprite = ActiveImage;

        foreach (GameObject headCharacters in FootwearCharacters)
        {
            headCharacters.SetActive(false);
        }

        PlayerPrefs.SetInt("FootwearCharProperty", Index);
        FootwearCharacters[Index].SetActive(true);
    }
}
