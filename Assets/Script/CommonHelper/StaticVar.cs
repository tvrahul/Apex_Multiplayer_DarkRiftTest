using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class StaticVar
{
    public static bool IsRemovedHeadMenuCrossProperty = true;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key"></param>
    /// <param name="collection"></param>
    public static void SetInts(string key, ICollection<int> collection)
    {
        ///Create a new
        PlayerPrefs.SetInt(key + ".Count", collection.Count);

        for (int i = 0; i < collection.Count; i++)
        {
            PlayerPrefs.SetInt(key + "[" + i + "]", collection.ElementAt(i));
        }
    }

    /// <summary>
    /// 
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
    /// API end point
    /// </summary>
    public static string APIEndPoint = "https://localhost:7254/";
}
