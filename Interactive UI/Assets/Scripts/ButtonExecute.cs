using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonExecute : MonoBehaviour {

    //public Button startButton, stopButton;
    Button hitButton, currentButton;

    private bool on = false;
    private float timer = 5.0f;
    public float countDown;
    public float timeToSelect = 3.0f;

    public Text counter;
    // Use this for initialization
    void Start()
    {
        // startButton = GameObject.Find("StartButton").GetComponent<Button>();
        //stopButton = GameObject.Find("StopButton").GetComponent<Button>();
        countDown = timeToSelect;
        counter.text = "Time til activation: 3 seconds";
    }

    // Update is called once per frame
    void Update () {

        Transform camera = Camera.main.transform;
        Ray ray= new Ray(camera.position, camera.rotation * Vector3.forward);
         RaycastHit hit;
        //GameObject hitObject;

        

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform .gameObject .tag =="Button")
            {
                if(countDown < 0f){
                    hitButton = hit.transform.parent.gameObject.GetComponent<Button>();
                    print("name= " + hitButton.name);
                    countDown = 3.0f;
                }
                //hitButton = hit.transform.parent.gameObject.GetComponent<Button>();
                //print("name= "+ hitButton.name);
                else
                {
                    countDown -= Time.deltaTime;
                }

            }

            else
            {
                countDown = 3.0f;
            }

            if (currentButton != hitButton)
            {
                //unhighlight

                if (currentButton != null) { currentButton.OnPointerExit(new PointerEventData(EventSystem.current)); }


                //make changes
                currentButton = hitButton;
                if (currentButton != null) { 
                    currentButton.onClick.Invoke();
                    currentButton.OnPointerEnter(new PointerEventData(EventSystem.current));
                }
            }

        }
        counter.text = "Time til activation:" + countDown;

    }
}
