using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


	public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		transform.position = new Vector3 (player.transform.position.x +10, player.position.y+5, transform.position.z);
	}


}
