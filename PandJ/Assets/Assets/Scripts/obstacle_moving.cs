using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_moving : MonoBehaviour
{
    Vector3 pos; //현재위치

    public float delta; //좌우 이동 변위값
    public float speed ; //이동속도

    void Start()
    {
        pos = transform.position;
    }


    void Update()
    {
        Vector3 v = pos;
        //z축으로 원하면 여기서 z로 바꾸면됨
        v.x += delta * Mathf.Sin(Time.time * speed);

        transform.position = v;
    }
}
