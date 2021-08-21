using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change : MonoBehaviour {

	public void change(int sceneid){

		SceneManager.LoadScene(sceneid);

	}

}
