using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deQueOrientacionSos : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string especialidadAlumno;


    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Porfavor ingrese un nombre.");
            return;
        }

        if (añoAlumno < 1 || añoAlumno > 5)
        {
            Debug.Log("Porfavor ingrese un año valido.");
            return;
        }

        if (añoAlumno < 3 || añoAlumno > 5)
        {
            Debug.Log("Error. Aún estás en el ciclo básico.");
            return;
        }

        if (especialidadAlumno == "T" || especialidadAlumno == "D" || especialidadAlumno == "G" || especialidadAlumno == "M" || especialidadAlumno == "H")
        {
            Debug.Log("Muchas gracias "+ nombreAlumno + "!");
            return;
        }

        else
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H como tu especialidad.");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
