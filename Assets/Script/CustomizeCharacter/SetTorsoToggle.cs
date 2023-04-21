using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTorsoToggle : MonoBehaviour
{
    public Toggle None;
    public Toggle Shirt;
    public Toggle SunGlass;
    public Toggle Beard;
    public Toggle Jacket;

    // Start is called before the first frame update
    void Start()
    {
        None.GetComponent<Toggle>();
        Shirt.GetComponent<Toggle>();
        SunGlass.GetComponent<Toggle>();
        Beard.GetComponent<Toggle>();
        Jacket.GetComponent<Toggle>();

        ICollection<int> TorsoCharPropertyIndex = StaticVar.GetInts("TorsoCharProperty");

        foreach (int item in TorsoCharPropertyIndex)
        {
            //None value Set
            if (item == 0)
                None.isOn = true;

            //Shirt value Set
            if (item == 1)
                Shirt.isOn = true;

            //SunGlass value Set
            if (item == 2)
                SunGlass.isOn = true;

            //Beard value Set
            if (item == 3)
                Beard.isOn = true;

            //Jacket value Set
            if (item == 4)
                Jacket.isOn = true;
        }
    }
}
