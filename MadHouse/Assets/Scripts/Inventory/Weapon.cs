/* -----------------------------------------------------------------------------------
 * Class Name: Weapon
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

public class Weapon : Item 
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

    public WeaponType WeaponType { get; protected set; }
    public float Range { get; protected set; }
    public float Damage { get; protected set; }
    public float AttackSpeed { get; protected set; }
    public int MaxAmmo { get; protected set; }
    public int CurrentAmmo { get; protected set; }

    #endregion

    #region Constructors

    public Weapon()
    {
        Title = "Base item";
        Weight = 1f;
        Cost = 1;
        Image = null;
        Description = "This is a " + Title + ".";
        IsStackable = false;
        WeaponType = WeaponType.Melee;
        Range = 3f;
        Damage = 4;
        AttackSpeed = 2f;
        MaxAmmo = 10;
        CurrentAmmo = 0;

    }

    public Weapon(string title, float weight, int cost, string description, WeaponType weaponType, float range, float damage)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = null;
        Description = description;
        IsStackable = false;
        WeaponType = weaponType;
        Range = range;
        Damage = damage;
        AttackSpeed = 2f;
        MaxAmmo = 10;
        CurrentAmmo = 0;

    }

    public Weapon(string title, float weight, int cost, string description, WeaponType weaponType, float range, float damage, float attackSpeed, int maxAmmo)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = null;
        Description = description;
        IsStackable = false;
        WeaponType = weaponType;
        Range = range;
        Damage = damage;
        AttackSpeed = attackSpeed;
        MaxAmmo = maxAmmo;
        CurrentAmmo = 0;

    }

    public Weapon(string title, float weight, int cost, Sprite image, string description, WeaponType weaponType, float range, float damage)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = image;
        Description = description;
        IsStackable = false;
        WeaponType = weaponType;
        Range = range;
        Damage = damage;
        AttackSpeed = 2f;
        MaxAmmo = 10;
        CurrentAmmo = 0;

    }

    public Weapon(string title, float weight, int cost, Sprite image, string description, WeaponType weaponType, float range, float damage, float attackSpeed, int maxAmmo)
    {
        Title = title;
        Weight = weight;
        Cost = cost;
        Image = image;
        Description = description;
        IsStackable = false;
        WeaponType = weaponType;
        Range = range;
        Damage = damage;
        AttackSpeed = attackSpeed;
        MaxAmmo = maxAmmo;
        CurrentAmmo = 0;

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

    public void Reload (Inventory inventory)
    {


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

} // End Weapon