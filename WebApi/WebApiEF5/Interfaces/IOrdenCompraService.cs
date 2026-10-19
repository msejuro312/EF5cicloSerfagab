using WebApiEF5.Models;

namespace WebApiEF5.Interfaces
{
    public interface IOrdenCompraService
    {
        List<OrdenCompra> list();
        OrdenCompra getById(int IdOrdenCompra);
        int insert(OrdenCompra orden);
        bool delete(int IdOrdenCompra);
        int recepcionar(int IdOrdenCompra);
    }
}