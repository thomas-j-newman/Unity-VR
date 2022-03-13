using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LookMoveTo : MonoBehaviour {
    public GameObject ground;
    public Text locationText;
    public float num1;
    public float num2;
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

        ray = new Ray(camera.position, camera.rotation *Vector3.forward);
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100f, Color.red, 1, true);
        hits = Physics.RaycastAll(ray);
        
                num1 = gameObject.transform.position.x;
                num2 = gameObject.transform.position.z;
                    
                Math.Round(num1, 2);
                Math.Round(num2, 2);

        for (int i =0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject;

            if (hitObject == ground)
            {
                Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
                
//                num1 = gameObject.transform.position.x;
//                num2 = gameObject.transform.position.z;
//                    
//                Math.Round(num1, 2);
//                Math.Round(num2, 2);
                
                    
                //locationText.text = "X: " + gameObject.transform.position.x+", Z: "+ gameObject.transform.position.z;
                
                locationText.text = "X: " + num1+", Z: "+ num2;
            }
        }
	}
}
