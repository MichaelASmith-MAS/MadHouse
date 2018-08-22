/* -----------------------------------------------------------------------------------
 * Class Name: Inventory
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
using System.Collections;
using System.Collections.Generic;

public enum ItemType { Any, Weapon, Armor, Consumable }
public enum WeaponType { Melee, Ranged }

public class Inventory : MonoBehaviour 
{
    #region Variables
    // ------------------------------------------------------------------------------
    // Public Variables
    // ------------------------------------------------------------------------------

    public Text maxWeightText, currentWeightText;

    public int slotCount = 20;

    public GameObject slotPanel, equippedPanel;

    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    GameObject player;
    GameObject gameController;
    Tags tags;

    Slot[] slots;

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
        player = gameObject;

        slots = new Slot[slotCount];

        maxWeightText.text = (player.GetComponent<PlayerController>().attributes.Strength * 15).ToString() + maxWeightText.text;

        for (int i = 0; i < slotCount; i++)
        {
            GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/Slot"), slotPanel.transform);

            slots[i] = go.GetComponent<Slot>();

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

} // End Inventory