using BR.Tamagotchi.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BR.Tamagotchi.Test
{
    [TestClass]
    public class DragonTests
    {
        [TestMethod]
        public void PetTest()
        {
            //Arrange
            Dragon dragon = new Dragon("PetTest");
            //Act
            dragon.Pet();

            //Assert
            Assert.AreEqual(8, dragon.Happiness);
        }

        [TestMethod]
        public void FeedTest()
        {
            //Arrange
            Dragon dragon = new Dragon("FeedTest");
            //Act
            dragon.Feed();

            //Assert
            Assert.AreEqual(2, dragon.HungerLevel);
            Assert.AreEqual(2, dragon.Weight);
        }

        [TestMethod]
        public void PlayTest()
        {
            //Arrange
            Dragon dragon = new Dragon("PlayTest");
            //Act
            dragon.Play();

            //Assert
            Assert.AreEqual(6, dragon.HungerLevel);
            Assert.AreEqual(1, dragon.Weight);
            Assert.AreEqual(10, dragon.Happiness);
        }

        [TestMethod]
        public void DragonTest()
        {
            //Arrange
            Dragon dragon;
            //Act
            dragon= new Dragon("DragonTest");

            //Assert
            Assert.AreEqual("DragonTest", dragon.Name);
            Assert.AreEqual(1, dragon.Age);
            Assert.AreEqual(5, dragon.HungerLevel);
            Assert.AreEqual(1, dragon.Weight);
            Assert.AreEqual(5, dragon.Happiness);
            Assert.AreEqual(Life.Baby, dragon.Life);
        }
    }
}
