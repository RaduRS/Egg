using UnityEngine;

public class ObsMove : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;



    //adding force
    private void FixedUpdate()
    {

        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);

    }
}