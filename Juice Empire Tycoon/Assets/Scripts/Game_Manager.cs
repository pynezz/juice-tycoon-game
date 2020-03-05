using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    private Inventory inventory;

    public GameObject fullInventoryUI;

    [SerializeField] private UI_Inventory uiInventory;

    public void Start()
    {
        if(Input.GetKeyDown(KeyCode.I) && fullInventoryUI.activeSelf)
        {
            fullInventoryUI.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.I) && !fullInventoryUI.activeSelf)
        {
            fullInventoryUI.SetActive(true);
        }
    }

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
}
