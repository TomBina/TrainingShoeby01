using System.Collections.Generic;

namespace TrainingShoeby02
{
    public abstract class Repository<T>
    {
        public abstract List<T> GetAll();
    }
}