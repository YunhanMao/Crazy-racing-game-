using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CollectableLevelManager : MonoBehaviour {
	public GameObject winImage;
	public GameObject loseImage;

	public bool timeflag = false;
	public bool coinflag = false;
	public bool losetimeflag = false;

	// Use this for initialization
	void Start () {
		winImage.SetActive (false);
		loseImage.SetActive (false);
	
		//objectName.enabled=true or false,another command for enabling you'll see often
	}




	public void lose(int from){
		if (from == 2|| from==3) {
			losetimeflag = true;
			loseImage.SetActive (true);


		}
	}
	// Update is called once per frame
	void Update () {
		
	}

	public void win(int from){
		if (from == 0) {
			timeflag = true;
		} 
		else if (from == 1) 
		{
			coinflag = true;
		}
		if (timeflag==true && coinflag==true) 
		{
			winImage.SetActive (true);
		}

}
	public void restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	public void start(){
		SceneManager.LoadScene (1);
    }
}