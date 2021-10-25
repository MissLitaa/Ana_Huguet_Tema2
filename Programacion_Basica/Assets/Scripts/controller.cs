using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float limX = 12;
    private float limY = 5;
    private float limZ = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Controladores.

        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.Q);
        MoveGameObject(Vector3.down, KeyCode.E);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);

        //Límites de pantalla. LimX =sería el límite de X (12) y los otros transform están libres.

        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }

        //Tomamos límites más grandes, por lo tanto no puede pasar de -12
        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }

        //Límite Y
        if (transform.position.y >= limY)
        {
            transform.position = new Vector3(transform.position.x, limY, transform.position.z);
        }

        if (transform.position.y <= -limY)
        {
            transform.position = new Vector3(transform.position.x, -limY, transform.position.z);
        }

        //Límite Z
        if (transform.position.z >= limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZ);
        }

        if (transform.position.z <= -limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limZ);
        }

    }

    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    { 
        if (Input.GetKeyDown(kCode))
        {
        transform.position += direction;
        }
    }
        

}