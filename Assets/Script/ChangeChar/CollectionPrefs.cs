//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//using static UnityEditor.Progress;
//using System;

public static class CollectionPrefs
{
    static readonly List<int> CharacterIndex = new();
    public static int HeadwearIndex = 0;
    public static int BottomWearIndex = 0;
    public static int FootWearIndex = 0;
  
    public static void DeleteKey(string key)
    {
        ///Delete Old
        int count = PlayerPrefs.GetInt(key + ".Count", 0);

        for (int i = 0; i < count; i++)
        {
            PlayerPrefs.DeleteKey(key + "[" + i + "]");
        }
    }

    /// <summary>
    /// SetString
    /// </summary>
    /// <param name="key"></param>
    /// <param name="collection"></param>
    public static void SetInts(string key, ICollection<int> collection)
    {

        //DeleteKey(key);

        ///Create a new
        PlayerPrefs.SetInt(key + ".Count", collection.Count);

        for (int i = 0; i < collection.Count; i++)
        {
            PlayerPrefs.SetInt(key + "[" + i + "]", collection.ElementAt(i));
        }

    }

    /// <summary>
    /// GetStrings
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static ICollection<int> GetInts(string key)
    {
        int count = PlayerPrefs.GetInt(key + ".Count", 0);
        int[] array = new int[count];

        for (int i = 0; i < count; i++)
        {
            array[i] = PlayerPrefs.GetInt(key + "[" + i + "]");
        }

        return array;
    }

    /// <summary>
    /// Store charector obj index value in list and return
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public static List<int> CharIndexList(int val , bool isAdd)
    {
        if (isAdd == true)
        {
            if(CharacterIndex.Count <= 0)
            {
                ICollection<int> CollectionCharacterIndex = GetInts("CharacterIndexList");

                if (CollectionCharacterIndex.Count > 0)
                {
                    foreach (int item in CollectionCharacterIndex)
                    {
                        CharacterIndex.Add(item);
                    }
                }
            }

            if (!CharacterIndex.Contains(val))
            {
                CharacterIndex.Add(val);
            }
        }
        else
        {
            for (int i=0; i < CharacterIndex.Count; i++)
            {
                if (val == CharacterIndex[i])
                {
                    CharacterIndex.RemoveAt(i);
                }
            }
        }

        return CharacterIndex;
    }
}
