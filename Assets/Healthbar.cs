using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Healthbar : MonoBehaviour {
	
	Slider slider;
	
	void Start () {
		
		slider = GetComponent<Slider> ();
	}
	
	void SetValue(float value) {
		
		slider.value = value;
	}
}