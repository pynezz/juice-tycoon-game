using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{

    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite lightningJuiceSprite;
    public Sprite iceJuiceSprite;
    public Sprite cloverJuiceSprite;
    public Sprite radiationJuiceSprite;
    public Sprite premiumKingJuiceSprite;
    public Sprite emptyBottleSprite;
    public Sprite nicotine100mgSprite;
    /*    

       public Sprite PG100mlSprite;
       public Sprite PG500mlSprite;
       public Sprite PG1000mlSprite;
       public Sprite PG5000mlSprite;
       public Sprite PG10LSprite;
       public Sprite PG50LSprite;
       public Sprite VG100mlSprite;
       public Sprite VG500mlSprite;
       public Sprite VG1000mlSprite;
       public Sprite VG5000mlSprite;
       public Sprite VG10LSprite;
       public Sprite VG50LSprite;
       public Sprite scaleSprite;  
   */
}
