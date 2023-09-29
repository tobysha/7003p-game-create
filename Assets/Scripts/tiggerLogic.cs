using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tiggerLogic : MonoBehaviour
{
    // Start is called before the first frame update
    int blood ;
    private void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
       Debug.Log("产生了碰撞" );
        
        if (other.name.StartsWith("怪"))
        {
            other.gameObject.SendMessage("onHid");          //传给扣血系统
            ScoreCount.txt.text = "Score: " + ScoreCount.score;
            Object.Destroy(this.gameObject);

        }

        


    }


}
