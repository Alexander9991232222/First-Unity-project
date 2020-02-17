using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public float runSpeed = 3f;
    void Move(float ax){
        Vector3 direction = transform.right * ax;
        transform.position = Vector3.Lerp (transform.position,transform.position+direction,runSpeed*Time.deltaTime);
    }
}