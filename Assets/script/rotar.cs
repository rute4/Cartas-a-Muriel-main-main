using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour
{
    public float velocidadRotar = 10f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotar alrededor del eje Y
        transform.Rotate(0, velocidadRotar * Time.deltaTime, 0);
    }
}