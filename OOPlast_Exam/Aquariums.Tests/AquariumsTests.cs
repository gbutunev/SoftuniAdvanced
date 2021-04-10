namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AquariumsTests
    {
        //ignore awful names and setup usage
        Aquarium a;

        [SetUp]
        public void Setup()
        {
            a = new Aquarium("asdf", 1);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void IncorrectName(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium b = new Aquarium(name, 50);
            });
        }

        [Test]
        public void IncorrectCap()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium b = new Aquarium("asdfas", -5);
            });
        }

        [Test]
        public void InitCorrect()
        {
            Aquarium b = new Aquarium("asdfs", 50);

            Assert.AreEqual(0, b.Count);
        }

        [Test]
        public void TankFull()
        {
            Fish f1 = new Fish("1");
            Fish f2 = new Fish("2");

            a.Add(f1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                a.Add(f2);
            });
        }

        [Test]
        public void NormalTank()
        {
            Fish f1 = new Fish("1");

            a.Add(f1);

            Assert.AreEqual(1, a.Count);
        }

        [Test]
        public void RemoveThrows()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                a.RemoveFish("asdf");
            });
        }

        [Test]
        public void Normalremove()
        {
            Fish f1 = new Fish("1");

            a.Add(f1);

            a.RemoveFish("1");

            Assert.AreEqual(0, a.Count);
        }

        [Test]
        public void SellThrows()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                a.SellFish("123");
            });
        }

        [Test]
        public void SellNorm()
        {
            Fish f1 = new Fish("1");

            a.Add(f1);

            Fish sold = a.SellFish("1");

            Assert.That(sold == f1);
            Assert.IsFalse(f1.Available);
        }

        [Test]
        public void Report()
        {
            Fish f1 = new Fish("1");
            string expected = $"Fish available at {a.Name}: {f1.Name}";

            a.Add(f1);
            string report = a.Report();

            Assert.That(expected == report);
        }
    }
}
