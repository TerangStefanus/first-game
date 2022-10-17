using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float x=0.03f;
    [SerializeField] float UP=0.0f;
    // [SerializeField] float z=0.00f;
    float MoveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * MoveSpeed;
        float z = Input.GetAxis("Vertical") * MoveSpeed;

        transform.Translate(x,UP,z);
    }
}
