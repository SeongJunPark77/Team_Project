using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_main : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    void Start()
    {
        //편의상 프리팹으로 안만들어서 복제되기전 원본 총알은 안보이게끔 y축 좀 아래에 두면됨
    
        //총알 초기위치가 안예뻐서 총알 초기위치 조정
        this.transform.Translate(Vector3.forward * 0.7f);
        this.transform.Translate(Vector3.right * 0.28f);
    }

    void Update()
    {
        //프레임마다 forward로 1.3만큼의 속도로 날아감
        transform.Translate(Vector3.forward * 1.3f);
    }

    void OnTriggerEnter(Collider c)
    {
        // 과녁 맞추면 사라짐
        if (c.gameObject == target1)
        {
            Destroy(gameObject);
            target1.SetActive(false);
        }
        if (c.gameObject == target2)
        {
            Destroy(gameObject);
            target2.SetActive(false);
        }

        if (c.gameObject == target3)
        {
            Destroy(gameObject);
            target3.SetActive(false);
        }

        if (c.gameObject == target4)
        {
            Destroy(gameObject);
            target4.SetActive(false);
        }

        //영원히 파괴 안되면 안되니까 아무 옵젝에나 충돌하면 0.3초뒤 파괴. 좀 비효율적인데 이거때메 씬 전체에 안보이게 큐브 엄청 크게 깔아놔야함 (어딘가에는 충돌이 되야하기 때문에...)
        Destroy(gameObject, 0.3f);
    }
}
