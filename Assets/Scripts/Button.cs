using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	public AudioSource Click;
	public AudioSource ClickNext;

	public GameObject HuntPanel;
	public GameObject CustPanel;
	public GameObject play2Panel; 
	public GameObject HuntJho;
	public GameObject HuntInd;
	public GameObject HuntDragon;
	public GameObject HuntAlien;
	public GameObject HuntSpoiler;
	public GameObject HuntRaccoon;
	public GameObject HuntMagl;
	public GameObject SoundOn;
	public GameObject SoundOff;
	public GameObject LangMenu;
	public GameObject LangRus;
	public GameObject LangEng;

	public GameObject ComplJho;
	public GameObject ComplInd;
	public GameObject ComplDragon;
	public GameObject ComplAlien;
	public GameObject ComplSpoiler;
	public GameObject ComplRaccoon;
	public GameObject ComplMagl;

	public void FixedUpdate () {

		if (PlayerPrefs.GetInt ("Sound") != 0) {
			
			SoundOn.SetActive (true);
			SoundOff.SetActive (false);
		} else {
			SoundOn.SetActive (false);
			SoundOff.SetActive (true);
		}
		//HUNT
		if (PlayerPrefs.GetInt ("Jho") == 0) {
			ComplJho.SetActive (false);
		} else {
			ComplJho.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Ind") == 0) {
			ComplInd.SetActive (false);
		} else {
			ComplInd.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Dragon") == 0) {
			ComplDragon.SetActive (false);
		} else {
			ComplDragon.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Alien") == 0) {
			ComplAlien.SetActive (false);
		} else {
			ComplAlien.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Spoiler") == 0) {
			ComplSpoiler.SetActive (false);
		} else {
			ComplSpoiler.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Raccoon") == 0) {
			ComplRaccoon.SetActive (false);
		} else {
			ComplRaccoon.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Magl") == 0) {
			ComplMagl.SetActive (false);
		} else {
			ComplMagl.SetActive (true);
		}
		//HUNTEND
		//Lang
		if (PlayerPrefs.GetInt ("Lang") == 0) {
			LangRus.SetActive (true);
			LangEng.SetActive (false);
		} else {
			LangRus.SetActive (false);
			LangEng.SetActive (true);
		}
	}

	public void OnClickHunt () {
		HuntPanel.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClickHuntBack () {
		HuntPanel.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClickSurv () {
		SceneManager.LoadScene ("Surv");
		Time.timeScale = 1;
		PlayerPrefs.SetInt ("SurvAdv", 0);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClick2Player () {
		play2Panel.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClick2PBack () {
		play2Panel.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClick2POneShot () {
		SceneManager.LoadScene ("2Player");
		Time.timeScale = 1;
	}
	public void OnClick2P3S () {
		Time.timeScale = 1;
		SceneManager.LoadScene ("2Player3S");
		Score2P.P1S = 0;
		Score2P.P2S = 0;
	}
	public void OnClick2P5S () {
		Time.timeScale = 1;
		SceneManager.LoadScene ("2Player5S");
		Score2P5S.P1S5 = 0;
		Score2P5S.P2S5 = 0;
	}
	public void OnClickCust() {
		CustPanel.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void OnClickCustBack () {
		CustPanel.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}

	//Sound

	public void OnSound () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			PlayerPrefs.SetInt ("Sound", 0);
			SoundOn.SetActive (false);
			SoundOff.SetActive (true);
		} else {
			PlayerPrefs.SetInt ("Sound", 1);
			SoundOn.SetActive (true);
			SoundOff.SetActive (false);
		}
	}

	//Lang
	public void Rus () {
		PlayerPrefs.SetInt ("Lang", 0);
		LangMenu.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void Eng () {
		PlayerPrefs.SetInt ("Lang", 1);
		LangMenu.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void Lang () {
		LangMenu.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	//HUNT
	public void PlayJho () {
		SceneManager.LoadScene ("HuntJho");
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void PlayInd () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		SceneManager.LoadScene ("HuntInd");
		P1HuntInd.EnL = 3;
		P1ShotHInd.PL = 3;
		PlayerPrefs.SetInt ("IndAdv", 0);
	}
	public void PlayDragon () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		SceneManager.LoadScene ("HuntDragon");
		P1HuntDr.EnL = 3;
		P1ShotHDr.PL = 1;
		PlayerPrefs.SetInt ("DragonAdv", 0);
	}
	public void PlayAlien () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		SceneManager.LoadScene ("HuntAlien");
		P1HuntAl.EnL = 3;
		P1ShotHAl.PL = 3;
		PlayerPrefs.SetInt ("AlienAdv", 0);
	}
	public void PlaySpoiler () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		SceneManager.LoadScene ("HuntSpoiler");
		P1HuntSpoiler.EnL = 3;
		P1ShotHSpoiler.PL = 3;
		PlayerPrefs.SetInt ("SpoilerAdv", 0);
	}
	public void PlayRaccoon () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		SceneManager.LoadScene ("HuntRaccoon");
		P1HuntRaccoon.EnL = 3;
		P1ShotHRaccoon.PL = 3;
		PlayerPrefs.SetInt ("RaccoonnAdv", 0);
	}
	public void PlayMagl () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
		SceneManager.LoadScene ("HuntMagl");
		P1HuntMagl.EnL = 3;
		P1ShotMagl.PL = 3;
		PlayerPrefs.SetInt ("MaglAdv", 0);
	}
	public void NextJho () {
		HuntInd.SetActive (true);
		HuntJho.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextInd () {
		HuntAlien.SetActive (true);
		HuntInd.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextDragon () {
		HuntAlien.SetActive (true);
		HuntDragon.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextAlien () {
		HuntAlien.SetActive (false);
		HuntSpoiler.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextSpoiler () {
		HuntSpoiler.SetActive (false);
		HuntRaccoon.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextRaccoon () {
		HuntRaccoon.SetActive (false);
		HuntMagl.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}

	public void PrevInd () {
		HuntInd.SetActive (false);
		HuntJho.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}

	}
	public void PrevDragon () {
		HuntInd.SetActive (true);
		HuntDragon.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void PrevAlien () {
		HuntInd.SetActive (true);
		HuntAlien.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void PrevSpoiler () {
		HuntAlien.SetActive (true);
		HuntSpoiler.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void PrevRaccoon () {
		HuntSpoiler.SetActive (true);
		HuntRaccoon.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void PrevMagl () {
		HuntRaccoon.SetActive (true);
		HuntMagl.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
}

