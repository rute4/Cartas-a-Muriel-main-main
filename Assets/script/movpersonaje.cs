using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movpersonaje : MonoBehaviour
{
    public float velocidad = 5f;
    public float multiplicador = 5f;

    public static bool miraDerecha = true;

    private Rigidbody rb;
    private Animator animatorController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animatorController = GetComponent<Animator>();
    }

    void Update()
    {
       float movimientoVertical = Input.GetAxis("Horizontal"); // Se intercambia Horizontal por Vertical
       float movimientoHorizontal = Input.GetAxis("Vertical"); // Se intercambia Vertical por Horizontal

        // Invierte la dirección del movimiento vertical
        movimientoVertical *= -1f;

       Vector3 direccionMovimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical).normalized;
        // Mueve el personaje en la dirección calculada
        rb.MovePosition(transform.position + direccionMovimiento * velocidad * Time.deltaTime);

        // Rotación del personaje
        if (movimientoHorizontal < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            animatorController.SetBool("activaCamina", true);
            miraDerecha = false;
        }
        else if (movimientoHorizontal > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            animatorController.SetBool("activaCamina", true);
            miraDerecha = true;
        }
        else
        {
            animatorController.SetBool("activaCamina", false);
        }
        // Control de la animación
        if (direccionMovimiento.magnitude >= 0.1f) // Si el personaje se está moviendo
        {
            animatorController.SetBool("activaCamina", true); // Activa la animación de caminar
        }
        else // Si el personaje no se está moviendo
        {
            animatorController.SetBool("activaCamina", false); // Desactiva la animación de caminar
        }
    }
}
