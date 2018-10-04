using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


	private float angleSpeed;



	void Awake(){

		angleSpeed = 120f;

	}





	// Update is called once per frame
	void Update () {

		transform.Rotate(new Vector3(0,angleSpeed * Time.deltaTime,0),Space.World);






	}



}
