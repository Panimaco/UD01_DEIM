using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{

    //Zona de Variables Globales
    public int NumberToMonth;

    // Start is called before the first frame update
    void Start()
    {
        
        GetMonthNumber();

    }

    //Zona de Variables Privadas
    private void GetMonthNumber() {

        //Dependiendo de el número puesto en "NumberToMonth"
        switch (NumberToMonth) {

            case 1:

                Debug.Log("El mes " + NumberToMonth + " es Enero.");
                break;

            case 2:

                Debug.Log("El mes " + NumberToMonth + " es Febrero.");
                break;

            case 3:

                Debug.Log("El mes " + NumberToMonth + " es Marzo.");
                break;

            case 4:

                Debug.Log("El mes " + NumberToMonth + " es Abril.");
                break;

            case 5:

                Debug.Log("El mes " + NumberToMonth + " es Mayo.");
                break;

            case 6:

                Debug.Log("El mes " + NumberToMonth + " es Junio.");
                break;

            case 7:

                Debug.Log("El mes " + NumberToMonth + " es Julio.");
                break;

            case 8:

                Debug.Log("El mes " + NumberToMonth + " es Agosto.");
                break;

            case 9:

                Debug.Log("El mes " + NumberToMonth + " es Septiembre.");
                break;

            case 10:

                Debug.Log("El mes " + NumberToMonth + " es Octubre.");
                break;

            case 11:

                Debug.Log("El mes " + NumberToMonth + " es Noviembre.");
                break;

            case 12:

                Debug.Log("El mes " + NumberToMonth + " es Diciembre.");
                break;

            default:

                Debug.Log("Introduce un número válido para saber el mes al que corresponde.");
                break;

        }
    }
}
