using UnityEngine;
using System.Collections;

public class CannonController : MonoBehaviour {
    public float rotationMultiplier;

    // Use this for initialization
    void Start ()
    {
        rotationMultiplier = 2.0f;
	}

    public void rotateCannonUp()
    {
        transform.Rotate(Vector3.up * rotationMultiplier);
    }

    public void rotateCannonDown()
    {
        transform.Rotate(Vector3.down * rotationMultiplier);
    }

    public void rotateCannonLeft()
    {
        transform.Rotate(Vector3.left * rotationMultiplier);
    }

    public void rotateCannonRight()
    {
        transform.Rotate(Vector3.right * rotationMultiplier);
    }
}
