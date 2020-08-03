using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Shot : MonoBehaviour {

	public GameObject p1Shot;
	public GameObject p2Shot;
	public GameObject ready;
	public GameObject readyOff;
	public float RandTime;
	public float readyT;
	public GameObject GoSound;
	public GameObject[] Char;
	public GameObject[] Char2;
	public GameObject[] Background;


	// Use this for initialization
	void Start () {
		RandTime = Random.Range (2.3f, 7.0f);
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

		for (int i = 0; i < 7; i++)
		{
			Char2[0].SetActive(false);
			Char2[1].SetActive(false);
			Char2[2].SetActive(false);
			Char2[3].SetActive(false);
			Char2[4].SetActive(false);
			Char2[5].SetActive(false);
			Char2[6].SetActive(false);
			Char2[7].SetActive(false);

			if (PlayerPrefs.GetInt("Charter2") == i)
			{
				Char2[i].SetActive(true);
				break;
			}
		}

		if (PlayerPrefs.GetInt ("Map") == 0) {
			Background [0].SetActive (true);
			Background [1].SetActive (false);
		} else if (PlayerPrefs.GetInt ("Map") == 1) {
			Background [0].SetActive (false);
			Background [1].SetActive (true);
		} 

	}
	void Shot () {
		Vector3 position = new Vector3 (Random.Range (-360.0f, 360.0f), Random.Range (-580.0f, -36.0f), 100);
		Vector3 position2 = new Vector3 (Random.Range (-360.0f, 360.0f), Random.Range (100.0f, 570.0f), 100);
		p1Shot.transform.position = position;
		p2Shot.transform.position = position2;
		readyT -= 3000.0f;
	}

	void Update (){
		readyT += Time.deltaTime;
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
	}
}