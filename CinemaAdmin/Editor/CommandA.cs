using System;
using Task_EP.Repository;
using Task_EP.Classes;
using Task_EP.Pattern;
using Task_EP.Response;


namespace CinemaAdmin.Editor
{
    class CommandA
    {
        AbstractFactoryPattern abstractF = null;
        IRepository<Actor> actorrep = null;
        IRepository<Client> clientrep = null;
        IRepository<Ticket> ticketrep = null;

        ResponseFile respones = null;
        
       
        public CommandA()
        {
          
            abstractF = HelperCreateRep.CreateRepositoryOfPattern();//file
            actorrep = abstractF.GetRepositoryActor();
            clientrep = abstractF.GetRepositoryClient();
            ticketrep = abstractF.GetRepositoryTicket();

            respones = new ResponseFile();
           
        }
        public void AddTicket()
        {
            bool optionCyc = true;
            do
            {
                try
                {
                    Ticket temp = new Ticket();
                    Console.Write("Input name of movie: ");
                    string nameM = Console.ReadLine();
                    temp.NameMovie = nameM;

                    Console.Write("Input genre: ");
                    string genreT = Console.ReadLine();
                    temp.Genre = genreT;

                    Console.Write("Input kind of movie: ");
                    string kindM = Console.ReadLine();
                    temp.KindM = kindM;

                    Console.Write("Input rating: ");
                    string ratingStr = Console.ReadLine();
                    temp.Rating = Convert.ToInt32(ratingStr);

                    Console.Write("Input price: ");
                    string priceStr = Console.ReadLine();
                    temp.Price = (Convert.ToInt32(priceStr));
                    ticketrep.Add(temp);
                    Console.WriteLine("sucessfully added a ticket!\n");
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
                    optionCyc = true;
                }
                else { optionCyc = false; }
            } while (optionCyc);
            Console.ReadKey();
            Console.Clear();
        }

        public void AddClient()
        {
        bool y = true;
        do
        {
            try
            {
                Client temp = new Client();
                Console.Write("Input your  name: ");
                string name = Console.ReadLine();
                temp.FirstName = name;

                Console.Write("Input your Home Town: ");
                string homeTown = Console.ReadLine();
                temp.HomeTown = homeTown;

                Console.Write("Input movies you want to see: ");
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
                y = true;
                    
            }
            else { y = false; }
        } while (y);
            Console.ReadKey();
            Console.Clear();
        }

        public void AddActor()
        {
            bool y = true;
            do
            {

                try
                {
                    Actor temp = new Actor();
                    Console.Write("Input name of actor: ");
                    string name = Console.ReadLine();
                    temp.FirstName = name;

                    Console.Write("Input Home Town: ");
                    string homeTown = Console.ReadLine();
                    temp.HomeTown = homeTown;

                    Console.Write($"Input count of movies {name} acted: ");
                    int countOfMovie = Convert.ToInt32(Console.ReadLine());
                    temp.CountOfMovie = countOfMovie;

                    Console.Write($"Input {name}'s rating: ");
                    int rating = Convert.ToInt32(Console.ReadLine());
                    temp.Rating = rating;

                    actorrep.Add(temp);
                    Console.WriteLine("sucessfully added an  actor!\n");
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
                    y = true;
                }
                else { y = false; }
            } while (y);
            Console.ReadKey();
            Console.Clear();
           
        }
        public void PrintRespones()
        {
            respones.MetodToRead();
            Console.WriteLine("---------------------------------------------"
                   + "----------------------------------------------"
                   + "--------------------------");
            if (respones.GetSizeArr() > 0)
            {
                foreach (string elem in respones.ResponesList())
                {
                    Console.WriteLine("\t" + elem);
                }
            }
            else { 
                Console.WriteLine(" Sorry!\n There aren't any respones!"); 
            }
           
            Console.WriteLine("---------------------------------------------"
                   + "----------------------------------------------"
                   + "--------------------------");
            Console.ReadKey();
        }
        public void RemoveByIndexActor()
        {
            try
            {
               
                Console.Write("\nInput the index to remove element:");
                int index = Convert.ToInt32(Console.ReadLine());
                actorrep.RemoveByIndex(index);

                Console.WriteLine("sucessfully remove an  actor!\n");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error during remove from array: {ex.Message}");
                
            }
        }
        public void RemoveByIndexTicket()
        {
            try
            {
                Console.Write("\nInput the index to remove element:");
                int index = Convert.ToInt32(Console.ReadLine());
                ticketrep.RemoveByIndex(index);

                Console.WriteLine("sucessfully remove a ticket!\n");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error during remove from array: {ex.Message}");

            }
        }
        public void RemoveByIndexClient()
        {
            try
            {
                Console.Write("\nInput the index to remove element:");
                int index = Convert.ToInt32(Console.ReadLine());
                clientrep.RemoveByIndex(index);

                Console.WriteLine("sucessfully remove an  actor!\n");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error during remove from array: {ex.Message}");

            }
        }
        public void ChangeTicket()
        {
            Console.WriteLine("Input rating to change the price." +
                "\n(If current rating was bigger than rating of objects in array,It'd change!)");
            int tempRating = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input new price: ");
            int tempPrice = Convert.ToInt32(Console.ReadLine());

            ticketrep.ChangeValue(tempRating, tempPrice);
            Console.ReadKey();
            Console.Clear();
        }


        public void PopularActor()
        {

            actorrep.GetMetodToRead();
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
        public void PopularMovie()
        {
            ticketrep.GetMetodToRead();
            
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

        public void  ShowPopcorn()
        {
            PopCorn popCorn = new PopCorn();
            Console.WriteLine("----------------------------------");

           Console.WriteLine(popCorn.StringInfo());
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public void Write(string str)
        {
            ticketrep.GetMetodToRead();
            actorrep.GetMetodToRead();
            clientrep.GetMetodToRead();
            Console.WriteLine("---------------------------------------------"
                        + "----------------------------------------------"
                        + "--------------------------");
            if (str == "Ticket")
            {
                foreach(IClasses tickt in ticketrep.Array())
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
            else if (str == "Client")
            {
                foreach (IClasses client in clientrep.Array())
                {
                    Console.WriteLine(client);
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
