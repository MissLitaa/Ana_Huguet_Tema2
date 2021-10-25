using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{

    [SerializeField] private string playerName;
    [SerializeField] private string playerAge;
    [SerializeField] private int x= 5;
    [SerializeField] private int y= 8;



    // Start is called before the first frame update
    void Start()
    {
        HelloWorld();
        HelloName("Ras");
        HelloName(playerName);
        Debug.Log(GetHello());


        /*
        Debug.Log(playerAge);
        Debug.Log($"Hola {playerName}");
        */



        /* 
         if (x == y)
         {
             Debug.Log("x es igual a y");
         }

         if (z == y)
         {
             Debug.Log("y es igual a z");
         }

         if (playerName == enemyName)
         {
             Debug.Log("Player y enemigo se llaman igual");
         }

         if (playerName != enemyName)
         {
             Debug.Log("Player y enemigo tienen distinto nombre");
         }

         if (playerHP > 0)
         {
             Debug.Log("Sigues vivo");
         }
         else
         {
             Debug.Log("Estás muerto");
         }
        

        if (playerAge < 13)

        { 
            Debug.Log("Eres un niño");
        }

        else if (playerAge < 18)
        { 
            Debug.Log("Eres adolescente");
        }

        else
        { 
            Debug.Log("Eres adulto");
        }
        
        */

        /* Debug.Log(transform.position);

        transform.position = new Vector3(x: 0, y: 0, z: 0);
        //transform.position = new Vector3.zero;
        */


    }

    // Update is called once per frame
    void Update()
    {
    

        
    }

    public void HelloWorld()
    {
        Debug.Log("¡Hola, mundo!");
    }

    public void HelloName(string name)
    {
        Debug.Log($"¡Hola {name}!");
    }

    public string GetHello()
    {
        return "Hola";
    }

    public int Suma(int x, int y)
    {
        return x + y ;
    }

    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.position += direction;
        }
               
    }
}
