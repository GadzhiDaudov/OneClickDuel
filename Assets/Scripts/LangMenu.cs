using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangMenu : MonoBehaviour {

	public Text Hunt;
	public Text Surv;
	public Text Players;
	public Text Cust;
	//2player
	public Text shot;
	public Text shot3;
	public Text shot5;
	public Text shotBack;
	//Customise
	public Text Player1;
	public Text Player2;
	public Text Customise;
	// Hunt
	public Text Wanted;
	public Text Crime;
	public Text[] Play;
	public Text[] Name;
	public Text[] CrimeText;

	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			Hunt.text = "Охота";
			Surv.text = "Выживание";
			Players.text = "2 Игрока";
			Cust.text = "Персонажи";
			shot.text = "1 Выстрел";
			shot3.text = "3 Выстрела";
			shot5.text = "5 Выстрелов";
			shotBack.text = "Назад";
			Player1.text = "Игрок 1";
			Player2.text = "Игрок 2";
			Customise.text = "Персонажи";
			Wanted.text = "Розыск";
			Crime.text = "Преступление";
			Play [0].text = "Играть";
			Play [1].text = "Играть";
			Play [2].text = "Играть";
			Play [3].text = "Играть";
			Play [4].text = "Играть";
			Play [5].text = "Играть";
			Play [6].text = "Играть";
			Name [0].text = "Джо";
			Name [1].text = "Шаман";
			Name [2].text = "Горыныч";
			Name [3].text = "Пришелец Пол";
			Name [4].text = "Падла Генри";
			Name [5].text = "Помойная Панда";
			Name [6].text = "Не магл";
			CrimeText [0].text = "Назвал маму шерифа толстой";
			CrimeText [1].text = "Пробудил Горыныча";
			CrimeText [2].text = "Сжигал посевы фермеров";
			CrimeText [3].text = "Похищал скот горожан для экспериментов";
			CrimeText [4].text = "Осторожно Спойлеры!";
			CrimeText [5].text = "Украл батареи";
			CrimeText [6].text = "Использовал магию вне школы";
		} else if (PlayerPrefs.GetInt ("Lang") == 1) {
			Hunt.text = "Hunt";
			Surv.text = "Survival";
			Players.text = "2 Player";
			Cust.text = "Customise";
			shot.text = "1 Shot";
			shot3.text = "3 Kill";
			shot5.text = "5 Kill";
			shotBack.text = "Back";
			Player1.text = "Player 1";
			Player2.text = "Player 2";
			Customise.text = "Customise";
			Wanted.text = "Wanted";
			Crime.text = "Crime";
			Play [0].text = "Play";
			Play [1].text = "Play";
			Play [2].text = "Play";
			Play [3].text = "Play";
			Play [4].text = "Play";
			Play [5].text = "Play";
			Play [6].text = "Play";
			Name [0].text = "Jho";
			Name [1].text = "Shaman";
			Name [2].text = "Dragon";
			Name [3].text = "Alien Paul";
			Name [4].text = "Carrion Genry";
			Name [5].text = "Trash Panda";
			Name [6].text = "Not Magl";
			CrimeText [0].text = "Said the mother of the Sheriff fat";
			CrimeText [1].text = "Awakened the Dragon";
			CrimeText [2].text = "Burned the crops of farmers";
			CrimeText [3].text = "Kidnapped cattle townspeople for experiments";
			CrimeText [4].text = "Spoiler ALERT!";
			CrimeText [5].text = "Stole batteries";
			CrimeText [6].text = "Used magic outside school";
		}
	}
}
