using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSelect : MonoBehaviour {

	public int _Story = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Stage(){
		SceneManager.LoadScene("Select");
	}
}
