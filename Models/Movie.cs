// VAMOS A HACER UN CRUD DE PELICULAS.
// NUESTRA CLASE MOVIE PARA PODER REPRESENTAR LAS PELICULAS

using System.ComponentModel.DataAnnotations;

namespace TestProject_Practice3VOriginal.Models;

//declaración de clase
public class Movie
{
    //vamos a definir las propiedades
    public string Code { get; set; } // para identificar la pelicula

    //10 . AGREGACIÓN DE ANOTACIONES.
    [Display(Name = "Nombre")]
    [Required] // Libreria que me permite agregar distintas funcionalidades al MODELO.
    public string Name { get; set; }
    [Range(5, 600)]
    // por abajo de 5 y arriba de 600 modelo invalido.
    public int Minutes { get; set; }

    public string Category { get; set; }


    public string Review { get; set; }


} // nuestro modelo definido.

//