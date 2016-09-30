using System.Collections.Generic;

namespace PipServices.Data.Interfaces
{
    public interface ISaver<in T>
        where T : class
    {
        void Save(string correlationId, IEnumerable<T> items);
    }
}
