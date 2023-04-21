using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetUserInfo : MonoBehaviour
{
    public TextMeshProUGUI UserName;
    public TextMeshProUGUI Balance;

    void Start()
    {
        string UName = PlayerPrefs.GetString("UserName", "");
        var UBalance = PlayerPrefs.GetInt("Balance", 0);

        if (!string.IsNullOrEmpty(UName))
            UserName.text = UName;
        else
            UserName.text = "User1298809";

        if (!string.IsNullOrEmpty(UBalance.ToString()))
            Balance.text = "Balance : $" + UBalance.ToString();
        else
            Balance.text = "Balance : $" + "0";
    }
}
