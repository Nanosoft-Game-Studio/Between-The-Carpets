using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public Animator transition;

	//public float transitionTime = 0.5f;

	// Update is called once per frame

	// Create a temporary reference to the current scene.
	Scene currentScene = SceneManager.GetActiveScene ();

	void Update () {

		if (Input.GetKey("space")) {

			FinalStart ();

		}

	}

	public void FinalStart(){

		//StartCoroutine (LoadLevel (0));

		//delay (1.5f);

		StartCoroutine (LoadLevel (1));

	}

	IEnumerator delay(float delaytime){
	
		yield return new WaitForSeconds (delaytime);

	}

	IEnumerator LoadLevel(int levelID) {

		//yield return new WaitForSeconds(transitionTime);

		transition.SetTrigger ("Start");

		yield return new WaitForSeconds(1f);

		SceneManager.LoadScene(levelID);

	}


}
