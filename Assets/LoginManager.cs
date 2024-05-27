using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string contra_seleccionada;
    public InputField contra;
    
    


    public void IngresoContraseña ()
    {
        if (contra.text == contra_seleccionada)
        {
            Debug.Log("Access granted");
        }
        else { Debug.Log("Access denied"); }
    }
    
}
