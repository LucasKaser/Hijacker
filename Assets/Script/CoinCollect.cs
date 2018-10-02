using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinCollect : MonoBehaviour {
    public GameObject BossDoor;
    public int CoinCount = 0;
    public Text Coins;
    void Start()
    {

        Coins.GetComponent<Text>().text = "Coins: " + CoinCount;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            CoinCount++;
            Destroy(collision.gameObject);
            Coins.GetComponent<Text>().text = "Coins: " + CoinCount;
            if (CoinCount >= 15)
            {
                BossDoor.SetActive(false);
            }
        }

    }
    
}
    


