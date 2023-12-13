using GildedRose;
using NUnit.Framework;
using static GildedRose.QualityUpdaters;

namespace GildedRoseTests;

public static class QualityUpdatersTests
{
    [TestCase(0, 10, 12)]
    [TestCase(1, 10, 11)]
    [TestCase(1, 50, 50)]
    public static void UpdateAgedBrie_updates_quality_correctly(int sellIn, int quality, int resultingQuality)
    {
        var item = new Item
        {
            Name = "Aged Brie",
            SellIn = sellIn,
            Quality = quality
        };

        UpdateAgedBrie(item);

        Assert.That(item.Quality, Is.EqualTo(resultingQuality));
    }

    [TestCase(11, 25, 26)]
    [TestCase(10, 25, 27)]
    [TestCase(9, 25, 27)]
    [TestCase(8, 25, 27)]
    [TestCase(7, 25, 27)]
    [TestCase(6, 25, 27)]
    [TestCase(5, 25, 28)]
    [TestCase(4, 25, 28)]
    [TestCase(3, 25, 28)]
    [TestCase(2, 25, 28)]
    [TestCase(1, 25, 28)]
    [TestCase(0, 25, 0)]
    public static void UpdateBackstagePasses_updates_quality_correctly(int sellIn, int quality, int resultingQuality)
    {
        var item = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = sellIn,
            Quality = quality
        };

        UpdateBackstagePasses(item);

        Assert.That(item.Quality, Is.EqualTo(resultingQuality));
    }

    [TestCase(10, 32, 31)]
    [TestCase(1, 32, 31)]
    [TestCase(0, 32, 30)]
    [TestCase(5, 0, 0)]
    public static void UpdateOther_updates_quality_correctly(int sellIn, int quality, int resultingQuality)
    {
        var item = new Item
        {
            Name = "Other Item",
            SellIn = sellIn,
            Quality = quality
        };

        UpdateOther(item);

        Assert.That(item.Quality, Is.EqualTo(resultingQuality));
    }

    [TestCase(1, 10, 8)]
    [TestCase(0, 10, 6)]
    [TestCase(5, 0, 0)]
    [TestCase(5, 1, 0)]
    [TestCase(5, 2, 0)]
    public static void UpdateConjured_updates_quality_correctly(int sellIn, int quality, int resultingQuality)
    {
        var item = new Item
        {
            Name = "Conjured Mana Cake",
            SellIn = sellIn,
            Quality = quality
        };

        UpdateConjured(item);

        Assert.That(item.Quality, Is.EqualTo(resultingQuality));
    }
}
