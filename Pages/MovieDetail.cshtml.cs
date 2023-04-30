//EN ESTA PAGINA VAMOS A TENER EL DETALLE DE NUESTRA PELICULA

using TestProject_Practice3VOriginal.Models;
using TestProject_Practice3VOriginal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestProject_Practice3VOriginal.Pages
{
    public class MovieDetailModel : PageModel
    {
        public Movie MovieDetail { get; set; } = new();// (15) MODELO DE TIPO MOVIE PARA REPRESENTAR TODAS LAS PROPIEADDES QUE TENEMOS DE LA PELICULA
        // Hay que instanciar esta clase.
        public void OnGet(string code) // Nos debería traer el codigo de la pelicula / razor page lo identifica.

        // *VA A A RECIBIR EL CODIGO DE LA PELICULA
        // * CON EL SERVICIO
        // TODO ES BLOQUE LO VA A PONER EN LA PROPIEDAD QUE DEFINIMOS ARRIBA (15)


        { // (15)
            if (code != null)
            {// si es distinto de null vamos a llamar al servicio
                var responseServiceData = MovieService.Get(code); // lo vamos a a traer enviando el codigo.
                if (responseServiceData != null)
                { // si es distinto de null hacemos la asignacion.
                    MovieDetail = responseServiceData;
                }
            }
        }

        public IActionResult OnPostDelete(string code)
        {// RECIBE STRING DE PARAMETRO QUE SE LLAMA CODE, EN ESE METODO VAMOS A LLAMAR AL SERVICIO.
            if (code != null)
            { // CODIGO NO NULO
                MovieService.Delete(code); // IMPLEMENTAMOS EN EL SERVICIO EL DELETE (MOVIE SERVICE)
            }

            return RedirectToPage("Index"); // AL BORRARLA NOS DIRECCIONA EL INDEX
        }
    }
}
