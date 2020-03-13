using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;

    private StatsSidebar statsSidebar;
    private Transform statsPanel;

    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
        statsPanel = transform.Find("StatsPanel");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 250f;

        foreach (Items item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * -itemSlotCellSize);

            Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = item.GetSprite();

            y++;
            if (x > 1)
            {
                x = 0;
                y++;
            }
        }
    }

    public void PickFromInventory()
    {
        //RectTransform itemSlotRectTransform = GetComponent<RectTransform>();
        //itemSlotRectTransform.gameObject.SetActive(false);
        //Image i_image = itemSlotRectTransform.Find("image").GetComponent<Image>();
        Destroy(gameObject);
       // statsPanel.FindChild; // fortsett her

    }
}
