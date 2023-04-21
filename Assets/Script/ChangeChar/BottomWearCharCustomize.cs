using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWearCharCustomize : MonoBehaviour
{

    public GameObject[] characters;

    // Start is called before the first frame update
    void Start()
    {
        //Charector obj
        CollectionPrefs.BottomWearIndex = PlayerPrefs.GetInt("Bottomwear", 0);
        foreach (GameObject characters in characters)
        {
            characters.SetActive(false);
        }
        characters[CollectionPrefs.BottomWearIndex].SetActive(true);
    }
}
