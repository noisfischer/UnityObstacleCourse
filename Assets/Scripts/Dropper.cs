using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mesh;
    Rigidbody physics;
    [SerializeField] float TimeToWait = 3.0f;

void Start()
{
    mesh = GetComponent<MeshRenderer>();
    mesh.enabled = false;
    physics = GetComponent<Rigidbody>();
    physics.useGravity = false;
}

    void Update()
    {
        if(Time.time > TimeToWait)
        {
            mesh.enabled = true;
            physics.useGravity = true;
        }
    }
}
