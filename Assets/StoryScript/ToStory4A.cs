using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToStory4A : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Story = 4;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Stage(){
		SceneManager.LoadScene("Story4A");
	}
}
