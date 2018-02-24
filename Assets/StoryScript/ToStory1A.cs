using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToStory1A : MonoBehaviour {
	public ToSelect ToSelect;
	private int Story;

	// Use this for initialization
	void Start () {
		Story = ToSelect._Story;
		Story = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Stage(){
		SceneManager.LoadScene("Story1A");
	}
}
