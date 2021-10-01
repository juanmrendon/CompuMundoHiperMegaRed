using System;
using Project.App.Dominio;
using Project.App.Persistencia; 

namespace Project.App.Consola
{
    class Program
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            
            AddProfesor();  
            //BuscarProfesor(1);
            //BuscarProfesor(2); 
            //EliminarProfesor(4); 
            //BuscarProfesores()         
        }


        //AddProfesor

        private static void AddProfesor()
        {
            var profesor = new Profesor
            {  
               nombre = "Fabián",
               apellidos = "Dominguez",
               identificacion = "1000566777",
               edad = 32,
               diagnostico = null,
               vacuna = null,
               departamento = "Humanidades",
               materia = "Metodología de la Investigación"
            };

            Console.WriteLine("Nombre: " + profesor.nombre + "\n Apellido = " + profesor.apellidos);
            Profesor profesor_retornado = _repoProfesor.AddProfesor(profesor); 
            if (profesor_retornado!=null)
                Console.WriteLine("Se registró un profesor en la base de datos");
        }

    }
}
