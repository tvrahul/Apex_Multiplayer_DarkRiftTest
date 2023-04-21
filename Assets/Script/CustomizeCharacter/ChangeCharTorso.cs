using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharTorso : MonoBehaviour
{
    static readonly List<int> CharacterIndex = new();

    public GameObject[] TorsoCharacters;
    public Image[] IconBackgroundImage;

    public int Index;

    Toggle m_Toggle;

    public Image CurrentImage;
    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    public List<int> CharTorsoRemoveIndex = new();

    /// <summary>
    /// This method use to change char torso // LIKE : Shirt, SunGlass, Beard, Jacket
    /// </summary>
    /// 
    public void ChangeTorso()
    {
        if (Index == 0)
        {
            foreach (int i in CharTorsoRemoveIndex)
            {
                IconBackgroundImage[i].GetComponent<Toggle>().isOn = false;

                IconBackgroundImage[i].sprite = CurrentImageSprite;
                TorsoCharacters[i].SetActive(false);

                var response = CharIndexList(i, false);

                StaticVar.SetInts("TorsoCharProperty", response);
            }

            CurrentImage.GetComponent<Toggle>().isOn = true;
            CurrentImage.sprite = ActiveImage;
            TorsoCharacters[0].SetActive(true);

            var responseAdd = CharIndexList(0, true);
            StaticVar.SetInts("TorsoCharProperty", responseAdd);
        }
        else
        {
            //IconBackgroundImage[0].GetComponent<Toggle>().isOn = false;
            IconBackgroundImage[0].sprite = CurrentImageSprite;
            TorsoCharacters[0].SetActive(false);
            var responseRemove = CharIndexList(0, false);
            StaticVar.SetInts("TorsoCharProperty", responseRemove);

            m_Toggle = GetComponent<Toggle>();

            if (m_Toggle.isOn == true)
            {
                CurrentImage.sprite = ActiveImage;
                TorsoCharacters[Index].SetActive(true);

                var response = CharIndexList(Index, true);
                StaticVar.SetInts("TorsoCharProperty", response);
            }
            else
            {
                CurrentImage.sprite = CurrentImageSprite;
                TorsoCharacters[Index].SetActive(false);

                var response = CharIndexList(Index, false);
                StaticVar.SetInts("TorsoCharProperty", response);

            }
        }
    }

    public static List<int> CharIndexList(int val, bool isAdd)
    {
        if (isAdd == true)
        {
            if (CharacterIndex.Count <= 0)
            {
                ICollection<int> CollectionCharacterIndex = StaticVar.GetInts("TorsoCharProperty");

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
            for (int i = 0; i < CharacterIndex.Count; i++)
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
