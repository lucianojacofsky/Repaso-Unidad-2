using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activate_Desactivate : MonoBehaviour
{
    public GameObject Inputfield;
      
    public void activateAnddesactivate()
    {
        //if(Inputfield.activeInHierarchy)
        //{
        //    Inputfield.SetActive(false);
        //}
        //else
        //{
        //    Inputfield.SetActive(true);
        //}
        Inputfield.SetActive(!Inputfield.activeInHierarchy);
            
    }



}
