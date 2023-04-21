//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Progress;

public class CharLegs : MonoBehaviour
{
    public GameObject[] LegsCharacters;
    public Image[] IconBackgroundImage;

    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    // Start is called before the first frame update
    void Start()
    {
        int Index = PlayerPrefs.GetInt("LegsCharProperty" , 0);

        if(LegsCharacters.Length > 0)
        {
            foreach (GameObject item in LegsCharacters)
            {
                item.SetActive(false);
            }

            LegsCharacters[Index].SetActive(true);
        }

        if (IconBackgroundImage.Length> 0)
        {
            foreach (Image item in IconBackgroundImage)
            {
                item.sprite = CurrentImageSprite;
            }

            IconBackgroundImage[Index].sprite = ActiveImage;
        }
    }
}
