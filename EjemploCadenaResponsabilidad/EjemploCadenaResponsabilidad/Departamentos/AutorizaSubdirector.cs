using EjemploCadenaResponsabilidad.Abstracta;
using System;

namespace EjemploCadenaResponsabilidad.Departamentos
{
    public class AutorizaSubdirector : AbstracHandler
    {
        public override void Autorizar(object _isolicitud)
        {
            try {
                if (Convert.ToInt32(_isolicitud) > 10000 && Convert.ToInt32(_isolicitud) <= 15000)
                {
                    Console.WriteLine(" Se autoriza por el subdirector \n");
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
