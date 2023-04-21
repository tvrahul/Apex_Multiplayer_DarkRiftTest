using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharHead : MonoBehaviour
{
    public GameObject[] HeadCharacters;
    public Image[] IconBackgroundImage;

    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    // Start is called before the first frame update
    void Start()
    {
        int Index = PlayerPrefs.GetInt("HeadCharProperty", 0);

        if(HeadCharacters.Length > 0)
        {
            foreach (GameObject item in HeadCharacters)
            {
                item.SetActive(false);
            }

            HeadCharacters[Index].SetActive(true);
        }

        if(IconBackgroundImage.Length > 0)
        {
            foreach (Image item in IconBackgroundImage)
            {
                item.sprite = CurrentImageSprite;
            }

            IconBackgroundImage[Index].sprite = ActiveImage;
        }
    }
}
