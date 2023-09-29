using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livesCheckLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("被打了");

        if (other.name.StartsWith("怪"))
        {
            Object.Destroy(other.gameObject);
            LivesCount.LifeCount -= 1;
            LivesCount.Life.text = "Life:" + LivesCount.LifeCount;
        }

    }
    void Update()
    {
        if(LivesCount.LifeCount <= 0)
        {
            Debug.Log("没命了（game over）");
            OnStartGame(2);
            LivesCount.LifeCount = 3;
        }
    }
    public void OnStartGame(int hahaha)
    {
        Application.LoadLevel(hahaha);

    }
}
