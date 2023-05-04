using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1ShotSurv : MonoBehaviour {

	public GameObject p1Shot;
	public GameObject ready;
	public GameObject readyOff;
	public GameObject LosePanel;
	public float RandTime;
	public float readyT;
	public float readyT2;
	public float RandEnTime;
	public float RandEnTime2;
	public float RandEnTime3;
	public float enShot;
	public GameObject Prof;
	public int enC;
	public AudioSource ShotSound;
	public GameObject GoSound;
	public GameObject[] Char;
	public GameObject[] CharEn;
	public GameObject[] Background;
	public AudioSource[] Death;
	private int SoundInt;
	public float soundTime;
	public GameObject ContinueBut;
	public GameObject AdvBut;

	public float StopShot;
	public static float StopShot2;

	public Animator[] AnimAllShot;
	private Animator AnimShot;
	public Animator[] AnimAllShot2;
	private Animator AnimShot2;
	// Use this for initialization
	void Start () {
		StopShot2 = 0f;
		AnimShot = AnimAllShot [PlayerPrefs.GetInt ("Charter")];
		AnimShot2 = AnimAllShot2 [PlayerPrefs.GetInt ("Charter2")];
		SoundInt = Random.Range (0, 3);
		Prof = GameObject.Find ("Camera");
		RandTime = Random.Range (2.4f, 7.0f);
		RandEnTime = Random.Range (0.0f, 0.4f);
		RandEnTime2 = Random.Range (0.0f, 0.35f);
		RandEnTime3 = Random.Range (0.0f, 0.25f);
		//PlayerPrefs.SetInt ("Score", 0);
		//PlayerPrefs.SetInt ("Alien", 0);
		//PlayerPrefs.SetInt("Jho", 0);
		for (int i = 0; i < 7; i++)
		{
			Char[0].SetActive(false);
			Char[1].SetActive(false);
			Char[2].SetActive(false);
			Char[3].SetActive(false);
			Char[4].SetActive(false);
			Char[5].SetActive(false);
			Char[6].SetActive(false);
			Char[7].SetActive(false);

			if (PlayerPrefs.GetInt("Charter") == i)
			{
				Char[i].SetActive(true);
				break;
			}
		}


	}
	void Shot () {
		Vector3 position = new Vector3 (Random.Range (-360.0f, 360.0f), Random.Range (-580.0f, -36.0f), 100);
		p1Shot.transform.position = position;
		readyT -= 3000.0f;
	}

	void Update (){
		readyT += Time.deltaTime;
		readyT2 += Time.deltaTime;
		enC = Prof.GetComponent <Profile> ().enCount2;
		StopShot = StopShot2;

		if (enC <= 3) {
			enShot = RandTime + 0.5f + RandEnTime + StopShot;
		} else if ((enC > 3) && (enC <= 6)) {
			enShot = RandTime + 0.4f + RandEnTime2 + StopShot;
		} else {
			enShot = RandTime + 0.3f + RandEnTime3 + StopShot;
		}
		if (readyT > 1.0f) {
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				ready.SetActive (true);
			} else {
				readyOff.SetActive (true);
			}
		}
		if (readyT > RandTime) {
			Shot ();
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				GoSound.SetActive (true);
				ready.SetActive (false);
			} else {
				readyOff.SetActive (false);
			}
		}
		if (enShot <= readyT2) {
			if (readyT2 > 0) {
				//float soundTime;
				soundTime += Time.deltaTime;
				if (PlayerPrefs.GetInt ("Sound") != 0) {
					ShotSound.Play ();
					if (soundTime <= 0.1f) {
						Death [SoundInt].Play ();
					}
				}
			}
			AnimShot2.SetInteger ("Shot", 1);
			AnimShot.SetInteger ("RIP", 1);
			LosePanel.SetActive (true);
				AdvBut.SetActive (false);
			p1Shot.SetActive (false);
			readyT2 -= 3000.0f;
		}
	}


	public void ClickAdv () {
		LosePanel.SetActive (false);
		ContinueBut.SetActive (true);
	}

	public void ClickCont () {
		SceneManager.LoadScene ("Surv");
	}
}
