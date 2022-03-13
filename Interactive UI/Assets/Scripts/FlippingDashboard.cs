using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class FlippingDashboard : MonoBehaviour
    {
        private HeadGesture gesture;
        //private GameObject dashBoard;
        public GameObject affected;
        private bool open = true;
        private Vector3 startRotation;
        // Use this for initialization
        void Start()
        {
            gesture = GetComponent<HeadGesture>();
            //dashBoard = GameObject.Find("MeMyselfEye/Dashboard");
            //print(dashBoard.name);
            //startRotation = dashBoard.transform.eulerAngles;
            //print("startrotation" + startRotation);
        }
    // Update is called once per frame
    void Update()
    {
        if (gesture.isMovingDown)
        {
            print("down");
            //OpenDashboard();
        }
        else if(gesture.isMovingUp){
            print("up");
            //CloseDashboard();
        }
        //else if (!gesture.isFacingDown)
        //{
        //    CloseDashboard();
        //}
    }
//    private void CloseDashboard()
//        {
//            if (open)
//            {
//                dashBoard.transform.eulerAngles = new Vector3(180.0f,
//               startRotation.y, startRotation.z);
//                open = false;
//            }
//        }
//        private void OpenDashboard()
//        {
//            if (!open)
//            {
//                dashBoard.transform.eulerAngles = startRotation;
//                open = true;
//            }
//        }
    }

