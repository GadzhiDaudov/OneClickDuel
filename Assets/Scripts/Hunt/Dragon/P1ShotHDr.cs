using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1ShotHDr : MonoBehaviour {

	public static int PL;
	public GameObject p1Shot;
	public GameObject ready;
	public GameObject readyOff;
	public GameObject LosePanel;
	public GameObject LosePanel2;
	public GameObject ContinueBut;
	public GameObject AdvBut;
	public float RandTime;
	public float readyT;
	public float readyT2;
	public float RandEnTime;
	public float enShot;
	public Text PLifeText;
	public int PLife;
	public AudioSource ShotSound;
	public GameObject GoSound;
	public AudioSource[] Death;
	private int SoundInt;
	public float soundTime;

	public float StopShot;
	public static float StopShot2;

	public GameObject[] Char;

	// Use this for initialization
	void Start () {
		StopShot2 = 0f;
		SoundInt = Random.Range (0, 3);
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


		RandTime = Random.Range (2.6f, 7.0f);
		RandEnTime = Random.Range (0.185f, 0.42f);
	}
	void Shot () {
		Vector3 position = new Vector3 (Random.Range (-360.0f, 360.0f), Random.Range (-580.0f, -36.0f), 100);
		p1Shot.transform.position = position;
		readyT -= 3000.0f;
	}
	void EnShot () {
		LosePanel2.SetActive (true);
		p1Shot.SetActive (false);
		readyT2 -= 3000.0f;
		PL--;
	}

	public void ClickCont () {
		SceneManager.LoadScene ("HuntDragon");
	}

	void Update (){
		readyT += Time.deltaTime;
		readyT2 += Time.deltaTime;
		PLife = PL;
		StopShot = StopShot2;
		enShot = RandTime + 0.32f + RandEnTime + StopShot;

		PLifeText.text = "PL: " + PLife;

		if (PLife == 0) {
			LosePanel.SetActive (true);
			LosePanel2.SetActive (false);
				AdvBut.SetActive (false);
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
			soundTime += Time.deltaTime;
			if (readyT2 > 0) {
				if (PlayerPrefs.GetInt ("Sound") != 0) {
					ShotSound.Play ();
					if (soundTime <= 0.1f) {
						Death [SoundInt].Play ();
					}
				}
			}
			EnShot ();
			p1Shot.SetActive (false);
			readyT2 -= 3000.0f;
		}
	}
}
