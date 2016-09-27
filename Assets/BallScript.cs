﻿using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
    float velx = -2, vely = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector3.left * Time.deltaTime * velx, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * vely, Space.World);
    }

    void OnTriggerEnter(Collider col)
    {
        print("Collision detected with trigger object " + col.name);

        if (col.name == "Left Paddle")
        {
            float deltaY = transform.position.y - col.transform.position.y;
            print(deltaY);
            velx = velx*-1.1f;
            vely = deltaY*deltaY * deltaY;
        }
        if (col.name == "Right Paddle")
        {
            float deltaY = transform.position.y - col.transform.position.y;
            print(deltaY);
            velx = velx*-1.1f;
            vely = deltaY * deltaY * deltaY;
        }
        if (col.name == "Top Wall"||col.name=="Bottom Wall")
        {
            vely = vely*-1;
        }
        //if (col.gameObject.name == "prop_powerCube")
    }
}