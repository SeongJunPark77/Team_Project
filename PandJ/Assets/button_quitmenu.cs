using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_quitmenu : MonoBehaviour
{
    public GameObject howtoplay;
    // Start is called before the first frame update
    public void clicked()
    {
        howtoplay.SetActive(false);
    }
}
