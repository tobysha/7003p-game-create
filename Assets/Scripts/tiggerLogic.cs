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
       Debug.Log("��������ײ" );
        
        if (other.name.StartsWith("��"))
        {
            other.gameObject.SendMessage("onHid");          //������Ѫϵͳ
            ScoreCount.txt.text = "Score: " + ScoreCount.score;
            Object.Destroy(this.gameObject);

        }

        


    }


}
