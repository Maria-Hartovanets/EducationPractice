using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Task_EP.Classes;
using Task_EP.FileRepository;
using Task_EP.Response;


namespace CinemaUnitTest
{

    [TestClass]
    public class TestClient
    {

        [TestMethod]
        public void TestConstructorCopy_Returns_True()
        {
            Client client = new Client("Maria", "Lviv", "Wally");

            Client newClient = new Client(client);

            //assert
            Assert.IsTrue(client.Equals(newClient));
        }

        [TestMethod]
        public void TestFileOperation_Returns_True()
        {
            ResponseFile responseFile = new ResponseFile();

            responseFile.AddResponse("Yura: Great!");

            string str = "Yura: Great!";
            bool result=responseFile.IsExist(str);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFileClient_Returns_True()
        {
            ClientFileRepository clientFile = new ClientFileRepository();
            /*Maria Lviv Wall-y
              Yura lviv Saw_9
              Nadia Kyiv Ferrari
              Dada Lviv ferrari
              Davyd Lviv Saw_9*/
            clientFile.RemoveAllItems();

            //assert
            Assert.AreEqual(clientFile.Array().Count, 0);
        }

    }
}
