using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadWearCharCustomize : MonoBehaviour
{
    public GameObject[] headwear;

    // Start is called before the first frame update
    void Start()
    {
        //Headwear obj
        CollectionPrefs.HeadwearIndex = PlayerPrefs.GetInt("Headwear", 0);
        foreach (GameObject headwear in headwear)
        {
            headwear.SetActive(false);
        }
        headwear[CollectionPrefs.HeadwearIndex].SetActive(true);
    }
}
