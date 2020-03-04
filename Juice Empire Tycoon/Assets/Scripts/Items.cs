using UnityEngine;

public class Items
{

    public enum ItemType
    {
        LightningJuice,
        IceJuice,
        CloverJuice,
        RadiationJuice,
        PremiumKingJuice,
        EmptyBottle,
        Nicotine100mg,
        PG100ml,
        PG500ml,
        PG1000ml,
        PG5000ml,
        PG10L,
        PG50L,
        VG100ml,
        VG500ml,
        VG1000ml,
        VG5000ml,
        VG10L,
        VG50L,
        Scale,

    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.CloverJuice:      return ItemAssets.Instance.cloverJuiceSprite;
            case ItemType.EmptyBottle:      return ItemAssets.Instance.emptyBottleSprite;
            case ItemType.IceJuice:         return ItemAssets.Instance.iceJuiceSprite;
            case ItemType.LightningJuice:   return ItemAssets.Instance.lightningJuiceSprite;
            case ItemType.PremiumKingJuice: return ItemAssets.Instance.premiumKingJuiceSprite;
            case ItemType.RadiationJuice:   return ItemAssets.Instance.radiationJuiceSprite;
        }
    }

}
