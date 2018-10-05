using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMaster : MonoBehaviour {


	public GameObject enemy;
	public GameObject player;
	private GameObject[] enemies;

	public GameObject mainMenu;
	public StartMenu startMenu;

	private int currentEnemy;
	private int numEnemies;

	private Vector3 currentEnemyLocation;
	private Vector3 nextEnemyLocation;

	private int spawnRange; //How close enemies spawn next to each other

	private int currentLevel; //current level player is on


	void Awake(){


		currentLevel = 0;
		currentEnemy = 0;
		nextEnemyLocation = new Vector3 (player.transform.position.x - Random.Range (20, 40), 2, Random.Range (-5, 5));
		numEnemies = 200;
		enemies = new GameObject[numEnemies];




	}
	// Update is called once per frame
	void Update () {


		if (currentLevel == 0) {

			spawnRange = 50;
		}


		if (enemies[currentEnemy] !=null && (Mathf.Abs(enemies [currentEnemy].transform.position.x - player.transform.position.x) <= 4.0) && (Mathf.Abs(enemies [currentEnemy].transform.position.z - player.transform.position.z) <= 4.0)) {

			mainMenu.transform.GetChild (1).GetComponent<UnityEngine.UI.Text> ().text = "Game Over";
			startMenu.setPlaying (false);
			StartCoroutine (Reset ());


		
		}


		if (player.transform.position.x <= currentEnemyLocation.x - Random.Range (20,50)) {

		

			SpawnEnemy ();

		}







	}




	void SpawnEnemy(){


		currentEnemy++;

		currentEnemyLocation =  new Vector3 (currentEnemyLocation.x - Random.Range (0+spawnRange, 2*spawnRange), 2, Random.Range (-7, 7));
		enemies [currentEnemy] = (GameObject)Instantiate (enemy, currentEnemyLocation,transform.rotation);
		
	}


	IEnumerator Reset(){

		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex) ;

	}


	



}
