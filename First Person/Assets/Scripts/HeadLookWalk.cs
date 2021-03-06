using UnityEngine;
using System.Collections;

public class HeadLookWalk : MonoBehaviour
{
    public float velocity = 0.7f;
    private CharacterController controller;
    public bool isWalking = false;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        //Vector3 moveDirection = Camera.main.transform.forward;
       // moveDirection *= velocity * Time.deltaTime;
       // moveDirection.y = 0.0f;
        //transform.position += moveDirection;
        //controller.Move(moveDirection);
        //controller.SimpleMove(Camera.main.transform.forward * velocity);
        if (Clicked())
        {
            isWalking = !isWalking;
        }

        if (isWalking)
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
        }
    }

    public bool Clicked()
    {
        return Input.anyKeyDown;
    }
}