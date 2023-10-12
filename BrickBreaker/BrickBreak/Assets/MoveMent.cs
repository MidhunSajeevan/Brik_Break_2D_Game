
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    float force = 1000f;
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = Vector3.fwd;
        }
    }
}
