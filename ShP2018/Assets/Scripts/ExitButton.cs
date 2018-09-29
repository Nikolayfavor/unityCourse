using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {
	void OnGUI() {
		if (GUILayout.Button("Stop"))
			Application.Quit();
	}
}
