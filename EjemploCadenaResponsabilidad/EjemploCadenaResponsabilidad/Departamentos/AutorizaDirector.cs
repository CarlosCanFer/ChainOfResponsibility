using EjemploCadenaResponsabilidad.Abstracta;
using System;

namespace EjemploCadenaResponsabilidad.Departamentos
{
    public class AutorizaDirector : AbstracHandler
    {
        public override void Autorizar(object _isolicitud, string _cConcepto)
        {
            try {
                if (Convert.ToInt32(_isolicitud) > 15000 && Convert.ToInt32(_isolicitud) <= 50000)
                {
                    Console.WriteLine(" Compra de {0} Autorizado por Director\n",_cConcepto);
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
