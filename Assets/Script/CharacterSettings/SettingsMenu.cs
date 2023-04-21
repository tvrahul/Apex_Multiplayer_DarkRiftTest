using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject SettingUICard;
    public GameObject SettingIcon;
    public GameObject MenuIcon;

    /// <summary>
    /// This method use to show and hide Setting menu
    /// https://app.asana.com/0/0/1203960778002698/f
    /// 20-02-2023
    /// </summary>
    /// <param name="IsShow"></param>
    public void ShowSettingMenu(bool IsShow)
    {
        if(IsShow == true)
        {
            SettingUICard.SetActive(true);
            SettingIcon.SetActive(false);
            MenuIcon.SetActive(false);
        }
        else if (IsShow == false)
        {
            SettingUICard.SetActive(false);
            SettingIcon.SetActive(true);
            MenuIcon.SetActive(true);
        }
    }

}
