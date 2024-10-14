using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour 
{ 

    // Start is called before the first frame update
    void Start() {

    GetMultiplesOfThreeTwo();

}

    private void GetMultiplesOfThreeTwo() {

        int i = 0;

        //Mientras "i" no sea mayor que 100 se incrementa 
        while (i <= 100) {

            //Si "i" / 3 da un resto de 0 y "i" es mayor que 0 y a la vez "i" / 2 da un resto de 0 y "i" es superior a 0
            if ((i % 3 == 0 && i > 0) || (i % 2 == 0 && i > 0)) {

                //Despliega la información resultante en un Debug.Log
                Debug.Log(i);

            }

            i++;

        }
    }
}
