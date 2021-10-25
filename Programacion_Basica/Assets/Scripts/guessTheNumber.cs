using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guessTheNumber : MonoBehaviour
{
    private int randNum;
    private int playerInput;
    // Start is called before the first frame update
    void Start()
    {
      //El parámetro es de X a Y +1, para que incluya el último que de verdad queremos, ej 0 a 10, pues 0 a 11.
    
            randNum = Random.Range(1, 11);
          
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            playerInput = int.Parse(GetComponent<InputField>().text);
            {
                if (playerInput < randNum)
                {
                    Debug.Log("Este número es menor al de la máquina");
                }
                else if (playerInput > randNum)
                {
                    Debug.Log("Este número es mayor al de la máquina");
                }

                else
                {
                    Debug.Log("Este es el número que ha pensado la máquina");
                }
            }
        }
    }
}
