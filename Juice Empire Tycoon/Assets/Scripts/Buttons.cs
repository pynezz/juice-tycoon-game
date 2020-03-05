using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject exitInventoryBtn;
    public GameObject totalInventoryUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InventoryKeyCode();
    }

    public void CloseInventoryWindow()
    {
        totalInventoryUI.SetActive(false);
    }

    public void OpenInventoryButtonPress()
    {
        totalInventoryUI.SetActive(!totalInventoryUI.activeSelf);
    }

    public void InventoryKeyCode()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            totalInventoryUI.SetActive(!totalInventoryUI.activeSelf);
        }
       
    }
}
