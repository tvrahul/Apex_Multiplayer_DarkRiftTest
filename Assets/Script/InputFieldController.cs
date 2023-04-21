using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour
{
    public GameObject messageField;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) )
        {
            gameObject.SetActive(false);
            messageField.SetActive(true);
        }
    }
}
