using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftSystem : MonoBehaviour
{
    public List<Items> items = new List<Items>();
    public List<Items> craftbleItems = new List<Items>();

    public bool isCrafting;
    public string currentCraftID;

    public List<InputField> craftInputs = new List<InputField>();
    public List<Image> cratImages = new List<Image>();

    public Image resultImage;
    public Sprite emptySlot;
    public SpriteRenderer resultSpriteRenderer1;
    public SpriteRenderer resultSpriteRenderer2;






    Items FetchItemByID(int id)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].id == id)
            {
                return items[i];
            }

        }
        return null;
    }

    Items FetchCraftItem(string _id)
    {
        for (int i = 0; i < craftbleItems.Count; i++)
        {
            for (int j = 0; j < craftbleItems[i].craftID.Count; j++)
            {
                if (craftbleItems[i].craftID[j] == _id)
                {
                    return craftbleItems[i];
                }
            }

        }
        return null;
    }
    void ConstractCraftItems()
    {

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].craftable)
            {
                craftbleItems.Add(items[i]);
            }

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        ConstractCraftItems();
        //  Debug.Log(FetchItemByID(101).name);
        //Debug.Log(FetchCraftItem("201202").name);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCrafting)
        {
            Craft();
        }


    }
    void Craft()
    {
        currentCraftID = "";
        for (int i = 0; i < craftInputs.Count; i++)
        {
            if (craftInputs[i].text != "")
            {
                currentCraftID += craftInputs[i].text;
                cratImages[i].sprite = FetchItemByID(int.Parse(craftInputs[i].text)).sprite;
            }
            else
            {
                currentCraftID += "";
                cratImages[i].sprite = emptySlot;
            }
        }
        Items result = FetchCraftItem(currentCraftID);
        if (result != null)
        {

            resultImage.sprite = result.sprite;
          
        }
        else
        {
            resultImage.sprite = emptySlot;
        }
        if (currentCraftID == "201215" || currentCraftID == "215201")
        {
            // Òþ²ØÁ½¸ö SpriteRenderer
            
            resultSpriteRenderer1.gameObject.SetActive(false);
            resultSpriteRenderer2.gameObject.SetActive(false);
           



        }
       

    }
}
[System.Serializable]
public class Items
{
    public string name;
    public int id;
    public Sprite sprite;
    public bool craftable;
    public List<string> craftID;
}