using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour {
	public CollectableLevelManager manager;

	// Use this for initialization
	//attached to the collectable
	void Start () {
		manager = GameObject.Find ("GameControl").GetComponent<CollectableLevelManager> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 60, 0) * Time.deltaTime);

			}
	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			Destroy (this.gameObject);
			manager.win (1);
			//logic for winning

		}
	}

}
