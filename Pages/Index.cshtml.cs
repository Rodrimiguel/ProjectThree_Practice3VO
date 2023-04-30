using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestProject_Practice3VOriginal.Models; //************************************************************** //////
using TestProject_Practice3VOriginal.Services;

namespace TestProject_Practice3VOriginal.Pages;

// 5. VAMOS A PONER UNA PROPIEDAD DE NUESTRO PAGE MODEL QUE SEA DEL TIPO PUBLICA Y QUE TENGA LISTADO DE PELICULAS QUE REPRESENTE EN MI HTML


public class IndexModel : PageModel
{

    public List<Movie> MovieList { get; set; } // ACCEDER A LOS DATOS, PARA PODER SETEARLOS.

    [BindProperty] // (13) ETIQUETA BINDPROPERTY VAMOS A TENER MEPEADO LA PROPIEDAD NEWMOVIE
    public Movie NewMovie { get; set; } // 9 DEBEMOS CREAR UNA PROPIEDAD QUE ME MAPEE CON EL FORMULARIO QUE ME TRAJE DE BOOPSTRAP (MAPEAR CON CSHTML)
    public IndexModel()
    {
        // Constructor del page model no lo vamos a utlizar, pero si llenar esta lista de peliculas, con los datos que tenemos de nuestas peliculas con la base de datos.
        // 6 .LO HACEMOS CON GET
    }

    public void OnGet()
    {   // control + punto SOBRE MOVIE SERVICE para agregar el using // SE AGREGA ARRIBA AUTOMATICAMENTE.
        MovieList = MovieService.GetAll(); // DEBEMOS TRAER NUESTROS DATOS QUE TENEMOS EN ALGUN LADO. (ME TRAE TODO LOS DATOS)
        // SI NUESTRO METODO GET ALL EN MOVIE SERVICE ESTARIA PRIVADO, NO PODRIA ACCEDER EL GET ALL.
    }

    public IActionResult OnPost()
    {// 13 ACA VAMOS A RECIBIR LA INFORMACION DEL FORMULARIO, A TRAVES DEL MODELO QUE ESTA EN CLASE, PERO ANTES LA MAPEAMOS.
        if (!ModelState.IsValid) // SE VERIFICA QUE EL MODELO DE LA PAGINA ES VALIDO ( SE REFIERE A TODO EL MODELO ES VALIDO ) por ejemplo los minutos de la pelicula. como es invalido me va a entrar.
            return RedirectToPage("/Error"); // ME GENERA UNA ACCION HTTP NUEVA. 
                                             // SI EL MODELO ES INVALIDO VA A ENTRAR A ESTE GET Y ME VA A HACER UNA LLAMADA GET
        MovieService.add(NewMovie); // VAMOS A LLAMAR AL SERVICIO
        return RedirectToAction("get"); // LLAMADA GET PARA REFRESCARME LA PAGINA.
    }
    // LA LLAMADA GET ME HACE UN GET ALL/ SI ME LO MOSTRO ES PORQUE ESTA DENTRO DE LA LISTA.










}
