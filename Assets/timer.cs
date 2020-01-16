using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
     public float TimeUsed;
	 public float Timeleft;
	 float TimeBegin;
	 CollectableLevelManager manager;
	 public Text timeText;
	 public Text timeleftText;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find ("GameControl").GetComponent<CollectableLevelManager> ();
		//timeText.text = Time.timeSinceLevelLoad.ToString ();
		TimeBegin = Time.time;
	    
	}

	// Update is called once per frame
	void Update () 
	{
		TimeUsed = Time.time - TimeBegin;
		timeText.text = "TimePassed=" + TimeUsed.ToString();
		Timeleft = 90f - TimeUsed;
		timeleftText.text = "TimeLeft=" + Timeleft.ToString ();
		if (TimeUsed>90f) {
			manager.lose(3);
		}
	}


    void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			if (TimeUsed <= 90f) {
				manager.win (0);
			}		 
			else if (other.CompareTag ("Player")) 
			{
				if (TimeUsed > 90f) {
					manager.lose (2);
				}
			
			}
			
   }
	}
}



