/* -----------------------------------------------------------------------------------
 * Class Name: Attributes
 * -----------------------------------------------------------------------------------
 * Author: Michael Smith
 * Date: 
 * Credit: 
 * -----------------------------------------------------------------------------------
 * Purpose: 
 * -----------------------------------------------------------------------------------
 */

using UnityEngine;

public class Attributes
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

    float strength, dexterity, agility, speed, perception, intelligence, constitution;
    float strMod, dexMod, agiMod, spdMod, pcnMod, intMod, conMod;

    #endregion

    #region Getters/Setters

    public float Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public float Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public float Agility
    {
        get { return agility; }
        set { agility = value; }
    }

    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public float Perception
    {
        get { return perception; }
        set { perception = value; }
    }

    public float Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public float Constitution
    {
        get { return constitution; }
        set { constitution = value; }
    }

    public float StrMod
    {
        get { return strMod; }
    }

    public float DexMod
    {
        get { return dexMod; }
    }

    public float AgiMod
    {
        get { return agiMod; }
    }

    public float SpdMod
    {
        get { return spdMod; }
    }

    public float PcnMod
    {
        get { return pcnMod; }
    }

    public float IntMod
    {
        get { return intMod; }
    }

    public float ConMod
    {
        get { return conMod; }
    }

    #endregion

    #region Constructors

    public Attributes (float Str, float Dex, float Agi, float Spd, float Pcn, float Int, float Con)
    {
        strength = Str;
        dexterity = Dex;
        agility = Agi;
        speed = Spd;
        perception = Pcn;
        intelligence = Int;
        constitution = Con;

        strMod = Mathf.FloorToInt((strength - 10) / 2);
        dexMod = Mathf.FloorToInt((dexterity - 10) / 2);
        agiMod = Mathf.FloorToInt((agility - 10) / 2);
        spdMod = Mathf.FloorToInt((speed - 10) / 2);
        pcnMod = Mathf.FloorToInt((perception - 10) / 2);
        intMod = Mathf.FloorToInt((intelligence - 10) / 2);
        conMod = Mathf.FloorToInt((constitution - 10) / 2);

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


} // End Attributes