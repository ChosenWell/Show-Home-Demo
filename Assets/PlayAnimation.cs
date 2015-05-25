using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour
{

	public float timer = 0f;
	
	Animator anim;
	// Use this for initialization
	void Start ()
	{
		GetComponent<Animator> ().enabled = false;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timer < Time.time) {
			GetComponent<Animator> ().enabled = true;
			Debug.Log ("3 Seconds Reached");
		}
	}
}
