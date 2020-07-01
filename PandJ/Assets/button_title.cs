using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_title : MonoBehaviour
{
    GameObject single;
    void Awake()
    {
        single = GameObject.Find("BGM");
    }
    public void clicked()
    {
        SceneManager.LoadScene("Title");
        Destroy(single);
    }
}
