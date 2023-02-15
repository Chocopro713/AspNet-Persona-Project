using PersonalWebProject.Models;

namespace PersonalWebProject.Services
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {

        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO()
                {
                    Titulo = "Amazon",
                    Descripcion = "Ë-Commerce realizado",
                    Link = "https://amazon.com",
                    ImagenUrl = "/imagenes/amazon.png"
                },
                new ProyectoDTO()
                {
                    Titulo = "New York Time",
                    Descripcion = "Periodico para la gente",
                    Link = "https://nytimes.com",
                    ImagenUrl = "/imagenes/nytime.jpg"
                },
                new ProyectoDTO()
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenUrl = "/imagenes/reddit.png"
                },
                new ProyectoDTO()
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    Link = "https://store.steam.com",
                    ImagenUrl = "/imagenes/steam.jpg"
                },
            };
        }
    }
}
