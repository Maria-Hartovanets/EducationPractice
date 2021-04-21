using System;
using Task_EP.Repository;
using Task_EP.FileRepository;
using Task_EP.Classes;

namespace Task_EP.Pattern
{
    public class RealizationPattern : AbstractFactoryPattern
    {
        //public override IRepository GetRepository(string getOneRepository)
        //{
        //    HelperNameObject nameObject = new HelperNameObject();

        //    if (getOneRepository.Equals(nameObject.Actor))
        //        return new ActorRepository();
        //    else if (getOneRepository.Equals(nameObject.Client))
        //        return new ClientRepository();
        //    else if (getOneRepository.Equals(nameObject.Ticket))
        //        return new TicketRepository();
        //    else
        //        return null;
        //}

        public IRepository<Actor> GetRepositoryActor()
        {
            return new ActorRepository();
        }

        public IRepository<Client> GetRepositoryClient()
        {
            return new ClientRepository();
        }

        public IRepository<Ticket> GetRepositoryTicket()
        {
            return new TicketRepository();
        }
    }
    public class RealizationPatternFile : AbstractFactoryPattern
    {
        public IRepository<Actor> GetRepositoryActor()
        {
            return new ActorFileRepository();
        }

        public IRepository<Client> GetRepositoryClient()
        {
            return new ClientFileRepository();
        }

        public IRepository<Ticket> GetRepositoryTicket()
        {
            return new TicketFileRepository();
        }
    }



}
