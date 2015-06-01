using UnityEngine;
using System.Collections;

public class TransForMainMenu : MonoBehaviour 
{

	public Texture2D FadeImage;
//	Rect button1=new Rect(15,150,100,40);
//	Rect button2=new Rect(400,150,100,40);
//	Rect button3=new Rect(15,15,100,40);
//	Rect button4=new Rect(400,15,100,40);
//	Rect button5=new Rect(207.5f,82.5f,100,40);
	string Label1="Outer View";
	string Label2="No Roof";
	string Label3="In Room";
	string Label4="Community";
	string Label5="Exit";
	int ToLoad=0;
	
	float FadeSpeed=0.5f;
	
	float alphaLevel=1f;//(between 0 and 1)
	int Depth = -1000;
	int Direction=-1;

	public void DirectionChanger1()
	{
	Direction = 1;
			ToLoad=1;
	}
	public void DirectionChanger2()
	{ 
			Direction = 1;
			ToLoad=2;
		}
	public void DirectionChanger3()
	{ 
			Direction = 1;
			ToLoad=3;
		}
	public void DirectionChanger4()		{ 
			Direction = 1;
			ToLoad=4;
		}
	public void DirectionChanger5()
		{ 
			Direction = 1;
			ToLoad=5;
		}
	void OnGUI()
	{
		//			Application.LoadLevel (ToLoad);
		alphaLevel = alphaLevel + (Direction * FadeSpeed * Time.deltaTime);//The operation is conducted in seconds unit
		alphaLevel = Mathf.Clamp01 (alphaLevel);//Clamp the alphaLevel between 0 and 1 (Needed by onGUI())
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alphaLevel);
		GUI.depth = Depth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), FadeImage);
		if (alphaLevel == 1 && Direction == 1) {
			Application.LoadLevel (ToLoad);
		}
	}
}
