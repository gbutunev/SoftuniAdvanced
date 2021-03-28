using NUnit.Framework;
using FightingArena; //remove for test
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void ProperlyInitializeWithConstructor()
        {
            Assert.IsNotNull(arena);
            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void ProperlyEnrollWarriorInArena()
        {
            Warrior w = new Warrior("a", 50, 50);

            arena.Enroll(w);

            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        public void CheckIfWarriorIsInArena()
        {
            Warrior w = new Warrior("a", 50, 50);

            arena.Enroll(w);

            Assert.IsTrue(arena.Warriors.Any(w => w.Name == "a"));
        }

        [Test]
        public void When_DuplicateWarriorIsAddedShould_ThrowException()
        {
            Warrior w1 = new Warrior("a", 50, 50);
            Warrior w2 = new Warrior("a", 60, 60);

            arena.Enroll(w1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(w2);
            });
        }

        [Test]
        [TestCase("", "warrior")]
        [TestCase("   ", "warrior")]
        [TestCase("asdf", "warrior")]
        [TestCase(null, "warrior")]
        [TestCase("warrior", "")]
        [TestCase("warrior", "    ")]
        [TestCase("warrior", "asdf")]
        [TestCase("warrior", null)]
        [TestCase("asdf", "qwer")]

        public void When_FightIsStartedWithNonExistentWarriorsShould_ThrowException(string name1, string name2)
        {
            Warrior w = new Warrior("warrior", 50, 50);

            arena.Enroll(w);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(name1, name2);
            });
        }

        [Test]
        public void When_BothWarriorsAreValidShould_Fight()
        {
            Warrior a = new Warrior("Attack", 60, 60);
            Warrior b = new Warrior("Defend", 50, 50);

            arena.Enroll(a);
            arena.Enroll(b);

            arena.Fight("Attack", "Defend");

            Assert.AreEqual(10, a.HP);
            Assert.AreEqual(0, b.HP);
        }
    }
}
