/* -----------------------------------------------------------------------------------
 * Class Name: FogOfWar
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

public class FogOfWar : MonoBehaviour 
{
    #region Variables
    // ------------------------------------------------------------------------------
    // Public Variables
    // ------------------------------------------------------------------------------

    public GameObject fogOfWarPlane;
    public Transform player;
    public LayerMask fogOfWarLayer;
    public float fogRadius;
    public float presetAlpha;
    public float minThreshold;

    // ------------------------------------------------------------------------------
    // Protected Variables
    // ------------------------------------------------------------------------------



    // ------------------------------------------------------------------------------
    // Private Variables
    // ------------------------------------------------------------------------------

    float RadiusSquared { get { return Mathf.Pow(fogRadius, 2); } }
    Mesh mesh;
    Vector3[] verts;
    Color[] colors;

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
        mesh = fogOfWarPlane.GetComponent<MeshFilter>().mesh;
        verts = mesh.vertices;
        colors = new Color[verts.Length];

        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = Color.black;

        }

        UpdateColors();

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
        Ray ray = new Ray(transform.position, player.position - transform.position);
        RaycastHit hit;

        Debug.DrawRay(transform.position, player.position - transform.position, Color.red);

        if (Physics.Raycast(ray, out hit, 100, fogOfWarLayer, QueryTriggerInteraction.Collide))
        {
            for (int i = 0; i < verts.Length; i++)
            {
                Vector3 vert = fogOfWarPlane.transform.TransformPoint(verts[i]);
                Vector3 compare = vert - hit.point;
                float dist = compare.sqrMagnitude;

                if (dist < RadiusSquared)
                {
                    //Vector3 testPoint = new Vector3(vert.x, player.position.y, vert.z);
                    //Ray testRay = new Ray(new Vector3(player.position.x, player.localScale.y, player.position.z), testPoint - player.position);
                    //RaycastHit raycastHit;

                    //Debug.DrawRay(new Vector3(player.position.x, player.localScale.y, player.position.z), testPoint - player.position, Color.green);

                    //if (!Physics.Raycast(testRay))
                    //{
                        float alpha = Mathf.Min(colors[i].a, dist / RadiusSquared);

                        if (alpha < minThreshold)
                        {
                            alpha = 0f;

                        }

                        colors[i].a = alpha;
                    //}
                }

                if (colors[i].a < presetAlpha)
                {
                    float alpha = Mathf.Min(dist / RadiusSquared, presetAlpha);

                    colors[i].a = alpha;

                }

            }

            UpdateColors();

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



    // ------------------------------------------------------------------------------
    // Function Name: 
    // Return types: 
    // Argument types: 
    // Author: 
    // Date: 
    // ------------------------------------------------------------------------------
    // Purpose: 
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

    void UpdateColors()
    {
        mesh.colors = colors;

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
} // End FogOfWar