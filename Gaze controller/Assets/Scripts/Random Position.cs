using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {
    // public float timeToSelect = 3.0f;
    public float countDown = 0.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);

        if (countDown > 3.0f)
        {
            transform.position = new Vector3(x, 0, z);
            countDown = 0.0f;
        }
        else
        {
            countDown += Time.deltaTime;
        }

        
	}
}
