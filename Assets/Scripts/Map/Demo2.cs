using UnityEngine;
using System.Collections;

//Lop dùng để tắt animator, giúp nhẹ game 
public class Demo2 : MonoBehaviour {

	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	public void CaiGi()
	{
		anim.enabled = false;
	}
}
