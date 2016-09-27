using UnityEngine;
using System.Collections;

public class LeftPaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("up")){
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
		if(Input.GetKey("down")){
			transform.Translate(Vector3.up * Time.deltaTime*-1, Space.World);
		}
	}
}
