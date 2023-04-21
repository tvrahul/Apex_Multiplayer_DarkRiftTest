using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharFootwear : MonoBehaviour
{
    public GameObject[] FootwearCharacters;
    public Image[] IconBackgroundImage;

    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    // Start is called before the first frame update
    void Start()
    {
        int Index = PlayerPrefs.GetInt("FootwearCharProperty", 0);

        if(FootwearCharacters.Length > 0)
        {
            foreach (GameObject item in FootwearCharacters)
            {
                item.SetActive(false);
            }

            FootwearCharacters[Index].SetActive(true);
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
