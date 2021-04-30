using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Task_EP.Classes;
using Task_EP.Repository;

namespace CinemaUnitTest
{
    [TestClass]
    public class TestActors
    {
        [TestMethod]
        public void TestTheMostPopularActor_Returns_ActorwithTheBiggestRatting()
        {
            ActorRepository actors = new ActorRepository();
            
            actors.Add(new Actor("Emilia", "Lviv", 5, 1));
            actors.Add(new Actor("John", "Lviv", 5, 3));
            actors.Add(new Actor("Billy", "Kyiv", 5, 10));

            string thisResult = actors.PopularObjStr();

            string expectedResult=actors.ReturnActorInArrByIndex(2).ToString();

            //assert
            Assert.AreEqual(thisResult, expectedResult);
        }

        [TestMethod]
        public void TestAddNewActor_Returns_True()
        {
            ActorRepository actors = new ActorRepository();

            actors.Add(new Actor("Emilia", "Lviv", 5, 1));
            actors.Add(new Actor("John", "Lviv", 5, 3));
            actors.Add(new Actor("Billy", "Kyiv", 5, 10));

            bool result = actors.HasElement(new Actor("Emilia", "Lviv", 5, 1));
            
            //assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void  TestRemoveActorByIndex_Returns_False()
        {
            ActorRepository actors = new ActorRepository();

            actors.Add(new Actor("Emilia", "Lviv", 5, 1));
            actors.Add(new Actor("John", "Lviv", 5, 3));
            actors.Add(new Actor("Billy", "Kyiv", 5, 10));

            actors.RemoveByIndex(1);// will be removed index=0

            Actor actorTemp = new Actor("Emilia", "Lviv", 5, 1);

            bool result = actors.IsExist(actorTemp);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSizeOfActorList_Returns_SizeList()
        {
            IRepository<Actor> actors = new ActorRepository();

            actors.Add(new Actor("Emilia", "Lviv", 5, 1));
            actors.Add(new Actor("John", "Lviv", 6, 3));
            actors.Add(new Actor("Billy", "Kyiv", 10, 10));

            int sizeActual = actors.GetSizeArr();
            int sizeExpected = actors.Array().Count;

            //assert
            Assert.AreEqual(sizeActual, sizeExpected);
        }
    }
}
