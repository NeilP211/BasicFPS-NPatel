using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyedwhenshot : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "projectile")
            Destroy(gameObject);
    }
}
        
