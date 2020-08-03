using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2S3Lang : MonoBehaviour {

	public Text[] Win;
	public Text[] Menu;
	public Text[] Retry;
	public Text[] Resume;
	public Text[] Round;

	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			Win[0].text = "Победа";
			Win[1].text = "Победа";
			Win[2].text = "Победа";
			Win[3].text = "Победа";
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
			Round[0].text = "Раунд";
			Round[1].text = "Раунд";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			Win[0].text = "Player1 Win";
			Win[1].text = "Player2 Win";
			Win[2].text = "Player1 Win";
			Win[3].text = "Player2 Win";
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
			Round[0].text = "Round";
			Round[1].text = "Round";
		}
	}
}
