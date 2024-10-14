using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour {

    //Zona de Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;

    // Start is called before the first frame update
    void Start() {

        GetDescendingOrder();

    }

    private void GetDescendingOrder() {

        //Si el n�mero uno es mayor o igual que el dos y el n�mero dos mayor o igual al tres
        if (NumberOne >= NumberTwo && NumberTwo >= NumberThree) {

            //Despliega la informaci�n resultante en un Debug.Log en orden de primero el uno, despu�s el dos y por �ltimo el tres arfirmando el orden decreciente
            Debug.Log("Los n�meros " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " est�n en orden decreciente.");

        }
        else {

            //Despliega la informaci�n resultante en un Debug.Log en orden de primero el uno, despu�s el dos y por �ltimo el tres negando el orden decreciente
            Debug.Log("Los n�meros " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no est�n en orden decreciente.");

        }
    }
}