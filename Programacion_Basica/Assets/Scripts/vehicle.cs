using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    // Sound guarda el sonido del vehiculo.
    [SerializeField] private string Sound = "Brum, brum";

    // La variable name indica el tipo/nombre del vehiculo.
    [SerializeField] private string Name;

    //La variable numberWheels indica la cantidad de ruedas del vehiculo.
    [SerializeField] private int numberWheels = 4;

    //La variable indica si está lloviendo.
    [SerializeField] private bool isRaining;

    //La variable indica si tiene sirena.
    [SerializeField] private bool hasSiren;

    [SerializeField] private bool isOn = true;

    //La variable indica si hace frío.
    [SerializeField] private bool isCold;

    //La variable indica la gasolina.
    [SerializeField] private float gasoline;

   

    // Start is called before the first frame update
    void Start()
    {
        /* Debug.Log(string.Format("{0} tiene {1} ruedas y hace {2}", Name, numberWheels, Sound));

         if (isRaining)
         {
             Debug.Log("Lleva un paraguas");

         } 

         if (hasSiren)
         {
             Debug.Log($"{Name} has a siren.");
         }
         else
         {
             Debug.Log($"{Name} has no siren");
         }

         

        if (isOn == true)
        {
            Debug.Log($"{Sound}");

        }

        else if (hasSiren == true)
        {
            Debug.Log($"{Name} hará {Sound} cuando se ponga en marcha.");
        }
      
        else
        {
            Debug.Log($"{Name} no está en marcha.");
        }
        */

        if (isOn == true)
        {
            if (gasoline < 10 && isOn == true) ;
            {
                Debug.Log($"A {Name} le queda poca gasolina!");

                if (hasSiren ==true)
                {
                    Debug.Log($"{Sound}");
                }
            }
        }
        
        else
        {
            Debug.Log($"{Name} no está en marcha!");
        }
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (isRaining == true && isCold ==true)
        {
            Debug.Log("Lleva un paraguas y una sudadera");
        }

        else
        {
            Debug.Log("No llueve o no hace frío");
        }



         if (isRaining == true || isCold == true)
        {
            Debug.Log("Lleva un paraguas y una sudadera");
        }

        else
        {
            Debug.Log("No llueve o no hace frío");
        }
        */

        if (isRaining == true)
        {
           
            if (isCold)
            { 
                Debug.Log("Lleva un paraguas y lleva una sudadera"); 
            }
            else
            {
                Debug.Log("Lleva un paraguas");
            }

        }
       else
        {
            Debug.Log("No llueve");
        }

        if (isOn == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }

        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        } 
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
                transform.rotation += Quaternion.Euler(new Vector3 = 0f, 90f, 0f);
        }*/
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                transform.localScale += Vector3.right;
                    }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.localScale -= Vector3.right;
            }
        }
        
     
    }
}
    
