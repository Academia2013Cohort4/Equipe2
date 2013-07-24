using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public GUIStyle titleStyle;
	public GUIStyle style;
	
	void OnGUI() {
		
		GUI.Label(new Rect(Screen.width / 3, Screen.height / 2 - 250, 300, 100), "Pizza Quest", titleStyle);
		
		if(GUI.Button(new Rect(Screen.width / 3 + 50, Screen.height / 2 - 175, 200, 50), "Begin Quest", style)) {
			Application.LoadLevel("Level1");
		}
		
		if(GUI.Button(new Rect(Screen.width / 3 + 75, Screen.height / 2 - 125, 200, 50), "Options", style)) {
			Debug.Log("Add Options");
		}
		
		if(GUI.Button(new Rect(Screen.width / 3 + 60, Screen.height / 2 - 75, 200, 50), "Exit Game", style)) {
			Application.Quit();
		}
	}
}
