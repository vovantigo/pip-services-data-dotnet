using System;

namespace PipServices.Data.Interfaces
{
    public interface ISetter<T>
        where T : class
    {
        T Set(string correlationId, T entity);
    }
}
