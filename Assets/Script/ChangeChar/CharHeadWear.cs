using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class CharHeadWear : MonoBehaviour
{
    public GameObject[] headwear;
    public GameObject[] headwearImage;

    // Start is called before the first frame update
    void Start()
    {
        //Headwear obj img
        CollectionPrefs.HeadwearIndex = PlayerPrefs.GetInt("Headwear", 0);
        foreach (GameObject headwearImage in headwearImage)
        {
            headwearImage.SetActive(false);
        }
        headwearImage[CollectionPrefs.HeadwearIndex].SetActive(true);

        //Headwear obj
        foreach (GameObject headwear in headwear)
        {
            headwear.SetActive(false);
        }
        headwear[CollectionPrefs.HeadwearIndex].SetActive(true); 
    }

    public void ChangeNextHeadWear()
    {
        headwearImage[CollectionPrefs.HeadwearIndex].SetActive(false);
        headwear[CollectionPrefs.HeadwearIndex].SetActive(false);

        CollectionPrefs.HeadwearIndex++;

        if (CollectionPrefs.HeadwearIndex == headwear.Length)
        {
            CollectionPrefs.HeadwearIndex = 0;
        }

        headwearImage[CollectionPrefs.HeadwearIndex].SetActive(true);
        headwear[CollectionPrefs.HeadwearIndex].SetActive(true);

        PlayerPrefs.SetInt("Headwear", CollectionPrefs.HeadwearIndex);
    }

    public void ChangePrevHeadWear()
    {
        headwearImage[CollectionPrefs.HeadwearIndex].SetActive(false);
        headwear[CollectionPrefs.HeadwearIndex].SetActive(false);

        CollectionPrefs.HeadwearIndex--;

        if (CollectionPrefs.HeadwearIndex == -1)
        {
            CollectionPrefs.HeadwearIndex = headwear.Length - 1;
        }

        headwearImage[CollectionPrefs.HeadwearIndex].SetActive(true);
        headwear[CollectionPrefs.HeadwearIndex].SetActive(true);

        PlayerPrefs.SetInt("Headwear", CollectionPrefs.HeadwearIndex);
    }
}
