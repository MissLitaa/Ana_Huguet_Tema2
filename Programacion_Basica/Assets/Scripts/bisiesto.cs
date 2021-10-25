using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bisiesto : MonoBehaviour
{
    private int year = 2020;

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Year coge el valor del componente... Casting es cambiar de tipo, Parse es cambiar a int, cambia a num entero
            year = int.Parse(GetComponent<InputField>().text);
            serBisiesto(year);
        }
    }

    //Las funciones van fuera de Start y Update.
    public void serBisiesto(int year)
    {
        //módulo para comprobar si es divisible entre 4 y resto cero, y luego comprobar SI da cero
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 100 == 0)
                {
                    Debug.Log($"{year} sí es un año bisiesto.");
                }
                else
                {
                    Debug.Log($"{year} no es un año bisiesto.");
                }
            }
            else
            {
                Debug.Log($"{year} sí es un año bisiesto.");
            }
        }
        else
        {
            Debug.Log($"{year} no es un año bisiesto.");
        }
    }
}
