using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSwitchToggle : MonoBehaviour
{
    public Toggle Jacket;
    public Toggle Beard;
    public Toggle SunGlass;
    public Toggle Shirt;

    // Start is called before the first frame update
    void Start()
    {
        Jacket.GetComponent<Toggle>();
        Beard.GetComponent<Toggle>();
        SunGlass.GetComponent<Toggle>();
        Shirt.GetComponent<Toggle>();

        ICollection<int> CollectionCharacterIndex = CollectionPrefs.GetInts("CharacterIndexList");

        foreach (int item in CollectionCharacterIndex)
        {
            //if (PlayerPrefs.HasKey("CharacterIndexList")) {}
            //JAcket value Set

            if (item == 0)
                Jacket.isOn = true;

            //Beard value Set
            if (item == 1)
                Beard.isOn = true;

            //SunGlass value Set
            if (item == 2)
                SunGlass.isOn = true;

            //Shirt value Set
            if (item == 3)
                Shirt.isOn = true;
        }
    }
}
