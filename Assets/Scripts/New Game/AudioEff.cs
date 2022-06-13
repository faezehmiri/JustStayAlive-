using UnityEngine;
using System.Collections;

public class AudioEff : MonoBehaviour {

	public AudioSource audioEffSource;
	public static AudioEff audioEff;
	public AudioClip[] soundEff;
	public AudioClip[] exploresion;
	void Awake()
	{
		if (audioEff == null) {
			DontDestroyOnLoad (this.gameObject);
			audioEff = this;
		}
		else if(audioEff != this)
		{
			Destroy (gameObject);
		}
	}
}
