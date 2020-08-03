using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1Hunt1 : MonoBehaviour {
	
	public GameObject PauseP;
	public GameObject P1WinPanel;
	public GameObject LosePanel;
	public GameObject P1Shot;
	public AudioSource ShotSound;
	public AudioSource Click;
	public AudioSource[] Death;
	private int SoundInt;

	public Animator[] AnimAllShot;
	private Animator AnimShot;
	public Animator AnimShot2;

	public void Start () {
		AnimShot = AnimAllShot [PlayerPrefs.GetInt ("Charter")];
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
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Retry (){
		SceneManager.LoadScene ("HuntJho");
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1NextRound (){
		SceneManager.LoadScene ("Surv");
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1LoseMenu (){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Shot (){
		AnimShot.SetInteger ("Shot", 1);
		AnimShot2.SetInteger ("RIP", 1);
		P1WinPanel.SetActive (true);
		PlayerPrefs.SetInt ("Jho", 1);
		P1Shot.SetActive (false);
		//Time.timeScale = 0;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ShotSound.Play ();
		}
		P1ShotHunt.StopShot2 += 3000f;
	}
}
