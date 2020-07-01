using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_howtoplay : MonoBehaviour
{
    public GameObject howtoplay;
    // Start is called before the first frame update
    void Start()
    {
        howtoplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        howtoplay.SetActive(true);
    }
}
