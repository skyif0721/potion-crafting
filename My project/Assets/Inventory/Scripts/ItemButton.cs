using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// �Ƴ�����
public class ItemButton : MonoBehaviour { 
    public int btnId; // ��ťid
    private Item2 item; // �����ť��Ӧ������

    // ��ȡ��ť�϶�Ӧ������
    private Item2 GetThisItem()
    {
        for(int i=0; i<GameManager._instance.items.Count; i++)
        {
            // ��ť��itmes�������Ƕ�Ӧ��
            if(btnId == i)
            {
                item = GameManager._instance.items[i];
            }
        }

        return item;
    }

    // ÿ���Ƴ�һ������
    public void CloseBtn()
    {
        //�Ƴ�
        GameManager._instance.RemoveItem(GetThisItem());
    }

   

}
