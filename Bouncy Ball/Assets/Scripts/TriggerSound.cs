using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TriggerSound : MonoBehaviour {
    public AudioSource hitSound;
    public Text scoreText;
    public int i = 0;
	// Use this for initialization
	void Start () {
		hitSound = GetComponent<AudioSource>();
        print("start");
        scoreText.text = "Score: 0";
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
		hitSound.Play();
        print("land played");
        i++;
        scoreText.text = "Score: " + i;
	}
    void OnCollisionEnter(Collision collision)
    {
        print("collisionenter");
    }
}
