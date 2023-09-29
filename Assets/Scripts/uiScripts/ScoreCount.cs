using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCount : MonoBehaviour
{
    public  static Text txt;
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
