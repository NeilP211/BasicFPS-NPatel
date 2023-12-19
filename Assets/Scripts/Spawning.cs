using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{


    public GameObject block;



    // Start is called before the first frame update
    void Start()
    {

        //random y
        for (int y = 0; y <= 3; y++)
        {

            //random x
            for (int x = -9; x >= -19; x--)
            {
                Vector3 pos = new Vector3(x, y, 7);
                Instantiate(block, pos, transform.rotation);
            }
        }

    }

    
}
