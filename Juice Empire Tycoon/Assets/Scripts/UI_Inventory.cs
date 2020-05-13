using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Inventory : MonoBehaviour
{
    private Inventory _inventory;

    private StatsSidebar _statsSidebar;
    private Transform _statsPanel;

    private Transform _itemSlotContainer;
    private Transform _itemSlotTemplate;

    private void Awake()
    {
        _itemSlotContainer = transform.Find("itemSlotContainer");
        _itemSlotTemplate = _itemSlotContainer.Find("itemSlotTemplate");
        _statsPanel = transform.Find("StatsPanel");
    }

    public void SetInventory(Inventory inventory)
    {
        this._inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 250f;

        foreach (Items item in _inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(_itemSlotTemplate, _itemSlotContainer).GetComponent<RectTransform>();
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
