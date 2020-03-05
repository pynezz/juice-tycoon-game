using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    private Inventory inventory;


    [SerializeField] private UI_Inventory uiInventory;

    public void Start()
    {

    }

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }


}
