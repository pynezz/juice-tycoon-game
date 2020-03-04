using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public float cashCount;
    private float internalCash;

    public GameObject cashText;

    // Update is called once per frame
    void Update()
    {
        internalCash = cashCount;
        cashText.GetComponent<Text>().text = "" + internalCash;
    }
}
