using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkComplete : MonoBehaviour {
    public AudioSource complete; 
    public bool flip = false;
	// Use this for initialization
	void Start () {
		//complete.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		if     (GameObject.Find("Guitar1 Target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("Guitar2 Target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("amp1 target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("amp2 target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("mic target").GetComponent<TriggerSound>().objectSet == true)
            {
                
//                print("COMPLETED");
            if( flip == false)
            {
                print("COMPLETED");
                complete.Play();
                flip = true;
            }
            }
	}
}
