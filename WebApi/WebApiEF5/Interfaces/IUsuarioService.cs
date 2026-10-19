using WebApiEF5.Models;

namespace WebApiEF5.Interfaces
{
    public interface IUsuarioService
    {
        Usuario login(string usuario, string clave);
    }
}