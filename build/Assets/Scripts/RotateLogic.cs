using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLogic : MonoBehaviour
{
    public FlyControlLogic flyspeed;
    float Round = 0;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Round = 2 * 360;
        if(Round<0)
        {
            Round = 0;
        }
        float Rounddistance = Round * Time.deltaTime;
        this.transform.Rotate(0, 0, Rounddistance, Space.Self);
    }
}
