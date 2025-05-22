using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public int sceneBuildIndex;
    public int countItem=0;
    public int NextItemNumber;
    public PickManager myPickManager;

    public void Update()
    {
        countItem = myPickManager.getItemCount();
        Debug.Log("count" + countItem);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("countttttttttt"+pickupItem.collectedItemCount);
        if (countItem >= NextItemNumber)
        {
            // 玩家已经收集到5个物品,可以过关
            Debug.Log("count" + countItem);
            if (other.tag == "Player")
            {
                gameObject.SetActive(false);
                // Player entered, so move level
                print("Switching Scene to" + sceneBuildIndex);
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }

            else if (countItem < NextItemNumber)
            {
                // 玩家还未收集到5个物品,无法过关
                Debug.Log("你还需要收集更多的物品才能过关!");
            }
        }
    }
    }
