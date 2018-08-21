/* -----------------------------------------------------------------------------------
 * Class Name: Item
 * -----------------------------------------------------------------------------------
 * Author: Michael Smith
 * Date: 
 * Credit: 
 * -----------------------------------------------------------------------------------
 * Purpose: 
 * -----------------------------------------------------------------------------------
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour
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



    #endregion

    #region Getters/Setters

    public string Title { get; protected set; }
    public float Weight { get; protected set; }
    public int Cost { get; protected set; }
    public Sprite Image { get; protected set; }
    public string Description { get; protected set; }
    public bool IsStackable { get; protected set; }

    #endregion

    #region Constructors

    public Item()
    {
        Title = "Base item";
        Weight = 1f;
        Cost = 1;
        Image = null;
        Description = "This is a " + Title + ".";
        IsStackable = true;

    }

    public Item (string title, float weight, int cost, bool isStackable, string description)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = null;
        Description = description;
        IsStackable = isStackable;

    }

    public Item(string title, float weight, int cost, bool isStackable, Sprite image, string description)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = image;
        Description = description;
        IsStackable = isStackable;

    }

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


} // End Item