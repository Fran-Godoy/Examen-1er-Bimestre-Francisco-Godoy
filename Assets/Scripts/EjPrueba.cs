using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//El prestigioso festival de música TICapalooza se prepara para una nueva edición en nuestro país y los organizadores nos piden que desarrollemos un programa para calcular la recaudación del evento en la venta de entradas.

//Se debe ingresar la cantidad de entradas vendidas para cada tipo.
//Sabemos que el límite de espectadores totales en el predio del evento es de 20,400 personas en Campo y 16,200 en Plateas y el precio de las entradas es de $1200 para Campo y $2000 para Platea.

//El programa debe cumplir los siguientes requerimientos:
//Se debe mostrar en consola un mensaje informando la recaudación por entradas de campo y de plateas por separado y luego el total sumado. 


//Se debe mostrar qué cantidad del total de la capacidad del predio quedó vacante. Si las entradas vendidas equivalen al total de la capacidad del predio debe mostrarse además el mensaje “Sold Out!”.


//Si la suma de la cantidad de entradas para ambos tipos supera la mitad de la  capacidad del predio debe mostrarse el mensaje “El festival fue un éxito!”. Si no lo supera debe mostrarse “Debemos mejorar la convocatoria.


//Debe mostrarse un mensaje de error descriptivo y no realizar ningún cálculo si la cantidad de entradas vendidas en cualquiera de los tipos es menor a cero o superior a la capacidad del predio para ese tipo.


public class EjPrueba : MonoBehaviour
{
    public int Entrada_campo;
    public int Entrada_platea;
    // Start is called before the first frame update
    void Start()
    {
        int res_campo;
        int res_platea;
        int res_total; 
        res_campo = Entrada_campo * 1200;
        res_platea = Entrada_platea * 2000;
        res_total = res_platea + res_campo;
        if (Entrada_campo == 0)
        {
            Debug.Log("Error, no se pueden vender esa cantidad de entradas");
        }
        else if (Entrada_platea == 0)
        {
            Debug.Log("Error, no se pueden vender esa cantidad de entradas");
        }
        else if (Entrada_platea> 16200)
        {
            Debug.Log("Error, no se pueden vender esa cantidad de entradas");
        }
        else if (Entrada_campo> 20400)
        {
            Debug.Log("Error, no se pueden vender esa cantidad de entradas");
        }
        else if (Entrada_campo >= 10200 && Entrada_platea >= 8100)
        {
            Debug.Log("El festival fue un exito!!, se recaudaron " + res_total  + " de pesos en total. Con " + res_campo + " de pesos en el campo y " + res_platea + " de pesos en la platea. Quedaron " + (20400 - Entrada_campo) + "entradas libres en el campo y " + (16200 - Entrada_platea) + "entradas libres en la platea");
        }
        else if (Entrada_campo > 1 && Entrada_campo < 10200 && Entrada_platea > 1 && Entrada_platea < 8100)
        {
            Debug.Log("Debemos mejorar la convocatoria, solamente se recayudaron " + res_total +" de pesos. Con " + res_campo + " de pesos en el campo y " + res_platea + " de pesos en la platea. Quedaron " + (20400-Entrada_campo) + "entradas libres en el campo y " + (16200-Entrada_platea) + "entradas libres en la platea");
        }
        else if (Entrada_campo == 20400 && Entrada_platea == 16200)
        {
            Debug.Log("Todas las esntradas para el festival estan sold out. Se recayudaron " + res_total + " de pesos. Con " + res_campo + " de pesos en el campo y " + res_platea + " de pesos en la platea.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
