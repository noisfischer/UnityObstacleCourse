using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        MovePlayer();
    }

    // SerializeField lets you edit variable values in Unity inspector panel
    [SerializeField] float moveSpeed = 5.0f;
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0.0f, zValue);
    }

}
