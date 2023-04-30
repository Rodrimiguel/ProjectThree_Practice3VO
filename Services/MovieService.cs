// SERVICIOS (ES UNA CLASE QUE VA A TENER METODOS DE ACCESO A DATOS. CREAR, ELIMINAR UNA DATO. POR ESO DEBEMOS ACCEDER A LAS LISTA, EN ESTE CASO, PELICULAS.)
// MODELOS LOS USAMOS PARA MODELOR LOS OBJETOS QUE VAMOS A USAR EN NUESTRO PROYECTO.
// SERVICIOS (VAMOS A UTILIZAR PARA QUE SE APLIQUE LOGICA DE NEGOCIO Y EL ACCESO A DATOS)
// CARPETAS EN PLURAL Y CLASES EN SINGULAR.
// CLASES ESTATICAS (NO LA VAMOS A INSTANCIAR) VAMOS A HACER UNA PROPIEDAD Y METODOS ESTATICOS.
// VAMOS UTILIZAR UNA LISTA COMO SI FUERA NUESTRA BASE DE DATOS.

using TestProject_Practice3VOriginal.Models; // Reconocimiento de clase movie, tengo que hacer un using (importar el namespace) (CARPETA MODELS RECONOCIMIENTO)
namespace TestProject_Practice3VOriginal.Services; // Nombre del proyecto y nombre de la carpeta.

public class MovieService
{

    static List<Movie> Movies { get; set; }

    static MovieService()
    { // 1 Instanciamos datos en nuestra propiedad movie.
        Movies = new List<Movie>
        {
            new Movie {Name = "Back to the future", Code = "BT", Category = "Sci fi", Minutes = 110},
            new Movie {Name = "Casino Royale", Code = "CR", Category = "Action", Minutes = 140, Review = "Una Obra Maestra que maneja a la perfección diferentes géneros: acción, espionaje, drama y romance."},
            new Movie {Name = "The Equalizer", Code = "EZ", Category = "Action", Minutes = 130},
        };
        // 2 EN NUETRO CONSTRUCTOR TENEMOS INSTANCIA UNA LISTA (PROPIEDAD CON ESTOS DATOS) Y LO VAMOS A PODER UTILIZAR.

        // 3 NECESITMOS HACER GET ALL (TRAER/LISTAR TODAS NUESTRA PELICULAS)

        // 4 VAMOS A EMPEZAR NUESTRO HOME/LISTA DE NUESTRAS PELICULAS (CON LA LISTA DE LAS PELICUAS)
        // COMO VAMOS A HACER PARA USAR NUESTRO SERVICIO EN EL HTML.
    }

    public static List<Movie> GetAll() => Movies; // ME VA A DEVOLVER LA LISTA MOVIES.



    //  ADD METODO AGREGAR, DELETE, UPDATE

    //12 VAMOS A HACER EL CREATE / AGREGACION ELEMENTOS DE LA LISTA
    public static void add(Movie obj)
    {
        if (obj == null)
        {// OSEA NO TRAE NADA
            return;
        }// SI NO SE CUMPLE CONDICION


        Movies.Add(obj); // OBJETO ME TRAE ALGO.
    }

    /**/

    public static void Delete(string code)
    {// 16 NO ME VA A DEVOLVER NADA. RECIBE DE PARAMETRO EL CODIGO DE LA PELICULA
        var movieToDelete = Get(code);

        if (movieToDelete != null)
        {// ES DISTINTO A NULL (PORQUE ENCONTRO UN DOCUMENTO/ VAMOS A ACCEDER AL LISTADO)
            Movies.Remove(movieToDelete);
        }
    }



    /**/




    // Con el Code (codigo) nos va a devolver la pelicula que corresponde a ese codigo.
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());

    // internal static void Delete(string code)
    // {
    //     throw new NotImplementedException();
    // }
    // // traeme el primer elemento de la lista, me lo trae y sino lo encuentra default (va a ser nulo)
    // //traernos el primer elemento que coincida de la lista
}


//////http://localhost:5175/MovieDetail?code=CR