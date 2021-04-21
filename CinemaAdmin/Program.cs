using System;
using CinemaAdmin.Editor;


namespace CinemaAdmin
{
    class Program
    {
        static void Main(string[] args)
        {

           
            CommandA comand = new CommandA();
           // MenuA menu = new MenuA();
            MenuA.Introdusing();
            bool generalOptionCycle = true, cycleOption = true;
            int choice = 0;

            while (generalOptionCycle)
            {

                MenuA.ShowMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {

                            cycleOption = true;
                            do
                            {

                                MenuA.ShowTicketMenu();
                                char operation1;
                                operation1 = Convert.ToChar(Console.ReadLine());
                                if (operation1 == 'A')
                                {

                                    comand.Write("Ticket");
                                }
                                else if (operation1 == 'B')
                                {

                                    comand.ChangeTicket();
                                }
                                else if (operation1 == 'C')
                                {
                                   
                                        comand.AddTicket();
                                }
                                else if (operation1 == 'D')
                                {
                                    comand.Write("Ticket");
                                    comand.RemoveByIndexTicket();
                                }
                                else if (operation1 == 'E')
                                {
                                    comand.PopularMovie();
                                }
                                else
                                {
                                    cycleOption = false;

                                }
                            }
                            while (cycleOption);
                        }
                        break;

                    case 2:
                        {

                            cycleOption = true;
                            do
                            {
                                MenuA.ShowMenuHuman();
                                int operation2 = Convert.ToInt32(Console.ReadLine());
                                bool adminInput = true, adminInput2 = true;
                                if (operation2 == 1)
                                {
                                    while (adminInput)
                                    {
                                        MenuA.ShowActorMenu();
                                        char operation3A = Convert.ToChar(Console.ReadLine());
                                        switch (operation3A)
                                        {
                                            case 'A': 
                                                comand.Write("Actor");
                                                
                                                break;
                                            case 'B':
                                                {
                                                    comand.PopularActor();
                                                }
                                                break;
                                            case 'C':
                                                {
                                                        comand.AddActor();
                                                }
                                                break;
                                            case 'D':
                                                {
                                                    comand.Write("Actor");
                                                    comand.RemoveByIndexActor();
                                                }
                                                break;

                                            case 'E':
                                                {
                                                    adminInput = false;
                                                    Console.Clear();
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                }

                                if (operation2 == 2)
                                {

                                    while (adminInput2)
                                    {
                                        MenuA.ShowClientMenu();
                                        char operation3 = Convert.ToChar(Console.ReadLine());
                                        switch (operation3)
                                        {
                                            case 'A':
                                                {
                                                    comand.Write("Client");
                                                }
                                                break;
                                            case 'B':
                                                {
                                                    comand.PrintRespones();
                                                }
                                                break;
                                            case 'C':
                                                {
                                                    comand.Write("Client");
                                                    comand.RemoveByIndexClient();
                                                }
                                                break;
                                            case 'E':
                                                {
                                                    comand.ShowPopcorn();
                                                }
                                                break;
                                            case 'D':
                                                {
                                                    adminInput2 = false;
                                                }
                                                break;
                                        }
                                    }
                                }
                                else
                                {

                                    cycleOption = false;
                                }
                            } while (cycleOption);
                        }
                        break;
                    case 3:
                        {
                            generalOptionCycle = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Error! Try again");
                        }
                        break;
                }			
            }

		}
	}
}
