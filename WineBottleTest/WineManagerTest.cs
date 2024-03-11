using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using WineCellarManager;

namespace WineCellarManager.Tests
{
    [TestFixture]
    public class WineManagerTests
    {
        private WineManager wineManager;

        [SetUp]
        public void Setup()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\desktop\\junk_cartelle\\Documents\\WineBottlesDb.mdf;Integrated Security=True;Connect Timeout=30";
            wineManager = new WineManager(connectionString);
        }

        [Test]
        public void TestAddWineBottle()
        {
            // Arrange
            var bottle = new WineBottle("Test Wine", "Test Vineyard", "Test Location", 2020, "Test Style", "Test Cellar", 10, 50.0m, 25.0m, "Test Tasting notes");
            var initialCount = wineManager.GetWineBottles().Count;

            // Act
            wineManager.AddWineBottle(bottle);

            // Assert
            var updatedCount = wineManager.GetWineBottles().Count;
            Assert.That(updatedCount, Is.EqualTo(initialCount + 1));
            Assert.That(wineManager.GetWineBottles(), Contains.Item(bottle));
        }

        [Test]
        public void TestRemoveWineBottle()
        {
            // Arrange
            var bottle = new WineBottle("Test Wine", "Test Vineyard", "Test Location", 2020, "Test Style", "Test Cellar", 10, 50.0m, 25.0m, "Test Tasting notes");
            wineManager.AddWineBottle(bottle);
            var initialCount = wineManager.GetWineBottles().Count;

            // Act
            wineManager.RemoveWineBottle(bottle);

            // Assert
            var updatedCount = wineManager.GetWineBottles().Count;
            Assert.That(updatedCount, Is.EqualTo(initialCount - 1));
            Assert.That(wineManager.GetWineBottles(), Does.Not.Contain(bottle));
        }

        [Test]
        public void TestUpdateWineBottleAttribute()
        {
            // Arrange
            var bottle = new WineBottle("Test Wine", "Test Vineyard", "Test Location", 2020, "Test Style", "Test Cellar", 10, 50.0m, 25.0m, "Test Tasting notes");

            // Act
            wineManager.UpdateWineBottleAttribute(bottle, "Style", "New Style");

            // Assert
            var updatedBottle = wineManager.GetWineBottles().FirstOrDefault(b => b.Name == "Test Wine");
            Assert.That(updatedBottle, Is.Not.Null);
            Assert.That(updatedBottle.Style, Is.EqualTo("New Style"));
        }

        [Test]
        public void TestSortWineBottles()
        {
            // Arrange
            wineManager.AddWineBottle(new WineBottle("Test Wine 1", "Vineyard A", "Location A", 2010, "Style B", "Cellar A", 10, 50.0m, 25.0m, "Tasting notes A"));
            wineManager.AddWineBottle(new WineBottle("Test Wine 2", "Vineyard B", "Location B", 2015, "Style A", "Cellar B", 5, 60.0m, 30.0m, "Tasting notes B"));

            // Act
            wineManager.SortWineBottles("Style", SortOrder.Ascending);

            // Assert
            var sortedStyles = wineManager.GetWineBottles().Select(b => b.Style).ToList();
            var expectedSortedStyles = new List<string> { "Style A", "Style B" };
            Assert.That(sortedStyles, Is.EqualTo(expectedSortedStyles));
        }

        [Test]
        public void TestFilterWineBottles()
        {
            // Arrange
            wineManager.AddWineBottle(new WineBottle("Test Wine 1", "Vineyard A", "Location A", 2010, "Style B", "Cellar A", 10, 50.0m, 25.0m, "Tasting notes A"));
            wineManager.AddWineBottle(new WineBottle("Test Wine 2", "Vineyard B", "Location B", 2015, "Style A", "Cellar B", 5, 60.0m, 30.0m, "Tasting notes B"));

            // Act
            var filteredBottles = wineManager.FilterWineBottles("Style", "A");

            // Assert
            Assert.That(filteredBottles.Count, Is.EqualTo(1));
            Assert.That(filteredBottles[0].Name, Is.EqualTo("Test Wine 2"));
        }
    }
}
