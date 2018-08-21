/* -----------------------------------------------------------------------------------
 * Class Name: LineOfSight
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

[RequireComponent(typeof(SphereCollider))]
public class LineOfSight : MonoBehaviour 
{
    #region Variables
    // ------------------------------------------------------------------------------
    // Public Variables
    // ------------------------------------------------------------------------------

    public float radius;
    public List<MeshRenderer> meshRenderers = new List<MeshRenderer>();

    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    SphereCollider sightRange;
    
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
        sightRange = GetComponent<SphereCollider>();
        sightRange.radius = radius;
        
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

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Interactable>() != null)
        {
            Debug.Log(other.name + " is nearby.");

            meshRenderers.Add(other.GetComponent<MeshRenderer>());

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

    private void OnTriggerStay(Collider other)
    {
        Ray ray = new Ray(transform.position, other.transform.position - transform.position);
        RaycastHit hit;

        if (other.GetComponent<Interactable>() != null)
        {
            if (Physics.Raycast(ray, out hit, radius))
            {
                Debug.DrawRay(transform.position, other.transform.position - transform.position);

                if (hit.transform.GetComponent<Interactable>() != null)
                {
                    if (!other.GetComponent<MeshRenderer>().enabled)
                    {
                        other.GetComponent<MeshRenderer>().enabled = true;

                    }
                }
            }

            else
            {
                if (other.GetComponent<MeshRenderer>().enabled)
                {
                    other.GetComponent<MeshRenderer>().enabled = false;

                }

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

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Interactable>() != null)
        {
            MeshRenderer renderer = other.GetComponent<MeshRenderer>();

            if (meshRenderers.Contains(renderer))
            {
                Debug.Log(other.name + " is no longer in range.");

                renderer.enabled = false;
                meshRenderers.Remove(renderer);

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

    public void UpdateSightRange()
    {
        sightRange.radius = radius;

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

} // End LineOfSight