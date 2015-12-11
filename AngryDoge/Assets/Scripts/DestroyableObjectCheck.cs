using UnityEngine;
using System.Collections;

// Collision detection for destroyable objects
// Author: Jesus Flores-Padilla
public class DestroyableObjectCheck : MonoBehaviour
{
    public float forceThresh;

    public float ScoreOnDestruction; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision co)
    {
        var hittingObject = co.gameObject.GetComponent<Rigidbody>();

        if (hittingObject == null)
        {
            return;
        }

        float coForce;

        // Calculate "Collision force" by relativeV * ObjectMass
        coForce = co.relativeVelocity.magnitude * hittingObject.mass;

        // If force is less than set unit then destroy object, else nothing happens
        if (coForce > forceThresh)
        {
            GameDataManager.Instance.CurrentScore += ScoreOnDestruction;
            Destroy(gameObject);
        }

    }
}
