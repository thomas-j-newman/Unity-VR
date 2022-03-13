using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform camera = Camera.main.transform;
        Ray ray;
        //Raycasting hit;
        RaycastHit[] hits;
        GameObject hitObject;

        ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100f, Color.red, 1, true);
    }
}
