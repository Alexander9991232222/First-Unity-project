using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Hero))]
public class UserController : MonoBehaviour{

    private Hero pc;
    // Start is called before the first frame update
    void Start(){
        pc = GetComponent<Hero> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Jump")){
            pc.Jump ();
        }
        pc.Move (Input.GetAxis("Horizontal"));   
    }
}
