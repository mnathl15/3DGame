using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {



	public Transform player;
	public Transform marker;
	public Transform spawn;
	public Transform pivot;
	public GameObject basicRunwayPrefab; //Prefab for simple linear runway
	public GameObject[] runways;

	private int numOfRunways; //Number of floors to be added
	private int currentRunway; //Current runway player is on
	private float runwayEnd; //End position of current runway



	// Use this for initialization
	void Start () {


	

		//0th runway corresponds to the first one spawned after the initial runway
		currentRunway = 0;
		numOfRunways = 50; // 50 runways to be spawned;
		runways = new GameObject[numOfRunways];
		runwayEnd = spawn.transform.position.x;



		createBasicRunway ();

	}
	

	void Update () {
		//Debug.Log (player.transform.position.x);
		//If currentRunway is at last runway
		if (currentRunway >= numOfRunways-1) {
			Debug.Log ("GAME FINISHED");
			return;
		}


		//Made the game with positive axis facing away from movement

		//If the player is past the current runways marker
		if (player.transform.position.x <= runways[currentRunway].transform.GetChild(0).transform.position.x) {
			
			currentRunway++;

			int rand = Random.Range (0, 100);



		
			createBasicRunway ();



			//Destroy (runways[currentRunway-1]); //Destroys previous runway
		}

	}

	//Method for creating a new basic runway
	void createBasicRunway(){
		
		runways[currentRunway] = (GameObject) Instantiate (basicRunwayPrefab, new Vector3(runwayEnd,0,0), transform.rotation);
		runwayEnd = runways [currentRunway].transform.GetChild(1).transform.position.x; //Sets runwayEnd variable into location of current runway

	}


}
