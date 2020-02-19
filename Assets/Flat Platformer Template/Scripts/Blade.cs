using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
      float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);  
    }
}
