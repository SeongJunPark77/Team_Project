using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_manager : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;

    public GameObject player;
    Animator player_animator;

    void Awake()
    {
        //플레이어 애니메이터 받아옴
        player_animator = player.GetComponent<Animator>();
    }

    void Update()
    {
        //플레이어 공격 애니메이션이 작동하면 그 때 총알이 복제됨
        if (player_animator.GetBool("isAttacking") == true)
        {
            Instantiate(Bullet, FirePos.transform.position + new Vector3(0, 1.45f, 0), FirePos.transform.rotation);

        }

    }
}
