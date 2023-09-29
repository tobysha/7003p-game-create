using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -5;
    public float maxdistance;
    void Start()
    {
        float deathtime = maxdistance / speed;
        Invoke("distroy", deathtime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
    }
    void distroy()
    {
        Object.Destroy(this.gameObject);
    }
}
