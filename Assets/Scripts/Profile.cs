using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour {

	public static int score1;
	public static int enCount;
	public int enCount2;
	public int prescore;
	public Text scoreText;
	public Text scoreText2;
	public Text scoreText3;

	void Update () {
		enCount2 = enCount;
		prescore = score1;
		if (PlayerPrefs.GetInt ("Score") <= prescore) {
			PlayerPrefs.SetInt ("Score", prescore);
		}
		scoreText.text = "" + PlayerPrefs.GetInt ("Score");
		scoreText3.text = "" + prescore;
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			scoreText2.text = "Очки: ";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			scoreText2.text = "Score: ";
		}

	}
}
