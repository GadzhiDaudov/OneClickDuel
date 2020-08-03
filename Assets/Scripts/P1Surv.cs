using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class P1Surv : MonoBehaviour {

	public GameObject PauseP;
	public GameObject P1WinPanel;
	public GameObject LosePanel;
	public GameObject P1Shot;
	public GameObject Prof;
	public int scorePlus;
	public int enC;
	public AudioSource Click;
	public AudioSource[] Death;
	private int SoundInt;

	public AudioSource ShotSound;

	public Animator[] AnimAllShot;
	private Animator AnimShot;
	public Animator AnimShot2;

	void Start () {
		Prof = GameObject.Find ("Camera");
		SoundInt = Random.Range (0, 3);
		AnimShot = AnimAllShot [PlayerPrefs.GetInt ("Charter")];
	}

	 void Update () {
		enC = Prof.GetComponent <Profile> ().enCount2;
		if (enC < 6) {
			scorePlus = 8 + 2 * enC;
		} else {
			scorePlus = 8 + 3 * enC;
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
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Retry (){
		SceneManager.LoadScene ("Surv");
		Profile.enCount = 0;
		Profile.score1 = 0; 
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
		Profile.enCount = 0;
		Profile.score1 = 0; 
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Shot (){
		AnimShot.SetInteger ("Shot", 1);
		AnimShot2.SetInteger ("RIP", 1);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ShotSound.Play ();
			Death [SoundInt].Play ();
		}
		P1WinPanel.SetActive (true);
		P1Shot.SetActive (false);
		Profile.enCount++;
		Profile.score1 += scorePlus;
		//Time.timeScale = 0;
		P1ShotSurv.StopShot2 += 3000f;
	}
}
