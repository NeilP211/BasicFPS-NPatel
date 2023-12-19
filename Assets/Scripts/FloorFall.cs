using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorFall : MonoBehaviour
{
    public GameObject[] LastCube; 
    public Rigidbody rb;
    public Image Youwin;

    // Start is called before the first frame update
    void Start()
    {
        LastCube = GameObject.FindGameObjectsWithTag("LastRoomCube");
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        Youwin.enabled = false;
         
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        LastCube = GameObject.FindGameObjectsWithTag("LastRoomCube");
        if (LastCube.Length == 0)
        {
            rb.isKinematic = false;
            Youwin.enabled = true;
        }




    }
}
