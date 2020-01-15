using EjemploCadenaResponsabilidad.Interfaces;

namespace EjemploCadenaResponsabilidad.Abstracta
{
    public abstract class AbstracHandler : IAutorizaSolicitud
    {
        protected IAutorizaSolicitud _SiguenteAutorizacion;
        public IAutorizaSolicitud SetNext(IAutorizaSolicitud autorizaSolicitud)
        {
            this._SiguenteAutorizacion = autorizaSolicitud;

            return autorizaSolicitud;
        }
        public virtual void Autorizar(object _isolicitud)
        {
            if (this._SiguenteAutorizacion != null)
            {
                this._SiguenteAutorizacion.Autorizar(_isolicitud);
            }            
        }       
    }
}
