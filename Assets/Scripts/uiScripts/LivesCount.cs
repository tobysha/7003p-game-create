using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesCount : MonoBehaviour
{
    // Start is called before the first frame update
    public static Text Life;
    public static float LifeCount = 3;
    void Start()
    {
        Life = GameObject.Find("Life").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
