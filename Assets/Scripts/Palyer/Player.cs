
using System;
using UnityEngine;
using UnityEngine.InputSystem;

// Clase que representa al jugador y controla su movimiento en el juego
public class Player : MonoBehaviour
{
    // Referencia al componente Rigidbody, que se usa para aplicar físicas al jugador
    private Rigidbody rb;

    // Fuerza del salto y velocidad de movimiento del jugador
    private float fuerzaSalto = 200f;
    private float velocidad = 10f;

    // Referencia al sistema de entrada del jugador
    public PlayerInput _playerInput;

    // Variable para almacenar los valores de entrada del jugador (dirección de movimiento)
    private Vector2 input;

    // Método Start se llama una vez al inicio del juego
    void Start()
    {
        // Asigna el componente Rigidbody del GameObject a la variable `rb`
        rb = GetComponent<Rigidbody>();

        // Descomenta la línea siguiente si deseas asignar el componente PlayerInput en tiempo de ejecución
        // _playerInput = GetComponent<PlayerInput>();
    }

    // Método Update se llama una vez por fotograma
    void Update()
    {
        // Lee el valor de entrada del jugador del mapa de acciones, usa la acción "Move"
        input = _playerInput.actions["Move"].ReadValue<Vector2>();

        // Descomenta para depurar y ver los valores de entrada en la consola
        // Debug.Log(input);
    }

    // Método FixedUpdate se llama en intervalos fijos de tiempo para cálculos físicos
    private void FixedUpdate()
    {
        // Aplica una fuerza en la dirección de entrada del jugador (X y Z) multiplicada por la velocidad
        rb.AddForce(new Vector3(input.x, 0, input.y) * velocidad);
    }

    // Método para controlar el salto del jugador cuando se activa la acción Jump
    public void Jump(InputAction.CallbackContext callbackContext)
    {
        // Comprueba si la acción de salto ha sido realizada
        if (callbackContext.performed)
        {
            // Aplica una fuerza hacia arriba (salto) en el Rigidbody del jugador
            rb.AddForce(Vector3.up * fuerzaSalto);

            // Imprime un mensaje de depuración en la consola para confirmar el salto
            Debug.Log("Salto");
        }

        // Imprime el estado actual de la fase del contexto de la acción en la consola
        Debug.Log(callbackContext.phase);
    }
}
