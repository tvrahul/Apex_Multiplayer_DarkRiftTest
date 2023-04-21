using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharOnTabChange : MonoBehaviour
{
    public GameObject[] MenuTab;
    public GameObject[] TabImageBody;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="MenuTabCardSingle"></param>
    public void ChangeTab(GameObject MenuTabCardSingle)
    {
        foreach (GameObject Item in TabImageBody)
        {
            Item.SetActive(false);
        }

        MenuTabCardSingle.SetActive(true);
    }

    public void changeTabProperty()
    {

        foreach (GameObject Item in MenuTab)
        {
            RectTransform myRectTransform2 = Item.GetComponent<RectTransform>();

            myRectTransform2.anchoredPosition3D = new Vector3(myRectTransform2.anchoredPosition3D.x, -96.12052f, myRectTransform2.anchoredPosition3D.z);
            //myRectTransform2.sizeDelta = new Vector2(myRectTransform2.rect.width, 304f);
            //myRectTransform2.GetComponent<Image>().color = new Color32(255, 255, 255, 204);
        }

        RectTransform myRectTransform = GetComponent<RectTransform>();

        //GetComponent<Image>().color = new Color32(255, 255, 255, 255);

        myRectTransform.anchoredPosition3D = new Vector3(myRectTransform.anchoredPosition3D.x, -56.12052f, myRectTransform.anchoredPosition3D.z);
        //myRectTransform.sizeDelta = new Vector2(myRectTransform.rect.width, 323.174f);

    }
}
