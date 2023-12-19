using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player_controller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;


    void Start()
    {
     

        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        

        rb.AddForce(transform.forward* speed * moveVertical);
        rb.AddForce(transform.right * speed * moveHorizontal);
    }
}
