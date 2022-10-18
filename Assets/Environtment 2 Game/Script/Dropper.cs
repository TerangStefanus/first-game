using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Cache Reference 
    MeshRenderer invisible; // actually u can say this MeshRenderer renderer
    Rigidbody graivity;// same case u can say this Rigidbody rigidbody

    [SerializeField] float timeToWait = 100000f;

    void Start()
    {
        graivity = GetComponent<Rigidbody>();
        invisible = GetComponent<MeshRenderer>();

        invisible.enabled = false;
        Debug.Log("Hilang");
        graivity.useGravity = false;
        Debug.Log("Gada Gravitasi");
    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.time < timeToWait)
        {
            Debug.Log(" 3 Second has elapsed");
            // invisible.enabled = true;
            // Debug.Log("Kelihatan bang");
            // graivity.useGravity = true;
            // Debug.Log("jatuh dahh ajg");
        }
        
    }
}
