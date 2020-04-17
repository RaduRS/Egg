using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public bool keyPressedRight = false;
    public bool keyPressedLeft = false;

    private void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            keyPressedRight = true;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            keyPressedLeft = true;
        }
    }

    //adding force
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (keyPressedRight == true)
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
            keyPressedRight = false;
        }
        else if (keyPressedLeft == true)
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
            keyPressedLeft = false;
        }
    }
}