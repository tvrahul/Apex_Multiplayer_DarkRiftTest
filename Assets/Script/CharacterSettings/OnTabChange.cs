using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class OnTabChange : MonoBehaviour
{
    public GameObject[] SettingTabCard;
    public GameObject[] TabImage;

    /// <summary>
    /// This function use to change tabbing
    /// https://app.asana.com/0/0/1203960778002698/f
    /// 20-02-2023
    /// </summary>
    /// <param name="SettingTabCardSingle"></param>
    public void ChangeTab(GameObject SettingTabCardSingle)
    {
        foreach (GameObject Item in SettingTabCard)
        {
            Item.SetActive(false);
        }

        SettingTabCardSingle.SetActive(true);
    }

    /// <summary>
    /// this function use to manage RectTransform property
    /// https://app.asana.com/0/0/1203960778002698/f
    /// 20-02-2023
    /// </summary>
    public void changeTabProperty()
    {

        foreach (GameObject Item in TabImage)
        {
            RectTransform myRectTransform2 = Item.GetComponent<RectTransform>();

            myRectTransform2.anchoredPosition3D = new Vector3(myRectTransform2.anchoredPosition3D.x, -60.5f, myRectTransform2.anchoredPosition3D.z);
            //myRectTransform2.sizeDelta = new Vector2(myRectTransform2.rect.width, 304f);
            myRectTransform2.GetComponent<Image>().color = new Color32(255, 255, 255, 204);
        }

        RectTransform myRectTransform = GetComponent<RectTransform>();

        GetComponent<Image>().color = new Color32(255, 255, 255, 255);

        myRectTransform.anchoredPosition3D = new Vector3(myRectTransform.anchoredPosition3D.x, -40.5f, myRectTransform.anchoredPosition3D.z);
        //myRectTransform.sizeDelta = new Vector2(myRectTransform.rect.width, 323.174f);

    }
}
