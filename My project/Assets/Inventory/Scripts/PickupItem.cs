using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 捡东西
public class PickupItem : MonoBehaviour
{
    
    // 特效
    public GameObject pickupEffect;
    // 物体
    public Item2 item;
    //public bool isPicked = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // 如果是玩家碰到了
        if(collision.tag == "Player")
        {
            //isPicked = true;
            Instantiate(pickupEffect,transform.position, Quaternion.identity);
            GameManager._instance.AddItem(item);
           
            //Debug.Log("PickupItem...." + isPicked);
            Destroy(gameObject);
        }
    }
}
