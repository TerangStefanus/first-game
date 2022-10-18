using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Cache Reference 
    MeshRenderer invisible; // actually u can say this MeshRenderer renderer
    Rigidbody graivity;// same case u can say this Rigidbody rigidbody

    [SerializeField] float timeToWait = 10f;

    void Start()
    {
        invisible = GetComponent<MeshRenderer>();
        invisible.enabled = false;

        graivity = GetComponent<Rigidbody>();
        graivity.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.time < timeToWait)
        {
            Debug.Log(" 3 Second has elapsed");
            invisible.enabled = true;
            graivity.useGravity = true;
        }
        
    }
}
