using System;


namespace CinemaAdmin.Editor
{
    static class MenuA
    {
		public static void Introdusing()
        {
			Console.WriteLine("\t\t\t\tAdmin work.WELCOME to the menu of cinema!\n" +
						 "\t\t\t\t\tNow we are ready to start! ");
			Console.ReadKey();
		}
		public static void ShowMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\tAdmin menu." 
			+ "\n\t\t\t\t\t1. Do actions with movies."
			+ "\n\t\t\t\t\t2. Show 'menu of humans'."
			+ "\n\t\t\t\t\t3. To finish the programm."
			+ "\nYour choice:");
		}


		public static void ShowTicketMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tTicket setting:"
			+ "\n\t\t\t\tA. Show infomation(w/ price) of all movies."
			+ "\n\t\t\t\tB. Change ticket of movie."
			+ "\n\t\t\t\tC. Add new ticket of movie."
			+ "\n\t\t\t\tD. Remove a ticket of movie."
			+ "\n\t\t\t\tE. Show the most popular movie."
			+ "\n\t\t\t\tF. Back.");
		}

		public static void ShowMenuHuman()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tHuman setting:"
			+ "\n\t\t\t\t1. Do actions with actors."
			+ "\n\t\t\t\t2. Do actions with clients."
			+ "\n\t\t\t\t3. Back.");
		}

		public static void ShowActorMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tActor setting:"
			+ "\n\t\t\t\tA.  Show all actors." 
			+ "\n\t\t\t\tB.  Show the most popular actor."
			+ "\n\t\t\t\tC.  Add an actor."
			+ "\n\t\t\t\tD.  Remove an actor."
			+ "\n\t\t\t\tE.  Back.");
		}

		public static void ShowClientMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tClient setting:"
				+ "\n\t\t\t\tA.  Show clients from data file."
				+ "\n\t\t\t\tB.  Show respones of clients."
				+ "\n\t\t\t\tC.  Remove all clients."
				//+ "\n\t\t\t\tD.  Show sold tastes of pop-corn."
				+ "\n\t\t\t\tD.  Back.");

		}


	}
}
