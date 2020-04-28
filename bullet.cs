using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    private Vector3 ScreenCenter;

    public Transform effect;
    // Start is called before the first frame update
    void Start()
    {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);


    }

    // Update is called once per frame
    void Update()
    {
        effect.transform.Translate(Camera.main.pixelWidth / 2, Camera.main.pixelWidth / 2,0);
    }
}
