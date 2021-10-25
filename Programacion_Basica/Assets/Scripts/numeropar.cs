using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numeropar : MonoBehaviour
{
    [SerializeField] private int numero = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            numero = int.Parse(GetComponent<InputField>().text);
            esPar(numero);
        }
    }

    public void esPar(int numero)
    {
        if (numero % 2 == 0)
        {
            Debug.Log($"{numero} es un número par.");
        }

        else
        {
            Debug.Log($"{numero} es un número impar.");
        }
    }
}
