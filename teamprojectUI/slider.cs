using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parent;

    public Slider playermove;

    void Start()
    {
        
    }
    public void OnSlider(float move)
    {
        playermove.value = move;
        parent.transform.position = new Vector3(move, 0, 0);
    }

    void Update()
    {
      
    }
}
