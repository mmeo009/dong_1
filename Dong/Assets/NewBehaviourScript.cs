using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
    int a = 10;
    int b = 15;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(3, 3, 3);
    }

    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), rb.velocity.y, Input.GetAxis("Vertical"));
        //axis =>축, velocity => 속력, new Vector3 => (3,3,3) => (Horizontal,velocity,Vertical)로 변경
        //Horizontal, Vertical은 Edit/Project Srttings/Input Manager
       
        a = b;
        //a의 값을 b로 바꿈
    }
}
