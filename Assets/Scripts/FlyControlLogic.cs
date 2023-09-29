using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyControlLogic : MonoBehaviour
{
    public float flyspeed = 0;
    float distance;
    //public Vector3 plane;
    //Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            fly();
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            down();
        }
        else
        {
            if (flyspeed > 0)
            {
                flyspeed = flyspeed - 0.02f; 
            }
            if (flyspeed < 0)
            {
                flyspeed = flyspeed + 0.02f;
            }
        }
        if (flyspeed>2)
        {
            flyspeed = 2;
        }
        if(flyspeed<-2)
        {
            flyspeed = -2;
        }
        distance = flyspeed * Time.deltaTime;
        Width();
        this.transform.Translate(0, distance, 0, Space.World);
    }
    public void fly()
    {
        flyspeed = flyspeed+0.1f;
    }
    public void down()
    {
        flyspeed = flyspeed - 0.1f;
    }
    public void Width()             //限制飞行边界
    {
        
        if (transform.position.z < -4.224f)
        {
            this.transform.localPosition = new Vector3(transform.position.x, transform.position.y, -4.224f);
        }
        if (transform.position.z > 2.79f)
        {
            this.transform.localPosition = new Vector3(transform.position.x, transform.position.y, 2.79f);
        }
        if (transform.position.y < 2.724f)
        {
            this.transform.localPosition = new Vector3(transform.position.x, 2.724f, transform.position.z);
        }
        if (transform.position.y > 5f)
        {
            this.transform.localPosition = new Vector3(transform.position.x, 5f, transform.position.z);
        }
        if (transform.position.x < -1.02f)
        {
            this.transform.localPosition = new Vector3(-1.02f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 7.29f)
        {
            this.transform.localPosition = new Vector3(7.29f, transform.position.y, transform.position.z);
        }


    }
    
}
