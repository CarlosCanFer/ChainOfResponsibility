using EjemploCadenaResponsabilidad.Abstracta;
using System;

namespace EjemploCadenaResponsabilidad.Departamentos
{
    public class AutorizaDirector : AbstracHandler
    {
        public override void Autorizar(object _isolicitud)
        {
            try {
                if (Convert.ToInt32(_isolicitud) > 15000 && Convert.ToInt32(_isolicitud) <= 50000)
                {
                    Console.WriteLine(" Autorizado por Director\n");
                }
                else
                {
                    Console.WriteLine(" Solicitud Denegada\n");
                }
            } catch {
                Console.WriteLine(" Dato ingresado Incorrecto!!! verifique!!\n");
            }
           
        }
    }
}
