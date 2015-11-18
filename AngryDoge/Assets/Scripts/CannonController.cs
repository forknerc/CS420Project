using UnityEngine;
using System.Collections;

public class CannonController : MonoBehaviour {
    public float rotationMultiplier;

    private bool upPressed = false;
    private bool downPressed = false;
    private bool leftPressed = false;
    private bool rightPressed = false;

    // Use this for initialization
    void Start ()
    {
        rotationMultiplier = 2.0f;
	}

    void FixedUpdate()
    {
        if(upPressed)
        {
            transform.Rotate(Vector3.up * rotationMultiplier);
        }
        if(downPressed)
        {
            transform.Rotate(Vector3.down * rotationMultiplier);
        }
        if(leftPressed)
        {
            transform.Rotate(Vector3.left * rotationMultiplier);
        }
        if(rightPressed)
        {
            transform.Rotate(Vector3.right * rotationMultiplier);
        }
    }

    public void rotateCannonUp()
    {
        upPressed = !upPressed;
    }

    public void rotateCannonDown()
    {
        downPressed = !downPressed;
    }

    public void rotateCannonLeft()
    {
        leftPressed = !leftPressed;
    }

    public void rotateCannonRight()
    {
        rightPressed = !rightPressed;
    }
}
