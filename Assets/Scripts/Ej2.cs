using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////Crear las variables necesarias para /*ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible
//.Luego indicar cuánto dinero sobra o falta.*/
public class Ej2 : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;
    public int montodinero;
    // Start is called before the first frame update
    void Start()
    {
        int productos = producto1 + producto2 + producto3;

        if (productos > montodinero)

        {
            Debug.Log("La suma de los productos excede tu monto de dinero");
            Debug.Log("Te falta" + (productos - montodinero));
        }

        else
        {
            Debug.Log("La suma de los productos no excede tu monto de dinero");
            Debug.Log("Te sobra " + (montodinero - productos));
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
