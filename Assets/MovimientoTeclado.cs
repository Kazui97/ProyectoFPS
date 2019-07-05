using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTeclado : MonoBehaviour
{
    
   
    private float Velocidad = 0.3f;                         //creamos una variable float con el nombre de velocidad
    float mouseX;                                           //creamos la variable mousex para utilizarla de manera de cuando se mire ala derecha este camine ala derecha
    private float supervelocidad = 1.5f;                    // tiene casi la misma funcion de que tiene el de la velocidad
    private float salto = 10f;
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X"); // esto es para cuando el mouse gire en la posicion x nosotros camines en esa direcion


        if (Input.GetKey(KeyCode.W))                            // se asigna las letras con le que caminaremos 
        {
            transform.position += transform.forward * Velocidad; //aqui se llama la variable de velocidad que teniamos 
        }
        if (Input.GetKey(KeyCode.S))                                // se asigna las letras con le que caminaremos 
        {
            transform.position -= transform.forward * Velocidad;       // aqui se vuelve a llamar la variable que teniamos  
        }
        if (Input.GetKey(KeyCode.A))                                    // se asigna las letras con le que caminaremos 
        {
            transform.position -= transform.right * Velocidad;           //de igual forma se llama la variable que tiene la velocidad   
        }
        if (Input.GetKey(KeyCode.D))                            // se asigna las letras con le que caminaremos 
        {
            transform.position += transform.right * Velocidad;  //se llama la variable que se tiene en la demas variables

        }
        if (Input.GetKey(KeyCode.LeftShift))                    // se asigna las letras con le que caminaremos a mayor velocidad
        {
            transform.position += transform.forward * supervelocidad; // en este cree otra variable con el nombre de supervelocidad para asi cuando oprimimos la letra este camine mas rapido
        }
        if (Input.GetKey(KeyCode.Space))                    // esta variable es para programar un salto aun que esta incompleto :,v
        {
            transform.position += transform.up * salto;
        }

        transform.eulerAngles = new Vector3(0, mouseX, 0); // este esta asosiado a la union que tiene el otro codigo este funciona para el movimiento de la camara
    }


}
