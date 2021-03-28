using NUnit.Framework;
using FightingArena; //remove for test
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProperlyInitializeConstrictor()
        {
            string name = "a";
            int damage = 10;
            int hp = 10;

            Warrior w = new Warrior(name, damage, hp);

            Assert.IsNotNull(w);
            Assert.AreEqual(name, w.Name);
            Assert.AreEqual(damage, w.Damage);
            Assert.AreEqual(hp, w.HP);
        }

        [Test]
        [TestCase("", 10, 10)]
        [TestCase("    ", 10, 10)]
        [TestCase(null, 10, 10)]
        [TestCase("name", 0, 10)]
        [TestCase("name", -10, 10)]
        [TestCase("name", 10, -5)]
        public void When_IsInitializedWrongShould_ThrowException(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior w = new Warrior(name, damage, hp);
            });
        }

        [Test]
        public void When_ProperlyAttackedBothSidesShould_LoseHealth()
        {
            int initialHealth = 150;
            int attackDamage = 50;
            Warrior a = new Warrior("Attack", attackDamage, initialHealth);
            Warrior b = new Warrior("Defend", attackDamage, initialHealth);

            a.Attack(b);

            Assert.AreEqual(initialHealth - attackDamage, a.HP);
            Assert.AreEqual(initialHealth - attackDamage, b.HP);
        }

        [Test]
        public void When_AttackingWithLowHPShould_ThrowException()
        {
            Warrior a = new Warrior("Attack", 50, 15);
            Warrior b = new Warrior("Attack", 5, 50);

            Assert.Throws<InvalidOperationException>(() =>
            {
                a.Attack(b);
            });
        }

        [Test]
        public void WhenAttackingEnemyWithLowHPShould_ThrowException()
        {
            Warrior a = new Warrior("Attack", 50, 50);
            Warrior b = new Warrior("Attack", 5, 15);

            Assert.Throws<InvalidOperationException>(() =>
            {
                a.Attack(b);
            });
        }

        [Test]
        public void When_HPIsLowerThanEnemyDamageShould_ThrowException()
        {
            Warrior a = new Warrior("Attack", 50, 50);
            Warrior b = new Warrior("Attack", 60, 60);

            Assert.Throws<InvalidOperationException>(() =>
            {
                a.Attack(b);
            });
        }

        [Test]
        public void When_EnemyHPIsSmallerThanSelfDamageShould_BeSetToZero()
        {
            Warrior a = new Warrior("Attack", 60, 60);
            Warrior b = new Warrior("Attack", 50, 50);

            a.Attack(b);

            Assert.AreEqual(0, b.HP);
        }

    }
}