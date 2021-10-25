using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
/*
        // Y Axis
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }

        //Z Axis

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 0, 10);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 0, -10);
        }
*/


        
        rotateGameObject(KeyCode.RightArrow, new Vector3(0, 10, 0));
       
    }
    //Función : ambitoVisibilidad quédevuelve nombre (Variable nombre, Variable nombre)
    public void rotateGameObject(KeyCode kCode, Vector3 rotation)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }
    }
}