using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OPScript : MonoBehaviour {

	private int Time = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0f, 0.05f, 0f);
		Stage();
	}

	public void Stage(){
		if (Time == 1080) {
			SceneManager.LoadScene ("Select");
		}
		Time++;
	}


}
