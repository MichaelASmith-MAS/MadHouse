/* -----------------------------------------------------------------------------------
 * Class Name: Armor
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

public class Armor : Item 
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

    public float MaxDamageReduction { get; protected set; }
    public float CurrDamageReduction { get; protected set; }
    public float CurrentIntegrity { get; protected set; }
    public float MaxIntegrity { get; protected set; }

    #endregion

    #region Constructors

    public Armor()
    {
        Title = "Base armor";
        Weight = 1f;
        Cost = 1;
        Image = null;
        Description = "This is a " + Title + ".";
        IsStackable = false;
        MaxDamageReduction = 2;
        CurrDamageReduction = MaxDamageReduction;
        MaxIntegrity = 10;
        CurrentIntegrity = MaxIntegrity;

    }

    public Armor(string title, float weight, int cost, string description, float maxDamageReduction, float maxIntegrity)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = null;
        Description = description;
        IsStackable = false;
        MaxDamageReduction = maxDamageReduction;
        CurrDamageReduction = MaxDamageReduction;
        MaxIntegrity = maxIntegrity;
        CurrentIntegrity = MaxIntegrity;

    }

    public Armor(string title, float weight, int cost, Sprite image, string description, float maxDamageReduction, float maxIntegrity)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = image;
        Description = description;
        IsStackable = false;
        MaxDamageReduction = maxDamageReduction;
        CurrDamageReduction = MaxDamageReduction;
        MaxIntegrity = maxIntegrity;
        CurrentIntegrity = MaxIntegrity;

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

    public void ChangeIntegrity(float value)
    {
        CurrentIntegrity = Mathf.Clamp(CurrentIntegrity + value, 0, MaxIntegrity);

        CurrDamageReduction = MaxDamageReduction * (CurrentIntegrity / MaxIntegrity);

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

} // End Armor