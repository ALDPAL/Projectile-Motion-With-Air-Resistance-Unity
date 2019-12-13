using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour
{

    float vx0, vz0, vy0;
    float x0, z0, y0;
    public float g = 10;
    public float b, t;
    Vector3 pos;

    float fx, fz, fy;

      // Use this for initialization
    void Start()
    {
        t = 0;
        fx = 0;
        fz = 0;
        fy = 0;

        x0 = transform.position.x;
        z0 = transform.position.z;
        y0 = transform.position.y;

        vx0 = Random.Range(1, 10);
        vz0 = Random.Range(1,10);
        vy0 = Random.Range(5, 10);

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        fx = (vx0 / b) * (1 - Mathf.Exp(-b * t)) + x0;

        fz = (vz0 / b) * (1 - Mathf.Exp(-b * t)) + z0;            

        fy = (g / Mathf.Pow(b, 2) + vy0 / b) * (1 - Mathf.Exp(-b * t)) * ((-g / b) * t) + y0;

        pos = new Vector3(fx, fy, fz);
        transform.position = pos;

    }
}
