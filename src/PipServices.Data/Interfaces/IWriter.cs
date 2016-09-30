namespace PipServices.Data.Interfaces
{
    public interface IWriter<T, in TI>
    {
        T Create(string correlationId, T entity);
        T Update(string correlationId, T entity);
        T DeleteById(string correlationId, TI id);
    }
}
