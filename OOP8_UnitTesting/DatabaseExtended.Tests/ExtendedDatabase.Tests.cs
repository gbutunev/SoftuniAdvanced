using NUnit.Framework;
using System;
using ExtendedDatabase; // Remove for submit

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        ExtendedDatabase.ExtendedDatabase db; // Remove for submit

        [SetUp]
        public void Setup()
        {
            db = new ExtendedDatabase.ExtendedDatabase(); // Remove for submit
        }

        [Test]
        public void CorrectlyInitializeConstructorWithNoParams()
        {
            Assert.AreEqual(0, db.Count);
        }

        [Test]
        public void CorrectlyInitializeConstructorWithParams()
        {
            int count = 15;
            Person[] people = new Person[count];
            for (int i = 0; i < count; i++)
            {
                people[i] = new Person(i, "" + i);
            }
        }

        [Test]
        public void InitializeConstructorWithMoreThanMaximumAmountOfParams()
        {
            int count = 20;
            Person[] people = new Person[count];
            for (int i = 0; i < count; i++)
            {
                people[i] = new Person(i, "" + i);
            }
        }

        [Test]
        public void AddPeopleCorrectly()
        {
            db.Add(new Person(1, "a"));
            db.Add(new Person(2, "b"));

            Assert.AreEqual(2, db.Count);
        }

        [Test]
        public void AddMoreThan16People()
        {
            int count = 16;
            for (int i = 0; i < count; i++)
            {
                db.Add(new Person(i, "" + i));
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(23, "asdf"));
            });
        }

        [Test]
        [TestCase(1, "a", 1, "b")]
        [TestCase(1, "a", 2, "a")]
        public void When_TryingToAddExistingPersonShould_ThrowException(long id1, string name1, long id2, string name2)
        {
            Person p1 = new Person(id1, name1);
            Person p2 = new Person(id2, name2);

            db.Add(p1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(p2);
            });
        }

        [Test]
        public void CorrectlyRemovePerson()
        {
            db.Add(new Person(1, "1"));

            db.Remove();

            Assert.AreEqual(0, db.Count);
        }

        [Test]
        public void When_RemovingPersonFromEmptyDbShould_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            });
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void When_SearchingWithWrongNameShould_ThrowException(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                db.FindByUsername(name);
            });
        }

        [Test]
        public void When_SearchingWithWrongIdShould_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindByUsername("asdf");
            });
        }

        [Test]
        public void When_SearchingWithIdOutOfRangeShould_ThrowException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                db.FindById(-7);
            });
        }

        [Test]
        public void When_SearchingWithNonExistentIdShould_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindById(2);
            });
        }

        [Test]
        public void CorrectlyFindPersonByName()
        {
            db.Add(new Person(1, "a"));

            Person p = db.FindByUsername("a");

            Assert.IsNotNull(p);
        }

        [Test]
        public void CorrectlyFindPersonById()
        {
            db.Add(new Person(1, "a"));

            Person p = db.FindById(1);

            Assert.IsNotNull(p);
        }
    }
}