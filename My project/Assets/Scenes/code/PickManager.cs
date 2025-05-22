using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickManager : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
    // ��¼����Ѿ��񵽵���Ʒ����
    public int collectedItemCount = 0;

   public void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.tag == "itemCount")
       {
           setItemCount(collectedItemCount);
       }
    }

   public void Update()
   {

        
   }


   public int getItemCount()
   {
        return collectedItemCount;
   }

   public void setItemCount(int a)
   {
        collectedItemCount = a+1;
   }
}
