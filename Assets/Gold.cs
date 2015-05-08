using UnityEngine;
using System.Collections;

public class Gold : MonoBehaviour {

	public int boxgold = 10;

	void OnTriggerEnter(Collider other) {
		
		if (other.CompareTag ("Player")) {
			
			other.SendMessage("GiveGold", boxgold);
			Destroy (gameObject);
		}
	}
}
