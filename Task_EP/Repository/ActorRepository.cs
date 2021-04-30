using System;
using System.Collections.Generic;
using Task_EP.Classes;
using System.Linq;


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
            foreach (IClasses actor in actorArr)
            {
                if (tempNumber == actor.GetRating())
                {
                    actor.ChangePrice(newPrice);
                }
            }
        }

        public void GetMetodToRead()
        {
            throw new NotImplementedException();
        }

        public int GetSizeArr()
        {
            return (actorArr.Count == 0) ? 0 : actorArr.Count;
        }
        public string PopularObjStr()
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


        public Actor ReturnActorInArrByIndex(int index)
        {
            return actorArr[index];
        }

        public bool IsExist(Actor elem)
        {           
            return actorArr.Any(i=>i.Equals(elem));
        }

        public bool HasElement(Actor elem)
        {
            bool result = false;
            foreach(Actor item in actorArr)
            {
                if (item == elem)
                    result = true;
            }
            return result;
        }

        public void RemoveByIndex(int index)
        {
            index -= 1;
            actorArr.RemoveAt(index);
        }
    }
}
