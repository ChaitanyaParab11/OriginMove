using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 100f;
    public float sidewaysforce = 100f;

    public void FixedUpdate ()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0 ,0 , -forwardforce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
