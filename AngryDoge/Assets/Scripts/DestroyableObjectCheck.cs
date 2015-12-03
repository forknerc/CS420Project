using UnityEngine;
using System.Collections;

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
        Debug.Log("Enter");
        Debug.Log(name + " Colliding with " + co.gameObject.name);

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
            Debug.Log("Above Threshold");
            GameDataManager.Instance.CurrentScore += ScoreOnDestruction;
            Destroy(gameObject);
        }

    }
}
