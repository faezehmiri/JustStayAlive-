using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	public AudioSource audioMan;
	public AudioClip[] bgAudio;
	public static AudioManager  audioManager;
	void Awake()
	{
		if (audioManager == null) {
			DontDestroyOnLoad (this.gameObject);
			audioManager = this;
		} else if (audioManager != this) {
			Destroy (gameObject);
		}
	}

	void Start()
	{
		audioMan.clip = bgAudio [Random.RandomRange (0, 4)];
		audioMan.Play ();
	}
}
