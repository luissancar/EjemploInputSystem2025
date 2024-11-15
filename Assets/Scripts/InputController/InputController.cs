using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public PlayerInput player1Input;
    public PlayerInput player2Input;

    private void Start()
    {
        // Activa el Action Map del primer jugador y desactiva el del segundo por defecto
        EnablePlayer1Input();
    }

    public void EnablePlayer1Input()
    {
        if (player1Input != null && player2Input != null)
        {
            // Activa el mapa de acciones del primer jugador y desactiva el del segundo
            player1Input.actions.FindActionMap("Player")?.Enable();
            player2Input.actions.FindActionMap("Player2")?.Disable();
            //player1Input.enabled = true;
            //player2Input.enabled = false;
            Debug.Log("E1 ENABLED");
        }
    }

    public void EnablePlayer2Input()
    {
        if (player1Input != null && player2Input != null)
        {
            // Activa el mapa de acciones del segundo jugador y desactiva el del primero
            player2Input.actions.FindActionMap("Player2")?.Enable();
            player1Input.actions.FindActionMap("Player")?.Disable();
            //  player2Input.enabled = true;
            //player1Input.enabled = false;
            Debug.Log("E2 ENABLED");
        }
    }
}