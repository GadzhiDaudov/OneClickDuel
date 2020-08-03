using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Lang : MonoBehaviour {

	public Text[] Win;
	public Text[] Menu;
	public Text[] Retry;
	public Text[] Resume;

	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			Win[0].text = "Победа";
			Win[1].text = "Победа";
			Menu [0].text = "Меню";
			Menu [1].text = "Меню";
			Menu [2].text = "Меню";
			Menu [3].text = "Меню";
			Retry [0].text = "Повторить";
			Retry [1].text = "Повторить";
			Retry [2].text = "Повторить";
			Retry [3].text = "Повторить";
			Resume[0].text = "Продолжить";
			Resume[1].text = "Продолжить";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			Win[0].text = "Player Win";
			Win[1].text = "Player Win";
			Menu [0].text = "Menu";
			Menu [1].text = "Menu";
			Menu [2].text = "Menu";
			Menu [3].text = "Menu";
			Retry [0].text = "Retry";
			Retry [1].text = "Retry";
			Retry [2].text = "Retry";
			Retry [3].text = "Retry";
			Resume[0].text = "Resume";
			Resume[1].text = "Resume";
		}
	}
}
