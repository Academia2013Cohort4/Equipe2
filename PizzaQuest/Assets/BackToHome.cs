using UnityEngine;
using System.Collections;

public class BackToHome : MonoBehaviour {
	public GUIStyle style;
	
	void OnGUI() {

		if(GUI.Button(new Rect(Screen.width / 3 + 80, Screen.height / 2 - 75, 550, 50), "Back to Main Menu", style)) {
			Application.LoadLevel ("Main menu, thing");
		}
	}
}
