using System.Collections.Generic;
using GildedRose;
using NUnit.Framework;

namespace GildedRoseTests;

public static class GildedRoseTest
{
    [Test]
    public static void Foo()
    {
        var items = new List<Item>
        {
            new() { Name = "foo", SellIn = 0, Quality = 0 }
        };

        new GildedRose.GildedRose(items).UpdateQuality();

        Assert.That(items[0].Name, Is.EqualTo("fixme"));
    }
}
