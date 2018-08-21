/* -----------------------------------------------------------------------------------
 * Class Name: Experience
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

public class Experience
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

    float lastExperience, currentExperience;
    Attributes attributes;
    int level;

    #endregion

    #region Getters/Setters

    public float CurrentExperience
    {
        get { return currentExperience; }
    }

    public int Level
    {
        get { return level; }
    }

    #endregion

    #region Constructors

    public Experience(Attributes attributes)
    {
        lastExperience = 0;
        level = 1;
        currentExperience = lastExperience;
        this.attributes = attributes;

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

    public void AddExperience (float value)
    {
        currentExperience += value + Mathf.Floor(((attributes.IntMod / 2) * value) / 2);

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

    public bool SaveExperience()
    {
        if (lastExperience <= currentExperience)
        {
            lastExperience = currentExperience;

            return true;
        }

        else
        {
            return false;
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

    public void ResetExperience ()
    {
        currentExperience = lastExperience;

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

} // End Experience