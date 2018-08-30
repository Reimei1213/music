using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] notes;
	private float[] _timing;
	private int[] _lineNum;

	public string filePass;
	private int _notesCount = 0;

	private AudioSource _audioSource;
	private float _startTime = 0;

	public float timeOffset = -1;

	private bool _isPlaying = false;
	public GameObject startButton;

	public Text scoreText;
	private int _score = 0;

	public Text StartText;
	public Text StartText2;


	private int MusicFlag = 0;
	private int WinFlag = 0;

	private float Color;

	public int ColorTag = 0;

	void Start(){
		_audioSource = GameObject.Find ("GameMusic").GetComponent<AudioSource> ();
		_timing = new float[1024];
		_lineNum = new int[1024];
		LoadCSV ();
	}

	void Update () {
		if (_isPlaying) {
			CheckNextNotes ();
			scoreText.text = _score.ToString ();
		}
		if (!_audioSource.isPlaying && MusicFlag == 1) {
			MusicFlag = 0;
			if (WinFlag == 1) {
				WinFlag = 0;
				SceneManager.LoadScene ("Win");
			} else {
				SceneManager.LoadScene ("Lose");
			}
			//WinFlagの設定をする
		}

	}

	public void StartGame(){
		startButton.SetActive (false);
		_startTime = Time.time;
		_audioSource.Play ();
		MusicFlag = 1;
		_isPlaying = true;
		Destroy (StartText);
		Destroy (StartText2);
	}

	void CheckNextNotes(){
		while (_timing [_notesCount] + timeOffset < GetMusicTime () && _timing [_notesCount] != 0) {
			SpawnNotes (_lineNum[_notesCount]);
			_notesCount++;
		}
	}

	void SpawnNotes(int num){
		var _obj = (GameObject)Instantiate (notes[num], 
			//new Vector3 (-4.0f + (2.0f * num), 10.0f, 0),
			//Quaternion.identity);
			new Vector3 (0,10.0f,0),Quaternion.identity);
		Color = Random.Range(0.0f, 1.0f);
		var _renderer = _obj.GetComponent<Renderer> ();
		if (0f <= Color && Color < 0.4f) {
			_renderer.material.color = new Color ((float)1f, 0f, 0f, 1f);
			ColorTag = 1;
		} else if (0.4f < Color && Color < 0.8f) {
			_renderer.material.color = new Color ((float)0f, 0f, 1f, 1f);
			ColorTag = 2;
		} else if (0.8f <= Color && Color <= 1.0f) {
			_renderer.material.color = new Color ((float)1f, 1f, 0f, 1f);
			ColorTag = 3;
		}
	}

	void LoadCSV(){
		int i = 0;
		TextAsset csv = Resources.Load (filePass) as TextAsset;
		StringReader reader = new StringReader (csv.text);
		while (reader.Peek () > -1) {

			string line = reader.ReadLine ();
			string[] values = line.Split (',');
			_timing [i] = float.Parse( values [0] );
			_lineNum [i] = int.Parse( values [1] );
			//Debug.Log (_timing[i] + " " + _lineNum[i]);
			i++;
		}
	}

	float GetMusicTime(){
		return Time.time - _startTime;
	}

	public void GoodTimingFunc(int num){
		//Debug.Log ("Line:" + num + " good!");
		//Debug.Log (GetMusicTime());
		_score++;
	}
}