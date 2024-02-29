using NUnit.Framework;
using WineCellarManager;

[TestFixture]
public class WineBottleTests
{
    [Test]
    public void TestEquality()
    {
        // Arrange
        var bottle1 = new WineBottle("Wine A", "Vineyard A", "Location A", 2010, "Style A", "Cellar A", 10, 50.0m, 25.0m, "Tasting notes A");
        var bottle2 = new WineBottle("Wine A", "Vineyard A", "Location A", 2010, "Style A", "Cellar A", 10, 50.0m, 25.0m, "Tasting notes A");
        var bottle3 = new WineBottle("Wine B", "Vineyard B", "Location B", 2015, "Style B", "Cellar B", 5, 60.0m, 30.0m, "Tasting notes B");

        // Act
        var areEqual1 = bottle1.Equals(bottle2);
        var areEqual2 = bottle1.Equals(bottle3);

        // Assert
        Assert.That(bottle1, Is.EqualTo(bottle2));
        Assert.That(bottle1, Is.Not.EqualTo(bottle3));
    }

    [Test]
    public void TestHashCodeConsistency()
    {
        // Arrange
        var bottle1 = new WineBottle("Wine A", "Vineyard A", "Location A", 2010, "Style A", "Cellar A", 10, 50.0m, 25.0m, "Tasting notes A");
        var bottle2 = new WineBottle("Wine A", "Vineyard A", "Location A", 2010, "Style A", "Cellar A", 10, 50.0m, 25.0m, "Tasting notes A");

        // Act
        var hash1 = bottle1.GetHashCode();
        var hash2 = bottle2.GetHashCode();

        // Assert
        Assert.That(hash2, Is.EqualTo(hash1));
    }


}
