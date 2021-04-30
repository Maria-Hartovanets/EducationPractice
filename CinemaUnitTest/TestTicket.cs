using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Task_EP.Classes;
using Task_EP.Repository;
using Task_EP.FileRepository;

namespace CinemaUnitTest
{
    [TestClass]
   public  class TestTicket
    {
        [TestMethod]
        public void TestTicketChangePrice_Returns_True()
        {
            Ticket ticket = new Ticket("Wally", "catroon", 7, 100, "3D");
            ticket.ChangePrice(999);

            Ticket ticketSimple = new Ticket("Wally", "catroon", 7, 999, "3D");

            //assert
            Assert.IsTrue(ticket.Equals(ticketSimple));
        }

        [TestMethod]
        public void TestCopyConstructor_Returns_TheSameInfoInNewTicket()
        {
            Ticket ticket = new Ticket("Wally", "catroon", 7, 100, "3D");
            Ticket copyTicket = new Ticket(ticket);

            //assert
            Assert.IsTrue(ticket.Equals(copyTicket));
        }

        [TestMethod]
        public void TestAdditionOperator_Returns_True()
        {
            Ticket ticket = new Ticket("Wally", "catroon", 7, 100, "3D");
            ticket++;//+100 to Price

            Ticket ticketEgual = new Ticket("Wally", "catroon", 7, 200, "3D");

            //assert
            Assert.IsTrue(ticket.Equals(ticketEgual));
        }

        [TestMethod]
        public void TestWorstMovie_Returns_True()
        {
            TicketFileRepository tickets = new TicketFileRepository();

            /*
             Ferrari thriller 9 123 4DX
             Saw_9 horror 10 123 4D
             Wall-E cartoon 8 130 2D
             Clouds drama 9 150 3D
             Tom&Jerry Cartoon 7 120 3D
             sheriff thrill 5 120 3D
             */
            Ticket ticketExpected = new Ticket("sheriff", "thrill", 5, 120, "3D");

           bool result= tickets.TheWorstTicket().Equals(ticketExpected);

            //assert
            Assert.IsTrue(result);

        }
    }
}
