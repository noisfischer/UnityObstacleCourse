using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    UnityEngine.Vector3 PlayerStartPosition;
    void Start()
    {
        PlayerStartPosition = GetComponent<Transform>().position;
    }
    
    void Update()
    {
        MovePlayer();
        CheckResetInput();
    }

    // SerializeField lets you edit variable values in Unity inspector panel
    [SerializeField] float moveSpeed = 5.0f;
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0.0f, zValue);
    }

void CheckResetInput()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ResetPlayer();
        }
    }

    void ResetPlayer()
    {
        transform.position = PlayerStartPosition;
    }
}
