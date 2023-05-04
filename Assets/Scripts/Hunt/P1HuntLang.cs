using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1HuntLang : MonoBehaviour {

	public Text Win;
	public Text Lose;
	public Text[] Menu;
	public Text[] Retry;
	public Text Resume;
	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			Win.text = "Победа";
			Lose.text = "Вы проиграли";
			Menu [0].text = "Меню";
			Menu [1].text = "Меню";
			Menu [2].text = "Меню";
			Retry [0].text = "Повторить";
			Retry [1].text = "Повторить";
			Resume.text = "Продолжить";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			Win.text = "Player Win";
			Lose.text = "You Lose";
			Menu [0].text = "Menu";
			Menu [1].text = "Menu";
			Menu [2].text = "Menu";
			Retry [0].text = "Retry";
			Retry [1].text = "Retry";
			Resume.text = "Resume";
		}
	}
}
