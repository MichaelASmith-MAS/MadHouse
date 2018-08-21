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

    public Weapon defaultWeapon;
    public Armor defaultArmor;

    public WeaponSlot equippedWeapon;
    public ArmorSlot equippedArmor;

    public int rows = 5, columns = 5;
    public Slot[,] slots;

    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    public GameObject player;
    GameObject gameController;
    Tags tags;

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

        maxWeightText.text = (player.GetComponent<PlayerController>().attributes.Strength * 15).ToString() + maxWeightText.text;

        slots = new Slot[rows, columns];

        for (int y = 0; y < columns; y++)
        {
            for (int x = 0; x < rows; x++)
            {
                slots[x, y] = new Slot();

            }

        }

        equippedArmor = new ArmorSlot();
        equippedWeapon = new WeaponSlot();

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