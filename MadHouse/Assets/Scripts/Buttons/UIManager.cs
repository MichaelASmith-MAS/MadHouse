/* -----------------------------------------------------------------------------------
 * Class Name: UIManager
 * -----------------------------------------------------------------------------------
 * Author: Michael Smith
 * Date: 
 * Credit: 
 * -----------------------------------------------------------------------------------
 * Purpose: 
 * -----------------------------------------------------------------------------------
 */

using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public enum Menus { None, Paused, Inventory, SkillTree, Options, Save, Load }
public enum MenuState { Open, Closed }
public enum OptionsMenus { Display, Controls, Audio, Gameplay }

public class UIManager : MonoBehaviour
{
    #region Variables
    // ------------------------------------------------------------------------------
    // Public Variables
    // ------------------------------------------------------------------------------

    [Header("Menu Panels")]
    public GameObject inventoryPanel;


    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    GameController gameController;

    Menus activeMenu = Menus.None;

    MenuState inventoryState = MenuState.Closed;
    Dictionary<MenuState, Action> inventoryStateMachine = new Dictionary<MenuState, Action>();

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
        gameController = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<GameController>();

        RegisterStates();

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
        SetActiveMenu();

        inventoryStateMachine[inventoryState].Invoke();

        KeyPressControls();

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

    void RegisterStates()
    {
        inventoryStateMachine.Add(MenuState.Closed, new Action(CloseInventory));
        inventoryStateMachine.Add(MenuState.Open, new Action(OpenInventory));

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

    void KeyPressControls()
    {
        if(activeMenu == Menus.None)
        {
            if(Input.GetKeyDown(KeyCode.I))
            {
                activeMenu = Menus.Inventory;

            }

            if(Input.GetKeyDown(KeyCode.Escape))
            {
                activeMenu = Menus.Paused;

            }

            if(Input.GetKeyDown(KeyCode.T))
            {
                activeMenu = Menus.SkillTree;

            }

        }

        else if(activeMenu == Menus.Inventory || activeMenu == Menus.Paused || activeMenu == Menus.SkillTree)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                activeMenu = Menus.None;

            }

        }

        else if(activeMenu == Menus.Options || activeMenu == Menus.Load || activeMenu == Menus.Save)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                activeMenu = Menus.Paused;

            }

        }

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

    void SetActiveMenu()
    {
        switch (activeMenu)
        {
            case Menus.None:
                inventoryState = MenuState.Closed;
                gameController.SetGameState(GameState.Active);
                break;
            case Menus.Paused:
                break;
            case Menus.Inventory:
                inventoryState = MenuState.Open;
                gameController.SetGameState(GameState.Paused);
                break;
            case Menus.SkillTree:
                break;
            case Menus.Options:
                break;
            case Menus.Save:
                break;
            case Menus.Load:
                break;
        }

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

    void CloseInventory()
    {
        inventoryPanel.SetActive(false);

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

    void OpenInventory()
    {
        inventoryPanel.SetActive(true);

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

} // End UIManager