using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{

    private List<Items> itemList;
    public Inventory()
    {
        itemList = new List<Items>();

        AddItem(new Items { itemType = Items.ItemType.CloverJuice, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.LightningJuice, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.EmptyBottle, amount = 1 });
    }

    public void AddItem(Items item)
    {
        itemList.Add(item);
    }

    public List<Items> GetItemList()
    {
        return itemList;
    }
}
