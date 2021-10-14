using System;
using Project.App.Dominio;
using Project.App.Persistencia; 

namespace Project.App.Consola
{
    class Program
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            AddEstudiante();
            //AddProfesor();  
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

        private static void AddEstudiante()
        {
            var estudiante = new Estudiante
            {  
               nombre = "Carlos",
               apellidos = "Perez",
               identificacion = "104577867",
               edad = 23,
               diagnostico = null,
               vacuna = null,
               carrera = "Ingenieria",
               semestre = "Quinto"
            };

            Console.WriteLine("Nombre: " + estudiante.nombre + "\n Apellido = " + estudiante.apellidos);
            Estudiante estudiante_retornado = _repoEstudiante.AddEstudiante(estudiante); 
            if (estudiante_retornado!=null)
                Console.WriteLine("Se registró un estudiante en la base de datos");
        }

    }
}
