using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2P : MonoBehaviour {

	public static int P1S;
	public static int P2S;
	public int P1score;
	public int P2score;
	public Text P1scoreText;
	public Text P2scoreText;
	public GameObject P1WinPanel;
	public GameObject P2WinPanel;
	public GameObject P1WinPanel2;
	public GameObject P2WinPanel2;


	void Start () {
		
	}

	void Update () {
		P1score = P1S;
		P1scoreText.text = "P1: " + P1score;
		P2score = P2S;
		P2scoreText.text = "P2: " + P2score;
		if (P1score == 3) {
			P1WinPanel.SetActive (true);
			P1WinPanel2.SetActive (false);
		}
		if (P2score == 3) {
			P2WinPanel.SetActive (true);
			P2WinPanel2.SetActive (false);
		}
	}
}
