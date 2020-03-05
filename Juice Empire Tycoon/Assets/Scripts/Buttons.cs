using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject exitInventoryBtn;
    public GameObject marketPlaceBtn;
    public GameObject buyEmptyBottleBtn, buyIceJuiceBtn, buyThunderJuiceBtn, buyCloverJuiceBtn, buyRadiateJuiceBtn, buyKingJuiceBtn, buyNicotineBtn, buyVGJuiceBtn, buyPGJuiceBtn; 

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
        marketPlaceBtn.SetActive(false);
    }

    public void OpenInventoryButtonPress()
    {
        marketPlaceBtn.SetActive(!marketPlaceBtn.activeSelf);
    }

    public void InventoryKeyCode()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            marketPlaceBtn.SetActive(!marketPlaceBtn.activeSelf);
        }
       
    }
    public void BuyEmptyBottle()
    {

    }
    public void BuyIceJuice()
    {

    }
    public void BuyCloverJuice()
    {

    }
    public void BuyRadiateJuice()
    {

    }
    public void BuyKingJuice()
    {

    }
    public void BuyNicotine()
    {

    }
    public void BuyPGJuice()
    {

    }
    public void BuyVGJuice()
    {

    }
    public void BuyThunderJuice()
    {

    }
}
