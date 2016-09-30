using System.Collections.Generic;

namespace PipServices.Data.Interfaces
{
    public interface ILoader<out T>
        where T : class
    {
        IEnumerable<T> Load(string correlationId);
    }
}
