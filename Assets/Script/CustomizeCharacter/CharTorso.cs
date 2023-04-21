using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Progress;

public class CharTorso : MonoBehaviour
{
    public GameObject[] TorsoCharacters;
    public Image[] IconBackgroundImage;

    public Sprite ActiveImage;
    public Sprite CurrentImageSprite;

    // Start is called before the first frame update
    void Start()
    {
        ICollection<int> TorsoCharPropertyIndex = StaticVar.GetInts("TorsoCharProperty");

        foreach (Image item in IconBackgroundImage)
        {
            item.sprite = CurrentImageSprite;
        }

        foreach (int item in TorsoCharPropertyIndex)
        {
            TorsoCharacters[item].SetActive(true);

            if(IconBackgroundImage.Length > 0)
            {
                IconBackgroundImage[item].sprite = ActiveImage;
                IconBackgroundImage[item].GetComponent<Toggle>().isOn = true;
            }
        }
    }
}
