using System;
using CinemaUser.Editor;

namespace CinemaUser
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandU comand = new CommandU();

            MenuU.Introdusing();

            bool doingCycle = true, cycleOption = true;
            int choice = 0;

            while (doingCycle)
            {
                MenuU.ShowMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            cycleOption = true;
                            do
                            {

                                MenuU.ShowTicketMenu();
                                char operation1;
                                operation1 = Convert.ToChar(Console.ReadLine());
                                if (operation1 == 'A')
                                {

                                    comand.write("Ticket");
                                }
                                else if (operation1 == 'B')
                                {
                                    comand.popularMovie();
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
                                MenuU.ShowActorMenu();
                                char operation3 = Convert.ToChar(Console.ReadLine());
                                if (operation3 == 'A')
                                {
                                    comand.write("Actor");
                                }
                                else if (operation3 == 'B')
                                {

                                    comand.popularActor();
                                }
                                else
                                {
                                    cycleOption = false;
                                }
                            }
                            while (cycleOption);
                        }
                        break;
                    case 3:
                        {

                            cycleOption = true;
                            do
                            {
                                MenuU.ShowClientMenu();
                                char operation4 = Convert.ToChar(Console.ReadLine());
                                if (operation4 == 'A')
                                {
                                    comand.addClient();
                                }

                                else
                                {
                                    cycleOption = false;
                                }
                            }
                            while (cycleOption);
                        }
                        break;

                    case 4:
                        {
                            doingCycle = false;
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
