namespace GildedRose;

public static class QualityUpdaters
{
    public static void UpdateAgedBrie(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality += 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0 && item.Quality < 50)
        {
            item.Quality += 1;
        }
    }

    public static void UpdateBackstagePasses(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality += 1;

            if (item.SellIn <= 10 && item.Quality < 50)
            {
                item.Quality += 1;
            }

            if (item.SellIn <= 5 && item.Quality < 50)
            {
                item.Quality += 1;
            }
        }

        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    public static void UpdateSulfuras(Item _)
    {
        // Does nothing.
    }

    public static void UpdateOther(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0 && item.Quality > 0)
        {
            item.Quality -= 1;
        }
    }

    public static void UpdateConjured(Item item)
    {
        switch (item.Quality)
        {
            case 0:
                break;
            case 1:
            case 2:
                item.Quality = 0;
                break;
            default:
                item.Quality -= 2;
                break;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            switch (item.Quality)
            {
                case 0:
                    break;
                case 1:
                case 2:
                    item.Quality = 0;
                    break;
                default:
                    item.Quality -= 2;
                    break;
            }
        }
    }
}
