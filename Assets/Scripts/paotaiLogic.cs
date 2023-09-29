using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paotaiLogic : MonoBehaviour
{
    float Turnspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Turnspeed = 40f;

            this.transform.Rotate(0, 0, Turnspeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            Turnspeed = -40f;
            this.transform.Rotate(0,0, Turnspeed * Time.deltaTime, Space.Self);
        }
    }
}
