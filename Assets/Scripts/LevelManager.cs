using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	
	void Start() {
		if(autoLoadNextLevelAfter == 0) {
			Debug.Log("Level auto load disabled");
		} else {
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name) {
		Debug.Log("Level load requested for " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log("Quit game reguested!");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		//catch the next level in the sequence in which we have put our levels in the build settings and load it automatically
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
