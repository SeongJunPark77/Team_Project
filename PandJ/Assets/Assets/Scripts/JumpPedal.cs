using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPedal : MonoBehaviour
{
    void Start()
    {
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
        }
    }
}
