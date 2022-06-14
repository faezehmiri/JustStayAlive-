using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject turnSoundOn, turnSoundOff, turnMusicOn, turnMusicOff;
	public Text bestScoreTxt;

	public GameObject mainMenu;
	public static MenuManager menuMan;
	int bestScore;
	public GameObject SoundEffect;

	void Awake ()
	{
		Time.timeScale = 1;
	}

	void Start ()
	{
		PlayerPrefs.SetInt ("showqc", 0);
		bestScore = PlayerPrefs.GetInt ("highScore");
		SetBestScoreTxt (bestScore);
		mainMenu.SetActive (true);
		if (PlayerPrefs.GetInt ("Sound") == 1) {
//			PlayerPrefs.SetInt ("Sound",0);
			AudioEff.audioEff.audioEffSource.volume = 0;
			turnSoundOn.SetActive (false);
			turnSoundOff.SetActive (true);
		} else if (PlayerPrefs.GetInt ("Sound") == 0) {
//			PlayerPrefs.SetInt ("Sound",1);
			AudioEff.audioEff.audioEffSource.volume = 1f;
			turnSoundOff.SetActive (false);
			turnSoundOn.SetActive (true);
		}

		if (PlayerPrefs.GetInt ("Music") == 1) {
//			PlayerPrefs.SetInt ("Music", 0);
			AudioManager.audioManager.audioMan.volume = 0;
			turnMusicOn.SetActive (false);
			turnMusicOff.SetActive (true);
		} else if (PlayerPrefs.GetInt ("Music") == 0) {
//			PlayerPrefs.SetInt ("Music", 1);
			AudioManager.audioManager.audioMan.volume = 1f;
			turnMusicOff.SetActive (false);
			turnMusicOn.SetActive (true);
		}
	}

	void SetBestScoreTxt (int value)
	{
		bestScoreTxt.text = value.ToString ();
	}


	public void TurnSoundOff ()
	{
		AudioEff.audioEff.audioEffSource.PlayOneShot (AudioEff.audioEff.exploresion [6]);
		PlayerPrefs.SetInt ("Sound", 1);
		AudioEff.audioEff.audioEffSource.volume = 0;
		turnSoundOn.SetActive (false);
		turnSoundOff.SetActive (true);
	}

	public void TurnSoundOn ()
	{
		AudioEff.audioEff.audioEffSource.PlayOneShot (AudioEff.audioEff.exploresion [6]);
		PlayerPrefs.SetInt ("Sound", 0);
		AudioEff.audioEff.audioEffSource.volume = 1f;
		turnSoundOff.SetActive (false);
		turnSoundOn.SetActive (true);
	}

	public void TurnMusicOff ()
	{
		AudioEff.audioEff.audioEffSource.PlayOneShot (AudioEff.audioEff.exploresion [6]);
		PlayerPrefs.SetInt ("Music", 1);
		AudioManager.audioManager.audioMan.volume = 0;
		turnMusicOn.SetActive (false);
		turnMusicOff.SetActive (true);
	}

	public void TurnMusicOn ()
	{
		AudioEff.audioEff.audioEffSource.PlayOneShot (AudioEff.audioEff.exploresion [6]);
		PlayerPrefs.SetInt ("Music", 0);
		AudioManager.audioManager.audioMan.volume = 1f;
		turnMusicOff.SetActive (false);
		turnMusicOn.SetActive (true);
	}



	





}
