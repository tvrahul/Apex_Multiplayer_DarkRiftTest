using Common;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Auth : MonoBehaviour
{
    /// <summary>
    /// Error massage text UI get 
    /// </summary>
    public TextMeshProUGUI ErrorMessage;

    /// <summary>
    /// Email input field get
    /// </summary>
    public TMP_InputField Email;

    /// <summary>
    /// Password input field get
    /// </summary>
    public TMP_InputField Password;


    /// <summary>
    /// This method manage user signin data and messages
    /// </summary>
    public async void SignInAccountData()
    {
        if (string.IsNullOrEmpty(Email.text))
        {
            ErrorMessage.text = "Email is required";
        }
        else if (!MatchEmailPattern.ValidateEmail(Email.text))
        {
            ErrorMessage.text = "Please enter a valid email address";
        }
        else if (string.IsNullOrEmpty(Password.text))
        {
            ErrorMessage.text = "Password is required";
        }
        else
        {
            var response = await SignInAccount(Email.text, Password.text);

            if (response.Code == 200 && response.IsError == false)
            {
                PlayerPrefs.SetString("UserName", response.Item.UserName);
                PlayerPrefs.SetInt("Balance", (int)response.Item.Balance);

                ManageScenes.BackToGame();
            }
            else
            {
                ErrorMessage.text = response.Message;
            }
        }
    }

    /// <summary>
    /// This method use to get user data by id
    /// </summary>
    /// <returns></returns>
    public async Task<SuccessResult<Users>> SignInAccount(string Email,string Password)
    {
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format(StaticVar.APIEndPoint + "Users/UserSignIn?Email={0}&Password={1}", Email, Password));
            HttpWebResponse response = (HttpWebResponse)(await request.GetResponseAsync());
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string jsonResponse = reader.ReadToEnd();
            SuccessResult<Users> users = JsonConvert.DeserializeObject<SuccessResult<Users>>(jsonResponse);

            return users;
        }
        catch (Exception error)
        {
            throw error;
        }
    }
}
