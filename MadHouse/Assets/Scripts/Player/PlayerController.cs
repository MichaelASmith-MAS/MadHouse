/* -----------------------------------------------------------------------------------
 * Class Name: PlayerController
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


[RequireComponent(typeof(CharacterMovement))]
public class PlayerController : MonoBehaviour 
{
    #region Variables
    // ------------------------------------------------------------------------------
    // Public Variables
    // ------------------------------------------------------------------------------

    public LayerMask groundMask, sightMask;
    public Interactable currentFocus;
    public int strength = 8, dexterity = 8, agility = 10, speed = 8, perception = 10, intelligence = 8, constitution = 10;
    public Attributes attributes;
    public Health health;
    public Inventory inventory;

    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    Camera cam;
    CharacterMovement characterController;
    Experience experience;
    FogOfWar fog;
    LineOfSight sight;

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

    private void Awake()
    {
        cam = Camera.main;
        fog = cam.GetComponent<FogOfWar>();
        characterController = GetComponent<CharacterMovement>();

        attributes = new Attributes(strength, dexterity, agility, speed, perception, intelligence, constitution);
        health = new Health(attributes);
        experience = new Experience(attributes);

        sight = GetComponentInChildren<SphereCollider>().GetComponent<LineOfSight>();

        fog.fogRadius = attributes.Perception * 1.75f;

        sight.radius = attributes.Perception;

        characterController.characterSpeed = attributes.SpdMod + 4f;

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
        if (Input.GetMouseButtonDown(0))
        {
            MouseControl();

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

    void MouseControl ()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, groundMask))
        {
            Debug.Log("Object hit: " + hit.collider.name + " at " + hit.point);

            RemoveFocus();

            characterController.MoveToPoint(hit.point);

        }

        if (Physics.Raycast(ray, out hit, 100, sightMask))
        {
            Debug.Log("Object focused: " + hit.collider.name + " at " + hit.point);

            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                SetFocus(interactable);

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

    void SetFocus (Interactable newFocus)
    {
        if (newFocus != currentFocus)
        {
            if (currentFocus != null)
            {
                currentFocus.OnDefocused();
            }

            currentFocus = newFocus;
            newFocus.OnFocused(transform);
        }

        characterController.FollowTarget(newFocus);

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

    void RemoveFocus ()
    {

        if (currentFocus != null)
        {
            currentFocus.OnDefocused();
        }

        currentFocus = null;
        characterController.StopFollowingTarget();

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

} // End PlayerController