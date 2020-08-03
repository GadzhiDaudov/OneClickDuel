using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1ShotHunt : MonoBehaviour {

	public GameObject p1Shot;
	public GameObject ready;
	public GameObject readyOff;
	public GameObject LosePanel;
	public float RandTime;
	public float readyT;
	public float readyT2;
	public float RandEnTime;
	public float enShot;
	public AudioSource ShotSound;
	public GameObject GoSound;
	public AudioSource[] Death;
	private int SoundInt;
	public float soundTime;

	public float StopShot;
	public static float StopShot2;

	public Animator[] AnimAllShot;
	private Animator AnimShot;
	public Animator AnimShot2;

	public GameObject[] Char;

	// Use this for initialization
	void Start () {
		StopShot2 = 0f;
		AnimShot = AnimAllShot [PlayerPrefs.GetInt ("Charter")];
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
		RandEnTime = Random.Range (0.02f, 0.4f);
	}
	void Shot () {
		Vector3 position = new Vector3 (Random.Range (-360.0f, 360.0f), Random.Range (-580.0f, -36.0f), 100);
		p1Shot.transform.position = position;
		readyT -= 3000.0f;
	}

	void Update (){
		readyT += Time.deltaTime;
		readyT2 += Time.deltaTime;
		StopShot = StopShot2;
		enShot = RandTime + 0.45f + RandEnTime + StopShot;

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
			AnimShot2.SetInteger ("Shot", 1);
			AnimShot.SetInteger ("RIP", 1);
			readyT2 -= 3000.0f;
			LosePanel.SetActive (true);
			p1Shot.SetActive (false);
		}
	}
}
