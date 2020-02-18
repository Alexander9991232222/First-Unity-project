using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Hero : MonoBehaviour {

    public float runSpeed = 3f;
    public float jumpForce = 5f;
    public Transform cirTarg;
    public float radCir = 0.3f;
    private Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D> ();
    }

    bool isGround(){
    Collider2D[] gh = Physics2D.OverlapCircleAll (cirTarg.position,radCir);
    int j = 0;
    for (int i=0; i<gh.Length; i++) {
        if(gh[i].gameObject!=gameObject)
        j++;
    }
    return j > 0;
    }

    public void Jump(){
        if (isGround())
        rb.AddForce (transform.up*jumpForce, ForceMode2D.Impulse);
    }
    public void Move(float ax){
        Vector3 direction = transform.right * ax;
        transform.position = Vector3.Lerp (transform.position,transform.position+direction,runSpeed*Time.deltaTime);
    }
}