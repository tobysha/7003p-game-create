using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkLogic : MonoBehaviour
{
    float Walkspeed;
    float qianhou;
    public Transform walkspace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyControl();
        this.transform.Translate(qianhou* Time.deltaTime, Walkspeed * Time.deltaTime, 0,walkspace.transform);
    }
    void KeyControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            qianhou = -3f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            qianhou = 3f;
        }
        else
        {
            qianhou = 0;

        }
        if (Input.GetKey(KeyCode.A))
        {
            Walkspeed = -3f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Walkspeed = 3f;
        }
        else
        {
            Walkspeed = 0;

        }
    }
}
