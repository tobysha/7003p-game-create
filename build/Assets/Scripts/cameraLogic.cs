using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLogic : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    float distance;
    public Transform Paotai;
    float SuofangSpeed = 2;
    float max = 15;
    float min = 5;
    float rotateSpeed = 2;
    void Start()
    {
        offset = Paotai.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
       
        this.transform.position = Vector3.Lerp(this.transform.position, Paotai.position - offset, 0.1f);
        //RotateView();
        suofang();
    }
    void suofang()
    {
        distance = offset.magnitude;
        distance += -Input.GetAxis("Mouse ScrollWheel") * SuofangSpeed;
        distance = Mathf.Clamp(distance, min, max);
        offset = offset.normalized * distance;

    }
    void RotateView()
    {
        this.transform.RotateAround(Paotai.position, Paotai.forward, -Input.GetAxis("Mouse X") );

        this.transform.RotateAround(Paotai.position, Paotai.up, -Input.GetAxis("Mouse Y"));
        offset = Paotai.position - this.transform.position;



    }
}
