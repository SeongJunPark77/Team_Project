using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_moving : MonoBehaviour
{
    public float distance_max;
    public float distance_min;

    public float direction;

    float position_x; 
    float position_y; 
    float position_z;

    void Start()
    {
        position_x = this.transform.position.x;
        position_y = this.transform.position.y;
        position_z = this.transform.position.z;
    }

    void Update()
    {
        position_z += Time.deltaTime * direction;

        if (position_z >= distance_max)
        {
            direction *= -1;
            position_z = distance_max;
        }
        else if (position_z <= distance_min)
        {
            direction *= -1;
            position_z = distance_min;
        }

        this.transform.position = new Vector3(position_x, position_y, position_z);
    }
}
