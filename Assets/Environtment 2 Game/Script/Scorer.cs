using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits ;
    
    public void OnCollisionEnter()
    {
        Debug.Log("You've bumped into a thing this many times : " + hits++);   
    }
}
