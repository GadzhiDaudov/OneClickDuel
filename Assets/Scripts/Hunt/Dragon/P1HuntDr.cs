using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1HuntDr : MonoBehaviour {

	public GameObject PauseP;
	public GameObject P1WinPanel;
	public GameObject P1WinPanel2;
	public GameObject LosePanel;
	public GameObject P1Shot;
	public static int EnL;
	public Text P1scoreText;
	public int EnLife;
	public AudioSource ShotSound;
	public AudioSource Click;
	public AudioSource DragDeath;

	public void Update () {
		P1scoreText.text = "En: " + EnLife;
		EnLife = EnL;
		if (EnLife == 0) {
			P1WinPanel.SetActive (true);
			P1WinPanel2.SetActive (false);
			PlayerPrefs.SetInt ("Dragon", 1);
		}
	}

	public void OnClickPause (){
		PauseP.SetActive (true);
		Time.timeScale = 0;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClickResume (){
		PauseP.SetActive (false);
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Menu (){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
		EnL = 3;
		P1ShotHDr.PL = 3;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Retry (){
		SceneManager.LoadScene ("HuntDragon");
		Time.timeScale = 1;
		EnL = 3;
		P1ShotHDr.PL = 3;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		PlayerPrefs.SetInt ("DragonAdv", 0);
	}
	public void ClickP1NextRound (){
		SceneManager.LoadScene ("HuntDragon");
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1LoseMenu (){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
		EnL = 3;
		P1ShotHDr.PL = 3;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Shot (){
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ShotSound.Play ();
			DragDeath.Play ();
		}
		P1WinPanel2.SetActive (true);
		P1Shot.SetActive (false);
		//Time.timeScale = 0;
		EnL--;
		P1ShotHDr.StopShot2 += 3000f;
	}
}
