using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Hero : MonoBehaviour {

    public float runSpeed = 3f;
    public float JumpForce = 5f;
    private Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D> ();
    }

    public void Jump(){
        rb.AddForce (transform.up*jumpForce, ForceMode2D.Impulse)';
    }
    public void Move(float ax){
        Vector3 direction = transform.right * ax;
        transform.position = Vector3.Lerp (transform.position,transform.position+direction,runSpeed*Time.deltaTime);
    }
}