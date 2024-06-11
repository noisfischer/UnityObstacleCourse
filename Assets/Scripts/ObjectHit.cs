using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    bool Hit = false;
    private void OnCollisionEnter(Collision other)
    {
        if(Hit) return;
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
            Hit = true;
        }
    }
}
