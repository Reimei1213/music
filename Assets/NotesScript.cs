using UnityEngine;
using System.Collections;

public class NotesScript : MonoBehaviour {

	public int lineNum;
	private GameManager _gameManager;
	public float speed = -5.0f;

	private bool flag = false;

	void Start(){
		_gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	void Update () {
		//this.transform.position += Vector3.down * 10 * Time.deltaTime;
		switch(lineNum){
		case 0:
			this.transform.position += new Vector3(-0.5f,1.0f,0) * speed * Time.deltaTime;
			break;
		case 1:
			this.transform.position += new Vector3(-0.25f,1.0f,0) * speed * Time.deltaTime;
			break;
		case 2:
			this.transform.position += new Vector3(0,1.0f,0) * speed * Time.deltaTime;
			break;
		case 3:
			this.transform.position += new Vector3(0.25f,1.0f,0) * speed * Time.deltaTime;
			break;
		case 4:
			this.transform.position += new Vector3(0.5f,1.0f,0) * speed * Time.deltaTime;
			break;
		default:
			break;
		}
			
		if (this.transform.position.y < -5.0f) {
			
			Destroy (this.gameObject);
		}
	}


	/*void OnTriggerStay(Collider other){
		switch (lineNum) {
		case 0:
			CheckInput (KeyCode.D);
			//Debug.Log ("D");
			break;
		case 1:
			CheckInput (KeyCode.F);
			//Debug.Log ("F");
			break;
		case 2:
			CheckInput (KeyCode.Space);
			//Debug.Log ("Space");
			break;
		case 3:
			CheckInput (KeyCode.J);
			//Debug.Log ("J");
			break;
		case 4:
			CheckInput (KeyCode.K);
			//Debug.Log ("K");
			break;
		default:
			break;
		}
	}*/

	void CheckInput(KeyCode key){
		if (Input.GetKeyDown (key)) {
			_gameManager.GoodTimingFunc (lineNum);
			Destroy (this.gameObject);
		}
	}

	void  OnTriggerEnter(Collider other){
		flag = true;
	}

	void OnTriggerExit(Collider other){
		flag = false;
	}

	void CheckTouch(){
		if(flag == true){
			_gameManager.GoodTimingFunc (lineNum);
			Destroy (this.gameObject);
		}
	}

	void OnMouseDown(){
		CheckTouch ();
	}
}
