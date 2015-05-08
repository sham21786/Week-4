using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldText : MonoBehaviour {

	Text goldtext;

	// Use this for initialization
	void Start () {
		goldtext = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void SetGold (int gold) {

		goldtext.text = string.Format ("{0} gold", gold);
	
	}
}
