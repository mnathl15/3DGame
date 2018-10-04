using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {


	private Color color;

	public StartMenu startMenu;



	void Start(){

		color = Color.black;


	}


	public void OnPointerEnter(){
		


		color = Color.red;
		this.GetComponent<UnityEngine.UI.Text> ().color = color;

	}

	public void OnPointerExit(){

		color = Color.black;
		this.GetComponent<UnityEngine.UI.Text> ().color = color;
	}


	public void OnPointerClick(){

		startMenu.setPlaying (true);
		this.gameObject.SetActive (false);

	}
}
