using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharFootWear : MonoBehaviour
{
    public GameObject[] footwear;
    public GameObject[] footwearImage;

    // Start is called before the first frame update
    void Start()
    {
        //footwear obj img
        CollectionPrefs.FootWearIndex = PlayerPrefs.GetInt("Footwear", 0);

        foreach (GameObject footwearImage in footwearImage)
        {
            footwearImage.SetActive(false);
        }
        footwearImage[CollectionPrefs.FootWearIndex].SetActive(true);

        //footwear obj
        foreach (GameObject footwear in footwear)
        {
            footwear.SetActive(false);
        }
        footwear[CollectionPrefs.FootWearIndex].SetActive(true);
    }

    public void ChangeNextFootWear()
    {
        //Charector obj img
        footwearImage[CollectionPrefs.FootWearIndex].SetActive(false);
        footwear[CollectionPrefs.FootWearIndex].SetActive(false);

        CollectionPrefs.FootWearIndex++;
        
        if (CollectionPrefs.FootWearIndex == footwear.Length)
        {
            CollectionPrefs.FootWearIndex = 0;
        }
        footwearImage[CollectionPrefs.FootWearIndex].SetActive(true);
        footwear[CollectionPrefs.FootWearIndex].SetActive(true);

        PlayerPrefs.SetInt("Footwear", CollectionPrefs.FootWearIndex);
    }

    public void ChangePrevfootWear()
    {
        //Charector obj img
        footwearImage[CollectionPrefs.FootWearIndex].SetActive(false);
        footwear[CollectionPrefs.FootWearIndex].SetActive(false);

        CollectionPrefs.FootWearIndex--;

        if (CollectionPrefs.FootWearIndex == -1)
        {
            CollectionPrefs.FootWearIndex = footwearImage.Length - 1;
        }
        footwearImage[CollectionPrefs.FootWearIndex].SetActive(true);
        footwear[CollectionPrefs.FootWearIndex].SetActive(true);

        PlayerPrefs.SetInt("Footwear", CollectionPrefs.FootWearIndex);
    }

}
