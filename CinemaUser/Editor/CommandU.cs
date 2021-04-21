using System;
using Task_EP.Repository;
using Task_EP.Classes;
using Task_EP.FileRepository;
using Task_EP.Pattern;



namespace CinemaUser.Editor
{
    class CommandU
    {
        AbstractFactoryPattern abstractF = null;
        IRepository<Actor> actorrep = null;
        IRepository<Client> clientrep = null;
        IRepository<Ticket> ticketrep = null;


        public CommandU()
        {
           // HelperNameObject nameObject = new HelperNameObject();

            abstractF = HelperCreateRep.CreateRepositoryOfPattern();//file
            actorrep = abstractF.GetRepositoryActor();
            clientrep = abstractF.GetRepositoryClient();
            ticketrep = abstractF.GetRepositoryTicket();
        }
        public void addClient()
        {
            bool choice = true;
            do
            {
                try
                {
                    Client temp = new Client();
                    Console.WriteLine("Input your  name: ");
                    string name = Console.ReadLine();
                    temp.FirstName = name;

                    Console.WriteLine("Input your Home Town: ");
                    string homeTown = Console.ReadLine();
                    temp.HomeTown = homeTown;

                    Console.WriteLine("Input movies you want to see: ");
                    string movie = Console.ReadLine();
                    temp.Movie = movie;


                    clientrep.Add(temp);
                    Console.WriteLine("sucessfully added a client!\n");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("\t\t\t\tError 404!\n\t\t\tIncorrect option!");
                    Console.ReadKey();
                }
                Console.WriteLine("\t\tTo add one more ticket please enter 'more'\n"
                                              + "\t\t   in another way enter 'nope': ");
                string answer = Console.ReadLine();

                if (answer == "more")
                {
                    choice = true;

                }
                else { choice = false; }
            } while (choice);
            Console.ReadKey();
            Console.Clear();
        }

        
        public void popularActor()
        {
            //int index = actorrep.PopularObj();
            Console.WriteLine("--------------------------------------\n"
                       + "| Result of the most popular actor: |");
            Console.WriteLine("---------------------------------------------"
                     + "----------------------------------------------"
                     + "--------------------------");
            Console.WriteLine(actorrep.PopularObjStr());
            Console.WriteLine("---------------------------------------------"
                     + "----------------------------------------------"
                     + "--------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public void popularMovie()
        {
           // int indexTemp = ticketrep.PopularObj();
            Console.WriteLine("--------------------------------------\n"
                     + "| Result of the most popular movie: |");
            Console.WriteLine("---------------------------------------------"
                       + "----------------------------------------------"
                       + "--------------------------");
            Console.WriteLine(ticketrep.PopularObjStr());
            Console.WriteLine("---------------------------------------------"
                       + "----------------------------------------------"
                       + "--------------------------");
            Console.ReadKey();
            Console.Clear();
        }

        public void write(string str)
        {

            Console.WriteLine("---------------------------------------------"
                       + "----------------------------------------------"
                       + "--------------------------");
            if (str == "Ticket")
            {
                foreach (IClasses tickt in ticketrep.Array())
                {
                    Console.WriteLine(tickt);
                }
            }
            else if (str == "Actor")
            {
                foreach (IClasses actor in actorrep.Array())
                {
                    Console.WriteLine(actor);
                }

            }
            Console.WriteLine("---------------------------------------------"
                        + "----------------------------------------------"
                        + "--------------------------");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
