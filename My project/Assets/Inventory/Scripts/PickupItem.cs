using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����
public class PickupItem : MonoBehaviour
{
    
    // ��Ч
    public GameObject pickupEffect;
    // ����
    public Item2 item;
    //public bool isPicked = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // ��������������
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
