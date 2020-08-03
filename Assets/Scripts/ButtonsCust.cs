using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsCust : MonoBehaviour {

	public AudioSource Click;
	public AudioSource ClickNext;
	public GameObject CustDef;
	public GameObject CustJho;
	public GameObject CustInd;
	public GameObject CustDragon;
	public GameObject CustAlien;
	public GameObject CustSpoiler;
	public GameObject CustRaccoon;
	public GameObject CustMagl;
	//public GameObject Dalek;

	//P2
	public GameObject CustDef2;
	public GameObject CustJho2;
	public GameObject CustInd2;
	public GameObject CustDragon2;
	public GameObject CustAlien2;
	public GameObject CustSpoiler2;
	public GameObject CustRaccoon2;
	public GameObject CustMagl2;

	public GameObject Map1;
	public GameObject Map2;

	public GameObject CloseJho;
	public GameObject CloseInd;
	public GameObject CloseDragon;
	public GameObject CloseAlien;
	public GameObject CloseSpoiler;
	public GameObject CloseRaccoon;
	public GameObject CloseMagl;
	//
	public GameObject CloseJho2;
	public GameObject CloseInd2;
	public GameObject CloseDragon2;
	public GameObject CloseAlien2;
	public GameObject CloseSpoiler2;
	public GameObject CloseRaccoon2;
	public GameObject CloseMagl2;
	// Update is called once per frame
	void FixedUpdate () {

		if (PlayerPrefs.GetInt ("Jho") == 0) {
			CloseJho.SetActive (true);
			CloseJho2.SetActive (true);
		} else {
			CloseJho.SetActive (false);
			CloseJho2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Ind") == 0) {
			CloseInd.SetActive (true);
			CloseInd2.SetActive (true);
		} else {
			CloseInd.SetActive (false);
			CloseInd2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Dragon") == 0) {
			CloseDragon.SetActive (true);
			CloseDragon2.SetActive (true);
		} else {
			CloseDragon.SetActive (false);
			CloseDragon2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Alien") == 0) {
			CloseAlien.SetActive (true);
			CloseAlien2.SetActive (true);
		} else {
			CloseAlien.SetActive (false);
			CloseAlien2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Spoiler") == 0) {
			CloseSpoiler.SetActive (true);
			CloseSpoiler2.SetActive (true);
		} else {
			CloseSpoiler.SetActive (false);
			CloseSpoiler2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Raccoon") == 0) {
			CloseRaccoon.SetActive (true);
			CloseRaccoon2.SetActive (true);
		} else {
			CloseRaccoon.SetActive (false);
			CloseRaccoon2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Magl") == 0) {
			CloseMagl.SetActive (true);
			CloseMagl2.SetActive (true);
		} else {
			CloseMagl.SetActive (false);
			CloseMagl2.SetActive (false);
		}
	}	

	public void SelectDef () {
		PlayerPrefs.SetInt ("Charter", 0);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void SelectJho () {
		if (PlayerPrefs.GetInt ("Jho") == 1) {
			PlayerPrefs.SetInt ("Charter", 1);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectInd () {
		if (PlayerPrefs.GetInt ("Ind") == 1) {
			PlayerPrefs.SetInt ("Charter", 2);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectDragon () {
		if (PlayerPrefs.GetInt ("Dragon") == 1) {
			PlayerPrefs.SetInt ("Charter", 3);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectAlien () {
		if (PlayerPrefs.GetInt ("Alien") == 1) {
			PlayerPrefs.SetInt ("Charter", 4);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectSpoiler () {
		if (PlayerPrefs.GetInt ("Spoiler") == 1) {
			PlayerPrefs.SetInt ("Charter", 5);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectRaccon () {
		if (PlayerPrefs.GetInt ("Raccon") == 1) {
			PlayerPrefs.SetInt ("Charter", 6);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectMagl () {
		if (PlayerPrefs.GetInt ("Magl") == 1) {
			PlayerPrefs.SetInt ("Charter", 7);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}

	public void NextDef () {
		CustJho.SetActive (true);
		CustDef.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextJho () {
		CustInd.SetActive (true);
		CustJho.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextInd () {
		//CustDragon.SetActive (true);
		CustAlien.SetActive (true);
		CustInd.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextDragon () {
		CustAlien.SetActive (true);
		CustDragon.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextAlien () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustAlien.SetActive (false);
		CustSpoiler.SetActive (true);
	}
	public void NextSpoiler () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustRaccoon.SetActive (true);
		CustSpoiler.SetActive (false);
	}
	public void NextRaccoon () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustRaccoon.SetActive (false);
		CustMagl.SetActive (true);
	}
	public void NextMagl () {
		//if (PlayerPrefs.GetInt ("Sound") != 0) {
		//	ClickNext.Play ();
		//}
		//CustMagl.SetActive (false);
		//CustDalek.SetActive (true);
	}
	public void PrevJho () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustJho.SetActive (false);
		CustDef.SetActive (true);
	}
	public void PrevInd () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustInd.SetActive (false);
		CustJho.SetActive (true);
	}
	public void PrevDragon () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustInd.SetActive (true);
		CustDragon.SetActive (false);
	}
	public void PrevAlien () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		//CustDragon.SetActive (true);
		CustInd.SetActive (true);
		CustAlien.SetActive (false);
	}
	public void PrevSpoiler () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustSpoiler.SetActive (false);
		CustAlien.SetActive (true);
	}
	public void PrevRaccoon () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustSpoiler.SetActive (true);
		CustRaccoon.SetActive (false);
	}
	public void PrevMagl () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustRaccoon.SetActive (true);
		CustMagl.SetActive (false);
	}
	//P2
	public void SelectDef2 () {
		PlayerPrefs.SetInt ("Charter2", 0);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void SelectJho2 () {
		if (PlayerPrefs.GetInt ("Jho") == 1) {
			PlayerPrefs.SetInt ("Charter2", 1);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectInd2 () {
		if (PlayerPrefs.GetInt ("Ind") == 1) {
			PlayerPrefs.SetInt ("Charter2", 2);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectDragon2 () {
		if (PlayerPrefs.GetInt ("Dragon") == 1) {
			PlayerPrefs.SetInt ("Charter2", 3);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectAlien2 () {
		if (PlayerPrefs.GetInt ("Alien") == 1) {
			PlayerPrefs.SetInt ("Charter2", 4);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectSpoiler2 () {
		if (PlayerPrefs.GetInt ("Spoiler") == 1) {
			PlayerPrefs.SetInt ("Charter2", 5);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectRaccon2 () {
		if (PlayerPrefs.GetInt ("Raccon") == 1) {
			PlayerPrefs.SetInt ("Charter2", 6);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}
	public void SelectMagl2 () {
		if (PlayerPrefs.GetInt ("Magl") == 1) {
			PlayerPrefs.SetInt ("Charter2", 7);
			if (PlayerPrefs.GetInt ("Sound") != 0) {
				Click.Play ();
			}
		}
	}

	public void NextDef2 () {
		CustJho2.SetActive (true);
		CustDef2.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextJho2 () {
		CustInd2.SetActive (true);
		CustJho2.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextInd2 () {
		//CustDragon2.SetActive (true);
		CustAlien2.SetActive (true);
		CustInd2.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextDragon2 () {
		CustAlien2.SetActive (true);
		CustDragon2.SetActive (false);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
	}
	public void NextAlien2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustAlien2.SetActive (false);
		CustSpoiler2.SetActive (true);
	}
	public void NextSpoiler2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustRaccoon2.SetActive (true);
		CustSpoiler2.SetActive (false);
	}
	public void NextRaccoon2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustRaccoon2.SetActive (false);
		CustMagl2.SetActive (true);
	}
	public void NextMagl2 () {
		//if (PlayerPrefs.GetInt ("Sound") != 0) {
		//	ClickNext.Play ();
		//}
		//CustMagl2.SetActive (false);
		//CustDalek2.SetActive (true);
	}
	public void PrevJho2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustJho2.SetActive (false);
		CustDef2.SetActive (true);
	}
	public void PrevInd2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustInd2.SetActive (false);
		CustJho2.SetActive (true);
	}
	public void PrevDragon2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustInd2.SetActive (true);
		CustDragon2.SetActive (false);
	}
	public void PrevAlien2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		//CustDragon2.SetActive (true);
		CustInd2.SetActive (true);
		CustAlien2.SetActive (false);
	}
	public void PrevSpoiler2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustSpoiler2.SetActive (false);
		CustAlien2.SetActive (true);
	}
	public void PrevRaccoon2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustSpoiler2.SetActive (true);
		CustRaccoon2.SetActive (false);
	}
	public void PrevMagl2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		CustRaccoon2.SetActive (true);
		CustMagl2.SetActive (false);
	}
	//MAP
	public void SelectMap1 () {
		PlayerPrefs.SetInt ("Map", 0);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void SelectMap2 () {
		PlayerPrefs.SetInt ("Map", 1);
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			Click.Play ();
		}
	}
	public void NextMap1 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		Map2.SetActive (true);
		Map1.SetActive (false);
	}
	public void NextMap2 () {
		//if (PlayerPrefs.GetInt ("Sound") != 0) {
			//ClickNext.Play ();
		//}
		//Map2.SetActive (false);
	}
	public void PrevMap2 () {
		if (PlayerPrefs.GetInt ("Sound") != 0) {
			ClickNext.Play ();
		}
		Map2.SetActive (false);
		Map1.SetActive (true);
	}
}
