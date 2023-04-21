using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeCharacter : MonoBehaviour
{
    public GameObject[] characterList;
   
    void Start()
    {
        //string[] array = { "6", "1" };
        //CollectionPrefs.SetStrings("CharacterIndexList", CharacterIndex);
        //CollectionPrefs.SetInts("CharacterIndexList", CharacterIndex);

        ICollection<int> CollectionCharacterIndex = CollectionPrefs.GetInts("CharacterIndexList");

        foreach (int item in CollectionCharacterIndex)
        {
            characterList[item].SetActive(true);
        }
    }

}
