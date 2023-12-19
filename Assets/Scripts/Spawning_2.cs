using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_2 : MonoBehaviour
{



    public GameObject block2;



    // Start is called before the first frame update
    void Start()
    {

        //random y
        for (int y = 0; y <= 3; y++)
        {

            //random x
            for (int x = -14; x >= -19; x--)
            {
                Vector3 pos = new Vector3(x, y, -14);
                Instantiate(block2, pos, transform.rotation);
            }
        }

    }


}