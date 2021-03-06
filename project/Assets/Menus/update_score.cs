﻿using UnityEngine;
using System.Collections;

public class update_score : MonoBehaviour {
	private Camera main_camera;
	private TextMesh text;
	
	// Use this for initialization
	void Start () {
		main_camera = GameObject.Find ("Main Camera").camera;
		text = GetComponent<TextMesh> ();

		int score = PlayerPrefs.GetInt ("Win/Lose");
		if (score == -1) { //-1 indicates the player loses
			text.text = "You were too weak to continue.\n\n " +
						"Stay energized and full nex time.";
			setSoundPitchLow();
		} else { // score will be the actual score of the player
			text.text = "\n\nYou missed something! \n\nyour score: " + score;
			setSoundPitchHigh();
		}
	}

	// call this if the player won the game
	void setSoundPitchHigh() {
		main_camera.audio.pitch = 1.35f;
	}

	// call this if the player lost the game
	void setSoundPitchLow() {
		main_camera.audio.pitch = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
