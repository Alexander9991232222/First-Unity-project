using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(UserController))]
public class UserController : MonoBehaviour{

    private UserController pc;
    // Start is called before the first frame update
    void Start(){
        pc = GetComponent<UserController> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        pc.Move (Input.GetAxis("Horizontal"));
        
    }
}
