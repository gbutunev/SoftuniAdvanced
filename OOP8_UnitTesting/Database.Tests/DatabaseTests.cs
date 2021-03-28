using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        Database.Database db;

        [SetUp]
        public void Setup()
        {
            db = new Database.Database();
        }

        [Test]
        public void CorrectlyInitializeDatabase()
        {
            int count = 10;
            for (int i = 0; i < count; i++)
            {
                db.Add(i);
            }

            Assert.AreEqual(count, db.Count);
        }

        [Test]
        public void InitializeDatabaseWithMoreThan16Values()
        {
            int count = 20;

            Assert.Throws<InvalidOperationException>(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    db.Add(i);
                }
            });
        }

        [Test]
        public void When_Adding17thElementShould_ThrowException()
        {
            int count = 16;
            for (int i = 0; i < count; i++)
            {
                db.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(17);
            });
        }

        [Test]
        public void CorrectlyRemoveFromDatabase()
        {
            db.Add(5);
            db.Add(6);

            db.Remove();

            Assert.AreEqual(1, db.Count);
        }

        [Test]
        public void When_RemovingFromEmptyDatabaseShould_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            });
        }

        [Test]
        public void When_UsingFetchMethodShould_ReturnCopyOfTheArray()
        {
            db.Add(5);
            db.Add(6);

            int[] arr1 = db.Fetch();
            int[] arr2 = db.Fetch();

            Assert.IsFalse(ReferenceEquals(arr1, arr2));
        }
    }
}