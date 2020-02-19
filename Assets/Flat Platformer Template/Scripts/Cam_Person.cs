using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Person : MonoBehaviour{
    public GameObject privezat_k;
    // Update is called once per frame
    void Update(){
        transform.position = new Vector3 (privezat_k.transform.position.x, privezat_k.transform.position.y, -200f);
        
    }
}
