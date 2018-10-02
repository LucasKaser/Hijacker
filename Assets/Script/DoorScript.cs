using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public GameObject door;
    public GameObject BossHP;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BossHP.SetActive(true);
        door.SetActive(true);
    }

}
