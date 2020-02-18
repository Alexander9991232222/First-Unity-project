using UnityEngine;
using System.Collections;

public class MoveController<T> : MonoBehaviour
{
    private Unit<T> component;

    public MoveController()
    {
   
    }

    void Update()
    {
        this.component.Went(Input.GetAxis("Horizontal"));
    }
}
