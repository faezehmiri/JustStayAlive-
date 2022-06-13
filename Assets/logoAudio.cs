using UnityEngine;
using System.Collections;

public class logoAudio : MonoBehaviour {

	void LogoAudio()
	{
		AudioEff.audioEff.audioEffSource.PlayOneShot (AudioEff.audioEff.exploresion[5]);
	}
}
