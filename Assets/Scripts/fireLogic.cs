using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireLogic : MonoBehaviour
{
    public GameObject bullet;
    public Transform firepoint;
    public Transform bulletfolder;
    public float BulletFlyDistance = 5;
    float flyspeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            fire();
        }
    }
    void fire()
    {
        GameObject note = GameObject.Instantiate(bullet, bulletfolder);
        note.transform.position = firepoint.transform.position;
        note.transform.eulerAngles = firepoint.transform.eulerAngles;
        bulletLogic bulletfly = bullet.GetComponent<bulletLogic>();
        flyspeed = bulletfly.speed;
        bulletfly.maxdistance = flyspeed * BulletFlyDistance;

    }
    
}
