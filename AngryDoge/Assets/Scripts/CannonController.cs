using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CannonController : MonoBehaviour {
    public float rotationMultiplier;

    public float upLimit;
    public float downLimit;
    public float rightLimit;
    public float leftLimit;

    public GameObject CannonChild;
    public GameObject DogeFiringPoint;

    public GameObject DogePrefab;
    public GameObject DogeParent;

    public ParticleSystem FireParticles;
    public AudioSource CannonSound;

    public float MaxCannonPower;
    public Slider PowerSlider;

    private float upDownRotation = 15.0f;
    private float leftRightRotation = 0.0f;

    private bool upPressed = false;
    private bool downPressed = false;
    private bool leftPressed = false;
    private bool rightPressed = false;

    void FixedUpdate()
    {
        if(upPressed && upDownRotation < upLimit )
        {
            CannonChild.transform.Rotate(Vector3.left * rotationMultiplier);
            upDownRotation += rotationMultiplier;
        }

        if(downPressed && upDownRotation > downLimit)
        {
            CannonChild.transform.Rotate(Vector3.right * rotationMultiplier);
            upDownRotation -= rotationMultiplier;
        }

        if(leftPressed && leftRightRotation > leftLimit)
        {
            transform.Rotate(Vector3.down * rotationMultiplier);
            leftRightRotation -= rotationMultiplier;
        }

        if(rightPressed && leftRightRotation < rightLimit)
        {
            transform.Rotate(Vector3.up * rotationMultiplier);
            leftRightRotation += rotationMultiplier;

            // Debug.Log(rightRotation);
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
        var newDoge = Instantiate(DogePrefab, DogeFiringPoint.transform.position, transform.rotation) as GameObject;
        newDoge.transform.SetParent(DogeParent.transform, true);
        newDoge.GetComponent<Rigidbody>().AddForce(CannonChild.transform.forward.normalized * MaxCannonPower * PowerSlider.value, 
            ForceMode.Impulse);

        FireParticles.Play();
        CannonSound.Play();

    }
}
