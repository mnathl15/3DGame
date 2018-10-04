using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {



	private bool playing;

	void Awake () {
		playing = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public bool isPlaying(){

		Debug.Log (playing);
		return playing;
	}


	public void setPlaying(bool playing){

		this.playing = playing;
	}
}
