using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Gauge : MonoBehaviour {

	Slider K_slider;
	Slider E_slider;
	// Use this for initialization
	void Start () {
		K_slider = GameObject.Find("K_Gauge").GetComponent<Slider>();
		E_slider = GameObject.Find("E_Gauge").GetComponent<Slider>();
		
	}
	
	float _hp = 0;
	void Update () {
		// HP上昇
		_hp += 1f;
		if(_hp > 10) {
			// 最大を超えたら0に戻す
			_hp = 0;
		}

		// HPゲージに値を設定
		K_slider.value = _hp;
		E_slider.value = _hp;
	}
}
