using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �洢������Ϣ,�̳�ScriptableObject�����������������
[CreateAssetMenu(menuName = "Item", fileName = "New Item")]
public class Item2 : ScriptableObject
{
    public string itemName;//����
    public string itemDec; //��ϸ��Ϣ

    public Sprite itemSprite; // ����ͼƬ
    public int itemPrice;   //����۸�
}
