﻿using EjemploCadenaResponsabilidad.Abstracta;
using System;

namespace EjemploCadenaResponsabilidad.Departamentos
{
    public class AutorizaGerente : AbstracHandler
    {
        public override void Autorizar(object _isolicitud, string _cConcepto)
        {
            try {
                if (Convert.ToInt32(_isolicitud) > 5000 && Convert.ToInt32(_isolicitud) <= 10000)
                {
                    Console.WriteLine(" Compra de {0} Autorizado por el Gerente \n", _cConcepto);
                }
                else
                {
                    if (base._SiguenteAutorizacion != null)
                    {
                        base._SiguenteAutorizacion.Autorizar(_isolicitud, _cConcepto);
                    }
                }
            } catch {
                Console.WriteLine(" Dato ingresado Incorrecto!!! verifique!!\n");
            }          
            
        }
    }
}
