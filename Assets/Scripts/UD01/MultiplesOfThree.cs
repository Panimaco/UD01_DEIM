using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {

        GetMultiplesOfThree();

    }

    private void GetMultiplesOfThree() {

        int i = 0;

        //Mientras i no sea mayor que 100 se ir� incrementando en cada bucle
        while (i <= 100) {

            //Si la divisi�n de "i" / 3 tiene un resto de 0 y "i" es superior a 0
            if (i % 3 == 0 && i > 0) {

                //Despliega la informaci�n resultante en un Debug.Log
                Debug.Log(i);

            }

            i++;

        }
    }
}
