using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cheat : MonoBehaviour
{
    public Transform player;

    public Transform Exit2;
    public Transform Exit3;
    public Transform Exit4;
    public Transform Exit5;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            player.transform.position = Exit2.position;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            player.transform.position = Exit3.position;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            player.transform.position = Exit4.position;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            player.transform.position = Exit5.position;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("End");
        }
    }

    
}
