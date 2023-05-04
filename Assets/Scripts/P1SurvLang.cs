using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1SurvLang : MonoBehaviour {

	public Text Win;
	public Text Lose;
	public Text[] Menu;
	public Text[] Retry;
	public Text[] Round;
	public Text Resume;
	public Text Cont;

	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			Win.text = "Победа";
			Lose.text = "Вы проиграли";
			Menu [0].text = "Меню";
			Menu [1].text = "Меню";
			Menu [2].text = "Меню";
			Retry [0].text = "Повторить";
			Retry [1].text = "Повторить";
			Round[0].text = "Раунд";
			Cont.text = "Продолжить";
			Resume.text = "Продолжить";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			Win.text = "Player Win";
			Lose.text = "You Lose";
			Menu [0].text = "Menu";
			Menu [1].text = "Menu";
			Menu [2].text = "Menu";
			Retry [0].text = "Retry";
			Retry [1].text = "Retry";
			Round[0].text = "Round";
			Cont.text = "Continue";
			Resume.text = "Resume";
		}
	}
}
