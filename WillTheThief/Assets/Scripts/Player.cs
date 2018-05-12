using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            print("interact key was pressed");
        }

        if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            movement();
        }

    }





    void movement()
    {
        float vMove = ((int)(Input.GetKeyDown("w"))) * 1.0f + ((int)(Input.GetKeyDown("s"))) * -1.0f;
        float hMove = ((int)(Input.GetKeyDown("a"))) * -1.0f + ((int)(Input.GetKeyDown("d"))) * 1.0f;

        //playermovementvector = vector(playermovementvector.x+hMove, playermovementvector.y+vMove, playermovementvector.z);
    }
}
