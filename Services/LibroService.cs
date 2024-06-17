using AnahiQuezadaEjemploMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnahiQuezadaEjemploMVVM.Services
{
    public class LibroService : ILibroService
    {
        public List<Libro> ObtenerLibro()
        {
            return new List<Libro>
            {
            new Libro { Titulo = "Libro1", Autor = "autor1" },
            new Libro { Titulo = "Libro2", Autor = "autor2" },
            new Libro { Titulo = "Libro3", Autor = "autor3" },
            new Libro { Titulo = "Libro4", Autor = "autor4" },
            new Libro { Titulo = "Libro5", Autor = "autor5" }
            };

        }

    }
}
