using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBottomWear : MonoBehaviour
{
    public GameObject[] bottomwear;
    public GameObject[] bottomwearImage;

    // Start is called before the first frame update
    void Start()
    {
        //Charector obj img
        CollectionPrefs.BottomWearIndex = PlayerPrefs.GetInt("Bottomwear", 0);
        foreach (GameObject bottomwearImage in bottomwearImage)
        {
            bottomwearImage.SetActive(false);
        }
        bottomwearImage[CollectionPrefs.BottomWearIndex].SetActive(true);

        //Charector obj
        foreach (GameObject bottomwear in bottomwear)
        {
            bottomwear.SetActive(false);
        }
        bottomwear[CollectionPrefs.BottomWearIndex].SetActive(true);
    }

    public void ChangeNextCharacter()
    {
        bottomwearImage[CollectionPrefs.BottomWearIndex].SetActive(false);
        bottomwear[CollectionPrefs.BottomWearIndex].SetActive(false);

        CollectionPrefs.BottomWearIndex++;

        if (CollectionPrefs.BottomWearIndex == bottomwear.Length)
        {
            CollectionPrefs.BottomWearIndex = 0;
        }

        bottomwearImage[CollectionPrefs.BottomWearIndex].SetActive(true);
        bottomwear[CollectionPrefs.BottomWearIndex].SetActive(true);

        PlayerPrefs.SetInt("Bottomwear", CollectionPrefs.BottomWearIndex);
    }

    public void ChangePrevCharacter()
    {
        //Charector obj img
        bottomwearImage[CollectionPrefs.BottomWearIndex].SetActive(false);
        bottomwear[CollectionPrefs.BottomWearIndex].SetActive(false);

        CollectionPrefs.BottomWearIndex--;

        if (CollectionPrefs.BottomWearIndex == -1)
        {
            CollectionPrefs.BottomWearIndex = bottomwear.Length - 1;
        }

        bottomwearImage[CollectionPrefs.BottomWearIndex].SetActive(true);
        bottomwear[CollectionPrefs.BottomWearIndex].SetActive(true);

        PlayerPrefs.SetInt("Bottomwear", CollectionPrefs.BottomWearIndex);
    }
}
