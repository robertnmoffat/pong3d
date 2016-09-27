using UnityEngine;
using System.Collections;

public class RightPaddle : MonoBehaviour {
	float deltay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		updateDeltay ();
		transform.Translate(Vector3.up * Time.deltaTime*deltay, Space.World);
	}

	void updateDeltay(){
		var ball = GameObject.Find ("Ball");
		deltay = ball.transform.position.y-transform.position.y;
		print (deltay);
	}
}
