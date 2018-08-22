/* -----------------------------------------------------------------------------------
 * Class Name: Combat
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

public class Combat : Interactable 
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

    float attackSpeed = 0;
    float reloadSpeed = 0;
    float currentTimer = 0;
    bool isReloading = false;

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

    protected override void Update()
    {
        base.Update();

        // Check for weapon type. If ranged, verify ammo. Call reload function as necessary.
        // Use currentTimer for reload. else if on attack.

        if (player != null)
        {
            Inventory inventory = player.GetComponent<Inventory>();

            if (attackSpeed <= currentTimer && !isReloading)
            {
                hasInteracted = false;
                currentTimer = 0f;

            }
            else
            {
                currentTimer += Time.deltaTime;

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

    public override void Interact()
    {
        base.Interact();

        Inventory inventory = player.GetComponent<Inventory>();

        //Weapon enemyWeapon = inventory.equippedWeapon.CurrentWeapon;
        //Armor armor = GetComponent<Inventory>().equippedArmor.CurrentArmor;

        //if (inventory.equippedWeapon.CurrentWeapon.WeaponType == WeaponType.Melee)
        //{
        //    if (player.tag == Tags.player)
        //    {
        //        float hit = Random.Range(1, 20) + player.GetComponent<PlayerController>().attributes.DexMod;

        //        if (hit > GetComponent<AIController>().attributes.Agility)
        //        {
        //            float damage = Mathf.Max(Random.Range(1, enemyWeapon.Damage) + GetComponent<AIController>().attributes.StrMod, 0);

        //            float tmp = -damage;

        //            damage = Mathf.Clamp(damage - armor.CurrDamageReduction, 0, damage);
        //            GetComponent<AIController>().health.ChangeHealth(-damage, null);
                    
        //            if (damage > 0)
        //            {
        //                armor.ChangeIntegrity(armor.MaxDamageReduction);

        //            }
        //            else
        //            {
        //                armor.ChangeIntegrity(tmp);

        //            }

        //        }

        //    }

        //    else
        //    {
        //        if (gameObject.tag == Tags.player)
        //        {
        //            float hit = Random.Range(1, 20) + player.GetComponent<AIController>().attributes.DexMod;

        //            if (hit > GetComponent<PlayerController>().attributes.Agility)
        //            {


        //            }
        //        }
        //        else
        //        {
        //            float hit = Random.Range(1, 20) + player.GetComponent<AIController>().attributes.DexMod;

        //            if (hit > GetComponent<AIController>().attributes.Agility)
        //            {


        //            }

        //        }

        //    }

        //}
        //else
        //{
        //    if (player.tag == Tags.player)
        //    {
        //        float hit = Random.Range(1, 20) + player.GetComponent<PlayerController>().attributes.PcnMod;

        //        if (hit > GetComponent<AIController>().attributes.Agility)
        //        {


        //        }

        //    }

        //    else
        //    {
        //        if (gameObject.tag == Tags.player)
        //        {
        //            float hit = Random.Range(1, 20) + player.GetComponent<AIController>().attributes.PcnMod;

        //            if (hit > GetComponent<PlayerController>().attributes.Agility)
        //            {


        //            }
        //        }
        //        else
        //        {
        //            float hit = Random.Range(1, 20) + player.GetComponent<AIController>().attributes.PcnMod;

        //            if (hit > GetComponent<AIController>().attributes.Agility)
        //            {


        //            }

        //        }

        //    }
        //}

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

    public override void OnFocused(Transform playerTransform)
    {
        base.OnFocused(playerTransform);

        Inventory inventory = player.GetComponent<Inventory>();

        //radius = inventory.equippedWeapon.CurrentWeapon.Range;

        //if (inventory.equippedWeapon.CurrentWeapon.WeaponType == WeaponType.Melee)
        //{
        //    if (player.tag == Tags.player)
        //    {
        //        attackSpeed = 5 - player.GetComponent<PlayerController>().attributes.SpdMod;

        //    }

        //    else
        //    {
        //        attackSpeed = 5 - player.GetComponent<AIController>().attributes.SpdMod;

        //    }

        //}

        //else
        //{
        //    attackSpeed = inventory.equippedWeapon.CurrentWeapon.AttackSpeed;

        //}

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

} // End Combat