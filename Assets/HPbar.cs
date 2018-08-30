using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class HPbar: MonoBehaviour {

	Slider K_slider;
	Slider E_slider;
	void Start () {
		// スライダーを取得する
		K_slider = GameObject.Find("K_HPbar").GetComponent<Slider>();
		E_slider = GameObject.Find("E_HPbar").GetComponent<Slider>();
	}

	float _hp = 100;
	void Update () {
		// HP上昇
		_hp -= 1f;
		if(_hp <0) {
			// 最大を超えたら0に戻す
			_hp = 100;
		}

		// HPゲージに値を設定
		K_slider.value = _hp;
		E_slider.value = _hp;
	}
}
