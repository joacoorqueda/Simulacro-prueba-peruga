using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
public class Ej1 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }

        else if (num2 == num1)
        {
            Debug.Log("Los numeros son iguales");
        }

        else
        {
            Debug.Log("Los numeros no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
