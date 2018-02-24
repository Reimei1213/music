using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToStory5A : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Stage = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Stage(){
		SceneManager.LoadScene("Story5A");
	}
}
