using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomposition: MonoBehaviour
{

    // public float timeToSelect = 3.0f;
    public float countDown = 0.0f;
    // Use this for initialization
    public Text locationText;
    public Canvas canvas;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        
        Debug.Log("X,Z: " + x.ToString("F2") + ", " + z.ToString("F2"));
        
        //always look at camera
        Vector3 v = Camera.main.transform.position - transform.position;
        v.x = v.z = 0.0f;
        canvas.transform.LookAt(Camera.main.transform.position-v);
        canvas.transform.rotation = (Camera.main.transform.rotation);

        if (countDown > 6.0f)
        {
            transform.position = new Vector3(x, 0, z);
            locationText.text = "X: " +x+", Z: "+z;
            countDown = 0.0f;
        }
        else
        {
            countDown += Time.deltaTime;
        }


    }
}
