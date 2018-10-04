using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaster : MonoBehaviour {


	public GameObject coinPrefab;

	public Transform player;

	public Player playerScript;
	private Vector3 nextCoinLocation; //Location of current coin
	private Vector3 currentCoinLocation; //Location of previous coin
	private int nextCoin; //Index of next coin to be added

	private GameObject[] coins; //Number of coins to be placed
	private int numCoins;


	void Awake(){

		nextCoin = 0; 
		numCoins = 100;
		coins = new GameObject[numCoins];

		nextCoinLocation = new Vector3 (50 - Random.Range(10,20), 2, Random.Range (-9, 9)); 
		currentCoinLocation = nextCoinLocation;

		playerScript = playerScript.GetComponent<Player>();
	}


	void Start(){

		SpawnNewCoin (); //Creates the first coin



	}
	// Update is called once per frame
	void Update () {


		//If the player is some random amount past the coin
		if (player.transform.position.x <= currentCoinLocation.x - Random.Range(10,15)) {
			currentCoinLocation = nextCoinLocation;
			SpawnNewCoin ();

		}

		//nextCoin-1 corresponds to the current coin we're dealing with

		//If the current coin is close enough to the player
		if(coins[nextCoin-1] !=null && Mathf.Abs(player.transform.position.x - coins[nextCoin-1].transform.position.x) <=1 && Mathf.Abs(player.transform.position.z- coins[nextCoin-1].transform.position.z) <=2){
			Destroy (coins [nextCoin-1]);

			playerScript.addCoin ();






		}

	}


	void SpawnNewCoin(){

		coins[nextCoin] = (GameObject) Instantiate (coinPrefab, nextCoinLocation, Quaternion.LookRotation(new Vector3(0,90,0)));

		if (nextCoin > 0) {
			Destroy (coins [nextCoin - 1]); //Destroys previous coin
		}

		nextCoinLocation = new Vector3 (currentCoinLocation.x - Random.Range (80, 120), nextCoinLocation.y, Random.Range(-9,9)); //Stores the location of the next coin
		nextCoin++; 

	}
}
