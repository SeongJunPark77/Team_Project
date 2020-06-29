using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_moving_z : MonoBehaviour
{
    Vector3 pos;

    public float delta = 0.0f;
    public float speed = 0.0f;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
