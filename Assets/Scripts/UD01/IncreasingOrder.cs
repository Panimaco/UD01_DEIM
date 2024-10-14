using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    //Zona de Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;

    // Start is called before the first frame update
    void Start()
    {

        GetIncreasingOrder();

    }

    private void GetIncreasingOrder() {

        //Si el primer numero es menor o igual que el segundo y el segundo es menor o igual que el tercero
        if (NumberOne <= NumberTwo && NumberTwo <= NumberThree) {

            //Despliega la información resultante en un Debug.Log en orden de primero el uno, después el dos y por último el tres arfirmando el orden creciente
            Debug.Log("Los números " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " están en orden creciente.");

        }

        //Sinó
        else {

            //Despliega la información resultante en un Debug.Log en orden de primero el uno, después el dos y por último el tres negando el orden creciente
            Debug.Log("Los números " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no están en orden creciente.");

        }
    }
}
