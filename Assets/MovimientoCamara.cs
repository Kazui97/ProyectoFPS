using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{

    void Start()
    {
        // transform.eulerAngles = new Vector3(30, 0, 0);
    }

    float mouseX;                                    //asignamos la variable de mousex y mousey como float
    float mouseY;                                    
    public bool InvertiVista;                         //esta variable es para la inversion de la camara
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");           // aqui se asigna en como trabajara el mouse
        if (InvertiVista)                               // aqui se trabaja la vista invertida
        {
            mouseY += Input.GetAxis("Mouse Y");         // la vista se invertira si activamos este bool
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);         //aqui se le asigna cuales son los eje que vamos atrabajar el mouse para limitarle el movimiento
        if (mouseY >= 45f)                                      // aqui se asigna el limite de la camara cuando este llegue a tal numero no se movera mas
        {
            mouseY = 45f;
        }
        if (mouseY <= -45f)
        {
            mouseY = -45;
        }
    }
}
