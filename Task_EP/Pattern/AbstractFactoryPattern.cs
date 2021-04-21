using System;
using Task_EP.FileRepository;
using Task_EP.Repository;
using System.Configuration;
using Task_EP.Classes; 


namespace Task_EP.Pattern
{
    public interface AbstractFactoryPattern
    {
       
        IRepository<Ticket> GetRepositoryTicket();

        IRepository<Actor> GetRepositoryActor();
        IRepository<Client> GetRepositoryClient();

    }
}
