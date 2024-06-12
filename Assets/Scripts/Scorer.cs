using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    UnityEngine.Vector3 PlayerStartPosition;
    void Start()
    {
        PlayerStartPosition = GetComponent<Transform>().position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            IncrementScore();
            GetComponent<Transform>().position = PlayerStartPosition;
        }
            
    }

    int Score = 0;
    void IncrementScore()
    {
        Score++;
        Debug.Log("You hit: " + Score + " obstacles");
    }
}