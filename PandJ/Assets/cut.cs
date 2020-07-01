using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cut : MonoBehaviour
{
    float timeSpan;
    float checkTime;
    float limitTime;

    public Image c;
    public Text d;
    void Awake()
    {
        Color colorc = c.color;
        colorc.a = 0f;
        c.color = colorc;

        Color colord = d.color;
        colord.a = 0f;
        d.color = colord;

        timeSpan = 0.0f;
        checkTime = 1.5f;
        limitTime = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Color colorc = c.color;
        Color colord = d.color;

        timeSpan += Time.deltaTime;

        if (timeSpan < checkTime)
        {
            colorc.a += 0.01f;
            c.color = colorc;

            colord.a += 0.14f;
            d.color = colord;
            this.transform.position += new Vector3(-8f, 0, 0);
        }
        else if (timeSpan >= checkTime)
        {
            colorc.a -= 0.003f;
            c.color = colorc;

            colord.a -= 0.055f;
            d.color = colord;

            this.transform.position += new Vector3(-0.5f, 0, 0);

            if (timeSpan >= limitTime)
            {
                Destroy(gameObject);
            }
        }
    }
}
