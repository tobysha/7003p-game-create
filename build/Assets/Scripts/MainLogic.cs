using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    public FlyControlLogic flyLogic;
    public RotateLogic rotatelogic;
    public AudioClip sssssss;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sssssss);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
