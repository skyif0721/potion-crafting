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
            // ����Ѿ��ռ���ָ����������Ʒ,���Թ���
            Debug.Log("count" + countItem);
            if (other.tag == "Player")
            {
                // ����Ҵ��͵���һ��������ָ��λ��
                other.transform.position = playerSpawnPosition;

                // �л�����
                SceneManager.LoadScene(sceneBuildIndex);
            }
        }
        else
        {
            // ��һ�δ�ռ���ָ����������Ʒ,�޷�����
            Debug.Log("�㻹��Ҫ�ռ��������Ʒ���ܹ���!");
        }
    }
}