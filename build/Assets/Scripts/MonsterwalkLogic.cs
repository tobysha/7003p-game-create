using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterwalkLogic : MonoBehaviour
{
    public float SpeedX = 4;
    public float SpeedZ = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ZouWei", 0, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        float dx = SpeedX * Time.deltaTime;
        float dz = SpeedZ * Time.deltaTime;
        float tiaozheng = 0.5f * Time.deltaTime;
        if (transform.position.z < -4.224f)
        {
            this.transform.Translate(dx, 0, tiaozheng, Space.Self);
        }
        else if (transform.position.z > 2.79f)
        {
            this.transform.Translate(dx, 0, -tiaozheng, Space.Self);
        }
        else
        {
            this.transform.Translate(dx, 0, dz, Space.Self);

        }

    }

    void ZouWei()
    {
        float[] Speedbox = { 5, -5, 2.5f, -2.5f };
        SpeedZ = Speedbox[Random.Range(0, Speedbox.Length)];

    }
}
