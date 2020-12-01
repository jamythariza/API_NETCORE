namespace estimador.Application.Commom.Interfaces
{
    public interface IApplicationDbContext
    {
        IProductoRepository ProductoRepository { get; set; }
    }
}
