using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_hide : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;

    public GameObject hideobj;
    // Start is called before the first frame update
    void Start()
    {
        // 처음에는 가려져있는 발판
        hideobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 과녁 4개가 모두 false 되면 true되면서 나타남
        if(target1.activeSelf==false&& target2.activeSelf == false && target3.activeSelf == false && target4.activeSelf == false)
        {
            hideobj.SetActive(true);
        }
    }
}
