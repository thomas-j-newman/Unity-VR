using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class KillTarget : MonoBehaviour
{
    public GameObject target;
    public float timeToSelect = 3.0f;
    public ParticleSystem hitEffect;
    public GameObject killEffect;
    public int score = 0;
    private float countDown;
    
    public Text scoreText;
    // Use this for initialization
    void Start()
    {
        score = 0;
        countDown = timeToSelect;
        hitEffect.enableEmission = false;
        scoreText.text = "Score: 0";
        
    }
    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.transform.rotation * Vector3.forward);
        RaycastHit hit;
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100f);

        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);

        if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject == target))
        {
            if (countDown < 0f)
            {
                //ToDo: Kill target. Instantiate kill Effect. Reset the countdown.
                //Destroy(target);
                target.transform.position = new Vector3(x, 0, z);
                Instantiate(killEffect, target.transform.position, target.transform.rotation);
                score+=1;
                scoreText.text = "Score: " + score;
                countDown = 3.0f;
            }
            else
            {

                //ToDo: Decrement countdown with Time.deltaTime amount. Enable the hitEffect,
                //and place it at hit.ponit.
                countDown -= Time.deltaTime;
                hitEffect.enableEmission = true;
                hitEffect.transform.position = hit.point;
           
 }
        }
        else
        {
            //ToDo: Reset countdown. Disable hitEffect.
            countDown = 3.0f;
            hitEffect.enableEmission = false;
        }
    }
}
