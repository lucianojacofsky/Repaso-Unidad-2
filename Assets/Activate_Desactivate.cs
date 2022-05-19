using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activate_Desactivate : MonoBehaviour
{
    public GameObject Inputfield;
    public bool wasPressed;
    void start()
    {
        wasPressed = false;
    }
    
    public void activateAnddesactivate()
    {
        if(!wasPressed)
        {
            Inputfield.SetActive(false);
            wasPressed = true;
        }
        else
        {
            Inputfield.SetActive(true);
            wasPressed = false;
        }
       
            
    }



}
