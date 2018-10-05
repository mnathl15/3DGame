using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {



	private int coins; //How many coins the player has received

	private float force;
	private float torque; //angular speed 
	public Rigidbody rb;
	public GameObject mainMenu;
	public StartMenu startMenu;


	// Use this for initialization
	void Start () {

		 
		startMenu = startMenu.GetComponent<StartMenu>();

		coins = 0;
		force = 3f;
		torque = 3f;

	}



	void FixedUpdate(){

		if (!startMenu.isPlaying()) {

			return;
		}



		if (transform.position.y <= -3) {
			mainMenu.transform.GetChild (1).GetComponent<UnityEngine.UI.Text> ().text = "Game Over";
			startMenu.setPlaying (false);
			StartCoroutine (Reset ());

		}

		if (Input.GetKey(KeyCode.W)) {
			rb.AddForce (Vector3.left * force );
			rb.AddTorque(new Vector3(0,0,torque));

		}

		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (-Vector3.forward * force );
			rb.AddTorque(-new Vector3(torque,0,0));

		}
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector3.forward * force );
			rb.AddTorque(new Vector3(torque,0,0));

		}

	}



	public void addCoin(){
		coins++;
	}

	public int getCoins(){

		return coins;
	}

	IEnumerator Reset(){

		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex) ;

	}



}
