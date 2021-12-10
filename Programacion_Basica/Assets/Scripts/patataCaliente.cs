using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patataCaliente : MonoBehaviour
{
    private int counter;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(-1, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Dentro de esta clase tendremos las dos variables. Es más limpio.
        counter -= 1;
        if (counter <= 0)
        {
            Destroy(gameObject);
        }

        transform.localScale += 0.5f * Vector3.one;
    }
}
