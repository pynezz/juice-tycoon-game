using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Buttons : MonoBehaviour
{
    public GameObject exitInventoryBtn;
    public GameObject marketPlaceBtn;
    public GameObject buyEmptyBottleBtn, buyIceJuiceBtn, buyThunderJuiceBtn, buyCloverJuiceBtn, buyRadiateJuiceBtn, buyKingJuiceBtn, buyNicotineBtn, buyVGJuiceBtn, buyPGJuiceBtn;




    public bool boolMouseOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InventoryKeyCode();
    }

    private void OnMouseOver()
    {
        boolMouseOver = true;
    }

    private void OnMouseExit()
    {
        boolMouseOver = false;
    }

    private void OnGUI()
    {
        GUI.depth = -10;
        GUI.Button(new Rect(10, 10, 100, 20), new GUIContent("Click me!", "Mouse Over Button"));

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
