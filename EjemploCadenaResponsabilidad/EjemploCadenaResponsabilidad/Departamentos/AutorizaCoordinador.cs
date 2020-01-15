using EjemploCadenaResponsabilidad.Abstracta;
using System;

namespace EjemploCadenaResponsabilidad.Departamentos
{
    public class AutorizaCoordinador : AbstracHandler
    {
        public override void Autorizar(object _isolicitud)
        {
            try {
                if (Convert.ToInt32(_isolicitud) <= 5000)
                {
                    Console.WriteLine(" Se autoriza por el Coordinador \n");
                }
                else
                {
                    if (base._SiguenteAutorizacion != null)
                    {
                        base._SiguenteAutorizacion.Autorizar(_isolicitud);
                    }

                }
            } catch {
                Console.WriteLine(" Dato ingresado Incorrecto!!! verifique!!\n");
            }
            
        }

    }
}
