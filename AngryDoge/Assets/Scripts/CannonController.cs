using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CannonController : MonoBehaviour {
    public float rotationMultiplier;

    public float upLimit = 45.0f;
    public float downLimit = 0.0f;
    public float rightLimit = 45.0f;
    public float leftLimit = 45.0f;

    public GameObject DogePrefab;
    public GameObject DogeParent;

    public float MaxCannonPower;
    public Slider PowerSlider;

    private float upRotation = 15.0f;
    private float downRotation = 0.0f;
    private float rightRotation = 0.0f;
    private float leftRotation = 0.0f;

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
        if(upPressed && transform.rotation.eulerAngles.y < upLimit )
        {
            transform.Rotate(Vector3.right * rotationMultiplier);
        }

        if(downPressed && leftRotation < downLimit)
        {
            transform.Rotate(Vector3.left * rotationMultiplier);
        }

        if(leftPressed && leftRotation < leftLimit)
        {
            transform.Rotate(Vector3.down * rotationMultiplier);
            leftRotation += Vector3.down.y * rotationMultiplier;
            rightRotation -= Vector3.down.y * rotationMultiplier;
        }

        if(rightPressed && rightRotation < rightLimit)
        {
            transform.Rotate(Vector3.up * rotationMultiplier);
            rightRotation += Vector3.up.y * rotationMultiplier;
            leftRotation -= Vector3.up.y * rotationMultiplier;

            Debug.Log(rightRotation);
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

    public void FireCannon()
    {
        var newDoge = Instantiate(DogePrefab, transform.position, transform.rotation) as GameObject;
        newDoge.transform.SetParent(DogeParent.transform, true);
        newDoge.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * MaxCannonPower * PowerSlider.value, 
            ForceMode.Impulse);
    }
}
