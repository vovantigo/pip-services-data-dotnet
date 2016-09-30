using System;

namespace PipServices.Data.Interfaces
{
    public interface IGetter<out T, in TI>
        where T : class
        where TI : class
    {
        T GetOneById(string correlationId, TI id);
    }
}
