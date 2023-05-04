using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsPanel : MonoBehaviour {
	public GameObject PauseP;
	public GameObject PauseP2;
	public GameObject P1WinPanel;
	public GameObject P2WinPanel;
	public GameObject P1Shot;
	public GameObject P2Shot;
	public AudioSource ShotSound;
	public AudioSource Click;
	public AudioSource[] Death;
	private int SoundInt;

	public Animator[] AnimAllShot;
	private Animator AnimShot;
	public Animator[] AnimAllShot2;
	private Animator AnimShot2;

	public void Start () {
		SoundInt = Random.Range (0, 3);
		AnimShot = AnimAllShot [PlayerPrefs.GetInt ("Charter")];
		//AnimShot = AnimAllShot [0];
		AnimShot2 = AnimAllShot2 [PlayerPrefs.GetInt ("Charter2")];
		//AnimShot2 = AnimAllShot2 [0];
	}

	public void OnClickPause (){
		PauseP.SetActive (true);
		Time.timeScale = 0;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClickPause2 (){
		PauseP2.SetActive (true);
		Time.timeScale = 0;
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClickResume2 (){
		PauseP2.SetActive (false);
		Time.timeScale = 1;
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
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void ClickP1Retry (){
		SceneManager.LoadScene ("2Player");
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}

	public void ClickP1Shot (){
		AnimShot.SetInteger ("Shot", 1);
		AnimShot2.SetInteger ("RIP", 1);
		P1WinPanel.SetActive (true);
		P2Shot.SetActive (false);
		ShotSound.Play ();
		Death [SoundInt].Play ();
	}
	public void ClickP2Shot (){
		AnimShot2.SetInteger ("Shot", 1);
		AnimShot.SetInteger ("RIP", 1);
		P2WinPanel.SetActive (true);
		P2Shot.SetActive (true);
		ShotSound.Play ();
		Death [SoundInt].Play ();
	}
}
