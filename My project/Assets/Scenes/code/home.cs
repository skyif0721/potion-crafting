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
            // ����Ѿ��ռ���5����Ʒ,���Թ���
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
                // ��һ�δ�ռ���5����Ʒ,�޷�����
                Debug.Log("�㻹��Ҫ�ռ��������Ʒ���ܹ���!");
            }
        }
    }
    }
