using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2P5S : MonoBehaviour {

	public static int P1S5;
	public static int P2S5;
	public int P1score;
	public int P2score;
	public Text P1scoreText;
	public Text P2scoreText;
	public Text P1scoreText2;
	public Text P2scoreText2;
	public Text P1score1Text;
	public Text P2score1Text;
	public Text P1score2Text;
	public Text P2score2Text;
	public GameObject P1WinPanel;
	public GameObject P2WinPanel;
	public GameObject P1WinPanel2;
	public GameObject P2WinPanel2;

	void Update () {
		P1score = P1S5;
		P2score = P2S5;
		P1scoreText.text = "P1: " + P1score;
		P2scoreText.text = "P2: " + P2score;
		P1scoreText2.text = "P1: " + P1score;
		P2scoreText2.text = "P2: " + P2score;
		P1score1Text.text = "P1: " + P1score;
		P2score1Text.text = "P2: " + P2score;
		P1score2Text.text = "P1: " + P1score;
		P2score2Text.text = "P2: " + P2score;
		if (P1score == 5) {
			P1WinPanel.SetActive (true);
			P1WinPanel2.SetActive (false);
		}
		if (P2score == 5) {
			P2WinPanel.SetActive (true);
			P2WinPanel2.SetActive (false);
		}
	}
}
