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

            //Despliega la informaci�n resultante en un Debug.Log en orden de primero el uno, despu�s el dos y por �ltimo el tres arfirmando el orden creciente
            Debug.Log("Los n�meros " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " est�n en orden creciente.");

        }

        //Sin�
        else {

            //Despliega la informaci�n resultante en un Debug.Log en orden de primero el uno, despu�s el dos y por �ltimo el tres negando el orden creciente
            Debug.Log("Los n�meros " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no est�n en orden creciente.");

        }
    }
}
