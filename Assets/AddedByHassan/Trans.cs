using UnityEngine;
using System.Collections;

public class Trans : MonoBehaviour 
{

	public Texture2D FadeImage;
	//Rect button=(new Rect(225,15,100,40));
//	public string Label="Load Level";

	float FadeSpeed=0.5f;

	float alphaLevel=1f;//(between 0 and 1)
	int Depth = -1000;
	int Direction=-1;
	public void DirectionChanger()
	{
		Direction = 1;
	}

	void OnGUI()
	{
		//			Application.LoadLevel (ToLoad);
		alphaLevel = alphaLevel + (Direction * FadeSpeed * Time.deltaTime);//The operation is conducted in seconds unit
		alphaLevel = Mathf.Clamp01 (alphaLevel);//Clamp the alphaLevel between 0 and 1 (Needed by onGUI())
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alphaLevel);
		GUI.depth = Depth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), FadeImage);
		if (alphaLevel == 1 && Direction == 1)
			Application.LoadLevel (0);
	}

}
/*
	void Start()
	{
//		GetComponent<GUITexture>().color = Color.black;
		GetComponent<GUITexture>().pixelInset = new Rect (0f, 0f, Screen.width, Screen.height);
		//GetComponent<GUITexture>().color = Color.black;
		//		FadeToClear ();
	}


	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.clear, FadeSpeed * Time.deltaTime);
	}
	void FadeToBlack ()
	{
		// Lerp the colour of the texture between itself and black.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.black, FadeSpeed * Time.deltaTime);
	}
	
	void StartScene ()
	{
		//	GetComponent<GUITexture>().enabled = true;	
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(GetComponent<GUITexture>().color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			GetComponent<GUITexture>().color = Color.clear;
//				GetComponent<GUITexture>().enabled = false;
			myFlag=true;
			// The scene is no longer starting.		
		}
	}
	
	
	public void EndScene ()
	{
		// Make sure the texture is enabled.
		// Start fading towards black.
		
		FadeToBlack();
		// If the screen is almost black...
		if (GetComponent<GUITexture> ().color.a >= 0.95f)
		{
			
			GetComponent<GUITexture>().color = Color.black;
			IsStarted = false;
//				GetComponent<GUITexture>().enabled = false;		
			//	Application.LoadLevel (1);
			// The scene is no longer starting.
		}
		// ... reload the level.
		//	Application.LoadLevel(1);
	}
	
	*/
	

