using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{

    public int Number;

    // Start is called before the first frame update
    void Start()
    {
        
        GetAddition();

    }

    private void GetAddition() {

        int i = 0;
        int total = 0;

        //Empezando con "i" en 0, hasta que sea mayor que "Number", se incrementará pasando de 0 a 1 a 2...)
        for (i = 0; i <= Number; i++) {

            //En total se irá guardando la suma mientras se sigue ejecutando
            total = total + i;

        }

        //Despliega la información resultante en un Debug.Log
        Debug.Log("El resultado de la suma es " + total + ".");

    }
}
