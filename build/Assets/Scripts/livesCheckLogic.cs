using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livesCheckLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("������");

        if (other.name.StartsWith("��"))
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
            Debug.Log("û���ˣ�game over��");
            OnStartGame(2);
            LivesCount.LifeCount = 3;
        }
    }
    public void OnStartGame(int hahaha)
    {
        Application.LoadLevel(hahaha);

    }
}
