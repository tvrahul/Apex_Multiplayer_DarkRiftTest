using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public static void BackToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CharacterCustomization()
    {
        SceneManager.LoadScene("Customization");
    }

    public void OpenCharecterCustomization()
    {
        SceneManager.LoadScene("CharacterCustomization");
    }
}
