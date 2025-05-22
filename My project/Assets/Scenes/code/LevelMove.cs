using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMoveHome : MonoBehaviour
{

    public int NextItemNumber;

    public PickManager myPickManager;
    public int countItem;
    public int sceneBuildIndex;

    public Vector3 playerSpawnPosition;

    private void Update()
    {
        countItem = myPickManager.getItemCount();
        Debug.Log("count" + countItem);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered" + countItem);

        if (countItem >= NextItemNumber)
        {
            // 玩家已经收集到指定数量的物品,可以过关
            Debug.Log("count" + countItem);
            if (other.tag == "Player")
            {
                // 将玩家传送到下一个场景的指定位置
                other.transform.position = playerSpawnPosition;

                // 切换场景
                SceneManager.LoadScene(sceneBuildIndex);
            }
        }
        else
        {
            // 玩家还未收集到指定数量的物品,无法过关
            Debug.Log("你还需要收集更多的物品才能过关!");
        }
    }
}