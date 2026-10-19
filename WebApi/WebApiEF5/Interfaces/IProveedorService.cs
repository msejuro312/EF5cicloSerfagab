using WebApiEF5.Models;

namespace WebApiEF5.Interfaces
{
    public interface IProveedorService
    {
        List<Proveedor> list();
        Proveedor getById(int IdProveedor);
        bool insert(Proveedor proveedor);
        bool update(Proveedor proveedor);
        bool delete(int IdProveedor);
    }
}