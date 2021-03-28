using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    public void When_AttackShould_LoseDurability()
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe durability problem");
    }

    [Test]
    public void When_AxeIsZeroShould_ThrowException()
    {
        Axe brokenAxe = new Axe(10, 0);
        Dummy dummy = new Dummy(10, 10);

        Assert.Throws<InvalidOperationException>(() => { brokenAxe.Attack(dummy); });
    }
}