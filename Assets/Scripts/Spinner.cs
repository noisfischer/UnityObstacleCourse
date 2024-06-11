using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotate = 0.01f;
    [SerializeField] float yRotate = 0.0f;
    [SerializeField] float zRotate = 0.0f;
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
