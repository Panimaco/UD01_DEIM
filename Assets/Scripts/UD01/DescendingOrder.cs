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

        //Si el número uno es mayor o igual que el dos y el número dos mayor o igual al tres
        if (NumberOne >= NumberTwo && NumberTwo >= NumberThree) {

            //Despliega la información resultante en un Debug.Log en orden de primero el uno, después el dos y por último el tres arfirmando el orden decreciente
            Debug.Log("Los números " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " están en orden decreciente.");

        }
        else {

            //Despliega la información resultante en un Debug.Log en orden de primero el uno, después el dos y por último el tres negando el orden decreciente
            Debug.Log("Los números " + NumberOne + ", " + NumberTwo + " y " + NumberThree + " no están en orden decreciente.");

        }
    }
}