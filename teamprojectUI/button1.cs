using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    void Start()
    {
        player1.SetActive(true);
        player2.SetActive(false);
        player3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick1()
    {
        player1.SetActive(true);
        player2.SetActive(false);
        player3.SetActive(false);
    }
}
