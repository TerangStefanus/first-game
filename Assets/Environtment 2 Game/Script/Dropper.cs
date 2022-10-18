using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer invisible;
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        invisible = GetComponent<MeshRenderer>();
        invisible.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.time < timeToWait)
        {
            Debug.Log(" 3 Second has elapsed");
        }
        
    }
}
