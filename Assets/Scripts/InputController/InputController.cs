using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// Clase que gestiona las entradas de dos jugadores (Player1 y Player2)
public class InputController : MonoBehaviour
{
    // Referencias a los componentes PlayerInput de los dos jugadores
    public PlayerInput player1Input;
    public PlayerInput player2Input;

    // Método Start, llamado al inicio del juego
    private void Start()
    {
        // Activa el Action Map del primer jugador y desactiva el del segundo por defecto
        EnablePlayer1Input();
    }

    // Método para habilitar la entrada del primer jugador
    public void EnablePlayer1Input()
    {
        if (player1Input != null && player2Input != null)
        {
            // Activa el Action Map "Player" para el primer jugador
            player1Input.actions.FindActionMap("Player")?.Enable();

            // Desactiva el Action Map "Player2" para el segundo jugador
            player2Input.actions.FindActionMap("Player2")?.Disable();

            // (Opcional) Descomentar para habilitar/inhabilitar los componentes PlayerInput directamente
            // player1Input.enabled = true;
            // player2Input.enabled = false;

            // Imprime un mensaje en la consola para confirmar que el input del primer jugador ha sido habilitado
            Debug.Log("E1 ENABLED");
        }
    }

    // Método para habilitar la entrada del segundo jugador
    public void EnablePlayer2Input()
    {
        if (player1Input != null && player2Input != null)
        {
            // Activa el Action Map "Player2" para el segundo jugador
            player2Input.actions.FindActionMap("Player2")?.Enable();

            // Desactiva el Action Map "Player" para el primer jugador
            player1Input.actions.FindActionMap("Player")?.Disable();

            // (Opcional) Descomentar para habilitar/inhabilitar los componentes PlayerInput directamente
            // player2Input.enabled = true;
            // player1Input.enabled = false;

            // Imprime un mensaje en la consola para confirmar que el input del segundo jugador ha sido habilitado
            Debug.Log("E2 ENABLED");
        }
    }
}
