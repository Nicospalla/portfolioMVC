using PortfolioMVC.Models;

namespace PortfolioMVC.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> { new Proyecto
            {
                Titulo = "Gestión Estilistas",
                Descripcion = "Software integral de gestión para cadena de belleza desarrollado en C#. Cuenta con envío automático de whatsapp y mails recordatorios, diferentes niveles de usuario, control de caja, finanzas, toma de turnos, ventas y toda la informacion historial de los clientes.",
                ImagenUrl = "/images/MYLA.jpg",
                Link = "https://github.com/Nicospalla/Myla_Salon_"
            },new Proyecto
            {
                Titulo = "Éste Portolio MVC",
                Descripcion = " Portfolio personal desarrollado con patrón MVC utilizando C# y ASP.NET.",
                ImagenUrl = "/images/portfolio.png",
                Link = "http://nicolasspalla.somee.com/"
            },new Proyecto
            {
                Titulo = "Ecommerce ASP.NET WebForms",
                Descripcion = "Ecommerce desarrollado con WebForms, con soporte de DDBB SQLServer. Desarrollado como entrega final de un curso intgral de C# y ASP.NET.",
                ImagenUrl = "/images/frenteWebApp.png",
                Link = "http://webappnivel3.somee.com/Default.aspx"
            },new Proyecto
            {
                Titulo = "App de escritorio CRUD",
                Descripcion = "Gestión de inventario y catálogo de produtos en C#",
                ImagenUrl = "/images/ProductosCRUD2.png",
                Link = "https://github.com/Nicospalla/ProductosCRUD"
            },new Proyecto
            {
                Titulo = "APP Escritorio CRUD Pokemon",
                Descripcion = "Aplicacion CRUD de prueba con POKEMON",
                ImagenUrl = "/images/Pokemon.png",
                Link = "https://github.com/Nicospalla/pokemonApp"
            },new Proyecto
            {
                Titulo = "Juego estilo Alien Invasion",
                Descripcion = "Juego cervecero con un poco de gracia, al estilo Alien Invasion. Desarrollado en Python siguiendo las pautas de un libro.",
                ImagenUrl = "/images/AlienInvasion.png",
                Link = "https://github.com/Nicospalla/alien_invasion"
            },
            };
        }
    }
}
