using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	private int a_x;
	private int a_y;
	public int buttonWi;
	public int buttonHi;


	// Use this for initialization
	void Start () {
		buttonWi = 200;
		buttonHi = 150;
		a_x = Screen.width / 2 - buttonWi / 2;
		a_y = Screen.height / 2 - buttonHi * 2;
	}

	void OnGUI() {
		var C1 = GUI.backgroundColor;
    GUI.backgroundColor = Color.blue;


		if(GUI.Button(new Rect(a_x, a_y + buttonHi + 10, buttonWi, buttonHi), "Save the Eggs")) {
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(a_x, a_y + buttonHi * 2 + 20, buttonWi, buttonHi), "Exit")) {
			#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
			#else
				Application.Quit();
			#endif
		}
	}
}
