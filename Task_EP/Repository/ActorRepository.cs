using System;
using Task_EP.Classes;
using System.Collections.Generic;


namespace Task_EP.Repository
{
    public class ActorRepository : IRepository<Actor>
    {
        bool data;
        List<Actor> actorArr;

        public ActorRepository(bool data = false)
        {
            this.data = data;
            actorArr = new List<Actor>();
        }

        public void Add(Actor temp)
        {
            actorArr.Add(temp);
        }

        public List<Actor> Array()
        {
            return actorArr;
        }

        public void ChangeValue(int tempNumber, int newPrice)
        {
            throw new NotImplementedException();
        }

        public void GetMetodToRead()
        {
            throw new NotImplementedException();
        }

        public int GetSizeArr()
        {
            return actorArr.Count;
        }
        public  string PopularObjStr()
        {
            int maxRating = actorArr[0].GetRating();
            int i = 0;
            int index = 0;
            foreach (IClasses movie in actorArr)
            {
                if (maxRating < movie.GetRating())
                {
                    maxRating = movie.GetRating();
                    index = i;
                }
                i++;
            }
            
            return actorArr[index].ToString();
        }
       

        public void RemoveByIndex(int index)
        {
            index -= 1;
            actorArr.RemoveAt(index);
        }
    }
}
