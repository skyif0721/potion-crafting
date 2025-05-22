using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{
    private Item2 currentItem;
    public Image customCursor;

    public void OuMouseDownItem(Item2 item2)
    {
   if (currentItem != null)
        {
            currentItem=item2;
            customCursor.gameObject.SetActive(true);
            customCursor.sprite = currentItem.GetComponent<Image>().sprite;
        }
    }
}
