using System;


namespace CinemaUser.Editor
{
    static class MenuU
    {
		public static void Introdusing()
        {
			Console.WriteLine("\t\t\t\t\tDear Sir / Madam,\n"
		 + "\t\t\t\tWELCOME to the menu of cinema!\n" +
			"\t\t\t\t  Now we are ready to start! ");
			Console.ReadKey();
		}
		public static void ShowMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\tUser menu."  
			+ "\n\t\t\t\t\t1. Do actions with movies."
			+ "\n\t\t\t\t\t2. Show info of actors."
			+ "\n\t\t\t\t\t3. Make an order(buy a ticket)."
			+ "\n\t\t\t\t\t4. To finish the programm."
			+ "\nYour choice:");
		}

		public static void ShowTicketMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tTicket setting:"
			+ "\n\t\t\t\tA. Show infomation(w/ price) of all movies."
			+ "\n\t\t\t\tB. Show the most popular movie."
			+ "\n\t\t\t\tC. Back.");
		}

		public static void ShowActorMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tActor setting:"
			+ "\n\t\t\t\tA.  Show actors."
			+ "\n\t\t\t\tB.  Show the most popular actor."
			+ "\n\t\t\t\tC.  Back.");
		}

		public static void ShowClientMenu()
		{
			Console.Clear();
			Console.WriteLine("\n\t\t\t\t\t\tClient setting:"
				+ "\n\t\t\t\tA.  Make an order."
				+ "\n\t\t\t\tB.  Back.");

		}
	}
}
