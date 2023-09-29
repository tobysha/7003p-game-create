using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreateLogic1 : MonoBehaviour
{
    public GameObject monster_E;
    public Transform monsterpoint;
    public Transform monsterfolder;
    // Start is called before the first frame update
    public float createSpeed = 1f;
    void Start()
    {
        InvokeRepeating("monsterCreate", 1, createSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(3);
            Time.timeScale = 0;
        }
    }
    void monsterCreate()
    {
        GameObject monster = GameObject.Instantiate(monster_E, monsterfolder);
        monster.transform.position = monsterpoint.transform.position;
        monster.transform.eulerAngles = monsterpoint.transform.eulerAngles;
        //bulletLogic bulletfly = bullet.GetComponent<bulletLogic>();
        //bulletfly.speed = -2;
        //bulletfly.maxdistance = bulletfly.speed * 5;

    }
    
}
