using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        GetOddNumbers();
    
    }

    private void GetOddNumbers()
    {
        
        int i = 0;

        //Mientras "i" no sea mayor que 100 se incrementa
        while (i <= 100) {

            //Si "i" / 2 da un resto diferente a 0
            if (i % 2 != 0) {

                //Despliega la información resultante en un Debug.Log
                Debug.Log(i);

            }

            i++;

        }
    }
}
