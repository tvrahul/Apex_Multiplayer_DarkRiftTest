using UnityEngine;
using UnityEngine.UI;

public class HideUI : MonoBehaviour
{
    public Toggle toggle;
    public GameObject[] uiElements;

   public void Start()
    {
        toggle.isOn = false;
        // Attach listener to the toggle's onValueChanged event
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

   public void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            foreach (GameObject go in uiElements)
            {
                go.SetActive(false);
            }
           // uiElements.SetActive(false);
        }
        else
        {
            foreach (GameObject go in uiElements)
            {
                go.SetActive(true);
            }
        }
        // Set the active state of the UI element based on the value of the toggle
       
    }
}
