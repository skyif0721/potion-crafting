using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    PlayerController playercontroller;
   [SerializeField]GameObject player;

    void Awake()
    {
        playercontroller = player.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
