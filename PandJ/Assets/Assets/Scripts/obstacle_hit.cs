using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle_hit : MonoBehaviour
{
    //너가 원하는 이동 구역 각 스테이지 장애물마다 리스폰위치 다르게 잡을 수 있을듯
    public Transform Exit;

    public Image hit;

    void Start()
    {
        //초기 피격효과 알파값 0
        Color color = hit.color;
        color.a = 0.0f;
        hit.color = color;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {      
            //tag Player랑 충돌 한번할 때 마다 알파값 0.1상승
            Color color = hit.color;
            color.a += 0.1f;
            hit.color = color;
            //만약 3번 부딪혀서 알파값이 0.3이 될 때
            if(color.a == 0.3f)
            { 
                //알파값 다시 0되면서 뒤졌으니까 초기 장소로 이동
                color.a = 0.0f;
                hit.color = color;
                col.transform.position = Exit.position;
            }
        }
    }
}
