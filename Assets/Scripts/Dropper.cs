using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 3.0f;

void Start()
{
    GetComponent<MeshRenderer>().enabled = false;
    GetComponent<Rigidbody>().useGravity = false;
}

    void Update()
    {
        if(Time.time > TimeToWait)
        {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
