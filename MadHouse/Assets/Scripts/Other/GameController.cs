/* -----------------------------------------------------------------------------------
 * Class Name: GameController
 * -----------------------------------------------------------------------------------
 * Author: Michael Smith
 * Date: 
 * Credit: 
 * -----------------------------------------------------------------------------------
 * Purpose: 
 * -----------------------------------------------------------------------------------
 */

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public enum GameState { Paused, Active }

public class GameController : MonoBehaviour 
{
    #region Variables
    // ------------------------------------------------------------------------------
    // Public Variables
    // ------------------------------------------------------------------------------


    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    GameState gameState = GameState.Active;
    Dictionary<GameState, Action> gameStateMachine = new Dictionary<GameState, Action>();

    GameObject player;
    UIManager uIManager;

    #endregion

    #region Getters/Setters



    #endregion

    #region Constructors



    #endregion

    // ------------------------------------------------------------------------------
    // FUNCTIONS
    // ------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
    // ------------------------------------------------------------------------------

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tags.player);
        uIManager = FindObjectOfType<Canvas>().GetComponent<UIManager>();

        gameStateMachine.Add(GameState.Active, new Action(UnPauseGame));
        gameStateMachine.Add(GameState.Paused, new Action(PauseGame));

        SetGameState(GameState.Active);

    }

    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
    // ------------------------------------------------------------------------------

    private void Update()
    {
        gameStateMachine[gameState].Invoke();

    }

    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
    // ------------------------------------------------------------------------------

    public void SetGameState(GameState state)
    {
        gameState = state;

    }


    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
    // ------------------------------------------------------------------------------

    void UnPauseGame()
    {
        player.GetComponent<PlayerController>().enabled = true;
        player.GetComponent<CharacterMovement>().enabled = true;

        Time.timeScale = 1;

    }

    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
    // ------------------------------------------------------------------------------

    void PauseGame()
    {
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<CharacterMovement>().enabled = false;

        Time.timeScale = 0;

    }


    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
    // ------------------------------------------------------------------------------

} // End GameController