using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1HuntSpoiler : MonoBehaviour {

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
	public AudioSource[] Death;
	private int SoundInt;

	public Animator[] AnimAllShot;
	private Animator AnimShot;
	public Animator AnimShot2;

	public void Start () {
		AnimShot = AnimAllShot [PlayerPrefs.GetInt ("Charter")];
	}

	public void Update () {
		P1scoreText.text = "En: " + EnLife;
		EnLife = EnL;
		if (EnLife == 0) {
			P1WinPanel.SetActive (true);
			P1WinPanel2.SetActive (false);
			PlayerPrefs.SetInt ("Spoiler", 1);
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
		P1ShotHInd.PL = 3;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Retry (){
		SceneManager.LoadScene ("HuntSpoiler");
		Time.timeScale = 1;
		EnL = 3;
		P1ShotHInd.PL =3;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		PlayerPrefs.SetInt ("SpoilerAdv", 0);
	}
	public void ClickP1NextRound (){
		SceneManager.LoadScene ("HuntSpoiler");
		Time.timeScale = 1;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1LoseMenu (){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
		EnL = 3;
		P1ShotHInd.PL = 3;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Shot (){
		AnimShot.SetInteger ("Shot", 1);
		AnimShot2.SetInteger ("RIP", 1);
		P1WinPanel2.SetActive (true);
		P1Shot.SetActive (false);
		//Time.timeScale = 0;
		EnL--;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ShotSound.Play ();
		}
		P1ShotHSpoiler.StopShot2 += 3000f;
	}
}
