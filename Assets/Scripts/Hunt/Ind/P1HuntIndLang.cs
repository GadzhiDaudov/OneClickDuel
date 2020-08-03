using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1HuntIndLang : MonoBehaviour {
	public Text[] Win;
	public Text[] Lose;
	public Text[] Menu;
	public Text[] Retry;
	public Text[] Round;
	public Text Resume;
	public Text Cont;

	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			Win[0].text = "Победа";
			Win[1].text = "Победа";
			Lose[0].text = "Вы проиграли";
			Lose[1].text = "Вы проиграли";
			Menu [0].text = "Меню";
			Menu [1].text = "Меню";
			Menu [2].text = "Меню";
			Retry [0].text = "Повторить";
			Retry [1].text = "Повторить";
			Round[0].text = "Раунд";
			Round[1].text = "Раунд";
			Cont.text = "Продолжить";
			Resume.text = "Продолжить";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			Win[0].text = "Player Win";
			Win[1].text = "Player Win";
			Lose[0].text = "You Lose";
			Lose[1].text = "You Lose";
			Menu [0].text = "Menu";
			Menu [1].text = "Menu";
			Menu [2].text = "Menu";
			Retry [0].text = "Retry";
			Retry [1].text = "Retry";
			Round[0].text = "Round";
			Round[1].text = "Round";
			Cont.text = "Continue";
			Resume.text = "Resume";
		}
	}
}
