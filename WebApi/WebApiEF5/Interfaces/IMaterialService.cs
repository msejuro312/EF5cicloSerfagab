using WebApiEF5.Models;

namespace WebApiEF5.Interfaces
{
    public interface IMaterialService
    {
        List<Material> list();
        Material getById(int IdMaterial);
        bool insert(Material material);
        bool update(Material material);
        bool delete(int IdMaterial);
    }
}
