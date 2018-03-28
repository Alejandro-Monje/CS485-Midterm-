using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

	void OnGUI() {
		if(GUI.Button(new Rect(250, 90, 50, 50), "Menu")) {
			Application.LoadLevel(0);
		}
	}
}
