using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        
        IncrementScore();
    }

    int Score = 0;
    void IncrementScore()
    {
        Score++;
        Debug.Log("You were hit: " + Score + " times");
    }
}
