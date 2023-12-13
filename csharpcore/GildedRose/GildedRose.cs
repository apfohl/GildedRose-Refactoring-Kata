using System.Collections.Generic;
using static GildedRose.QualityUpdaters;

namespace GildedRose;

public sealed class GildedRose(IEnumerable<Item> items)
{
    public void UpdateQuality() =>
        items.ForEach(UpdateItemQuality);

    private static void UpdateItemQuality(Item item)
    {
        switch (item.Name)
        {
            case "Aged Brie":
                UpdateAgedBrie(item);
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                UpdateBackstagePasses(item);
                break;
            case "Sulfuras, Hand of Ragnaros":
                UpdateSulfuras(item);
                break;
            case "Conjured Mana Cake":
                UpdateConjured(item);
                break;
            default:
                UpdateOther(item);
                break;
        }
    }
}
