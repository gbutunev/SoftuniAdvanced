using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;

    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(2, 30);
    }
    [Test]
    public void When_AttackedShould_LoseHealth()
    {
        int damagePoints = 1;
        int dummyInitHealth = dummy.Health;

        dummy.TakeAttack(damagePoints);

        Assert.AreEqual(dummy.Health, dummyInitHealth - damagePoints);
    }

    [Test]
    public void When_DeadDummyIsAttackedShould_ThrowException()
    {
        dummy.TakeAttack(2);

        Assert.Throws<InvalidOperationException>(() =>
        {
            dummy.TakeAttack(2);
        });
    }

    [Test]
    public void When_GiveExpAliveShould_ThrowException()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            dummy.GiveExperience();
        });
    }

    [Test]
    public void When_IsDeadShould_GiveXP()
    {
        dummy.TakeAttack(5);

        Assert.NotNull(dummy.GiveExperience());
    }

    [Test]
    public void WorkingConstructor()
    {
        int health = 5;
        Dummy dummy = new Dummy(health, 20);

        Assert.AreEqual(health, dummy.Health);
    }

    [Test]
    public void DummyGivesCorrectXP()
    {
        int xp = 50;
        int health = 5;
        Dummy dummy = new Dummy(health, xp);
        dummy.TakeAttack(health);

        Assert.AreEqual(xp, dummy.GiveExperience());
    }
}
