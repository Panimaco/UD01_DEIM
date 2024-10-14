using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{

    //Zona de Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;

    // Start is called before the first frame update
    void Start()
    {
        
        GetSmallestToLargest();

    }

    private void GetSmallestToLargest() {

        int small = 0,
            mid = 0,
            large = 0;

        //Si el número uno es menor que el dos y que el tres, se coloca en el "int small"
        if (NumberOne < NumberTwo && NumberOne < NumberThree) {

            small = NumberOne;

            //Si el número dos es menor que el tres, se coloca al dos en el "int mid" y al tres en el "int large"
            if (NumberTwo < NumberThree) {

                mid = NumberTwo;
                large = NumberThree;
            }

            //Sinó el número dos irá al "int large" y el tres al "int mid"
            else { 
                
                mid = NumberThree;
                large = NumberTwo;
            }

        }

        //Si el número dos es menor que el uno y que el tres, se coloca en el "int small"
        if (NumberTwo < NumberOne && NumberTwo < NumberThree) {

            small = NumberTwo;

            //Si el número uno es menor que el tres, se coloca al uno en el "int mid" y al tres en el "int large"
            if (NumberOne < NumberThree) {

                mid = NumberOne;
                large = NumberThree;
            }

            //Sinó el número uno irá al "int large" y el tres al "int mid"
            else {

                mid = NumberThree;
                large = NumberOne;
            }

        }

        //Si el número tres es menor que el uno y que el dos, se coloca en el "int small"
        if (NumberThree < NumberTwo && NumberThree < NumberOne) {

            small = NumberThree;

            //Si el número dos es menor que el uno, se coloca al dos en el "int mid" y al uno en el "int large"
            if (NumberTwo < NumberOne) {

                mid = NumberTwo;
                large = NumberOne;
            }

            //Sinó el número uno irá al "int mid" y el dos al "int large"
            else {

                mid = NumberOne;
                large = NumberTwo;
            }
        }

        //Despliega la información resultante en un Debug.Log en orden de primero el "small", después el "mid" y por último el "large"
        Debug.Log("El orden ascendente es " + small + " después " + mid + " y por último " + large + ".");

    }
}
