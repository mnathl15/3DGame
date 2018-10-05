using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {


	public Player playerScript;

	void Awake () {

		playerScript = playerScript.GetComponent<Player> ();

	}
	
	// Update is called once per frame
	void Update () {

		this.transform.GetChild (0).GetComponent<Text>().text = playerScript.getCoins().ToString();




	}



	void OnMouseOver(){
		Debug.Log ("ONNNNNNNN");

	}
}
