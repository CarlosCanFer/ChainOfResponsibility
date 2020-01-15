using EjemploCadenaResponsabilidad.Departamentos;
using System;

namespace EjemploCadenaResponsabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            AutorizaCoordinador objcoordinador = new AutorizaCoordinador();
            AutorizaGerente objgerente = new AutorizaGerente();
            AutorizaSubdirector objsubdirector = new AutorizaSubdirector();
            AutorizaDirector objdirector = new AutorizaDirector();

            string _cmonto, _cconcepto;

            objcoordinador.SetNext(objgerente).SetNext(objsubdirector).SetNext(objdirector);

            Console.WriteLine(" Preciona s para Salir");
            do
            {               
                Console.WriteLine("-------------------------------");
                Console.WriteLine(" Inserte el concepto de la compra..");
                _cconcepto = Console.ReadLine();
                Console.WriteLine(" Inserte monto de solicitud");
                _cmonto = Console.ReadLine();

                objcoordinador.Autorizar(_cmonto,_cconcepto);
            } while (_cmonto != "s");



            Console.ReadKey();
        }
    }
}
