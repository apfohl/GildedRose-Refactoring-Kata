using System;
using System.Collections.Generic;
using System.Linq;
using GildedRose;

namespace GildedRoseTests;

public static class TextTestFixture
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = Items().ToList();

        var app = new GildedRose.GildedRose(items);

        var days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        Enumerable.Range(0, days).ForEach(i =>
        {
            Console.WriteLine($"-------- day {i} --------");
            Console.WriteLine("name, sellIn, quality");

            items.ForEach(item => Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}"));

            Console.WriteLine("");
            app.UpdateQuality();
        });
    }

    private static IEnumerable<Item> Items()
    {
        yield return new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        yield return new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
        yield return new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 };
        yield return new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
        yield return new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 };
        yield return new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 };
        yield return new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 };
        yield return new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 };
        yield return new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
    }
}
