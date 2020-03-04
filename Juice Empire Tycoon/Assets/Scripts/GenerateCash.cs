using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCash : MonoBehaviour
{
    public GlobalCash globalCash;
    private float plusOneCash = 1f;

    public void GetCash()
    {
        globalCash.cashCount += plusOneCash;
    }
}
