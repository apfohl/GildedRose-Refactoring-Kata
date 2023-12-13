namespace GildedRose;

public static class QualityUpdaters
{
    public static void UpdateAgedBrie(Item item)
    {
        item.IncreaseQuality(1);

        if (--item.SellIn < 0)
        {
            item.IncreaseQuality(1);
        }
    }

    public static void UpdateBackstagePasses(Item item)
    {
        item.IncreaseQuality(1);

        if (item.SellIn <= 10)
        {
            item.IncreaseQuality(1);
        }

        if (item.SellIn <= 5)
        {
            item.IncreaseQuality(1);
        }

        if (--item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    public static void UpdateOther(Item item)
    {
        item.DecreaseQuality(1);

        if (--item.SellIn < 0)
        {
            item.DecreaseQuality(1);
        }
    }

    public static void UpdateConjured(Item item)
    {
        item.DecreaseQuality(2);

        if (--item.SellIn < 0)
        {
            item.DecreaseQuality(2);
        }
    }

    private static void DecreaseQuality(this Item item, int amount)
    {
        switch (item.Quality)
        {
            case 0:
                break;
            case 1:
                item.Quality = 0;
                break;
            default:
                item.Quality -= amount;
                break;
        }
    }

    private static void IncreaseQuality(this Item item, int amount)
    {
        if (item.Quality < 50)
        {
            item.Quality += amount;
        }
    }
}
