using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootWearCharCustomize : MonoBehaviour
{
    public GameObject[] footwear;

    // Start is called before the first frame update
    void Start()
    {
        //footwear obj
        CollectionPrefs.FootWearIndex = PlayerPrefs.GetInt("Footwear", 0);
        foreach (GameObject footwear in footwear)
        {
            footwear.SetActive(false);
        }
        footwear[CollectionPrefs.FootWearIndex].SetActive(true);
    }
}
