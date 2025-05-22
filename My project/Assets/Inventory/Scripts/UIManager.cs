using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // ����ҳ��
    public GameObject inventoryMenu;
    // Start is called before the first frame update
    void Start()
    {
        // ����ҳ��տ�ʼ�ǿ�������
        inventoryMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // ��������
        inventoryControl();
    }

    private void inventoryControl()
    {
        // �������esc������Ϸ���ڽ��У�����ͣ�� Ҫ����ͣ״̬�ͼ���
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager._instance.isPause)
            {
                Resume();
            }
            else
            {
                Pause(); 
            }
        }
    }

    private void Pause()
    {
        // �����������
        inventoryMenu.SetActive(true);
        // ��ͣ��Ϸ
        Time.timeScale = 0.0f;
        // �޸�isPause��ֵ
        GameManager._instance.isPause = true;
    }

    private void Resume()
    {
        // ������������
        inventoryMenu.SetActive(false);
        // ������Ϸ
        Time.timeScale = 1.0f;
        // �޸�isPause��ֵ
        GameManager._instance.isPause = false;
    }
}
