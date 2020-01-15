namespace EjemploCadenaResponsabilidad.Interfaces
{
    public interface IAutorizaSolicitud
    {
        IAutorizaSolicitud SetNext(IAutorizaSolicitud autorizaSolicitud);
        void Autorizar(object _isolicitud,string _cConcepto);
    }
}
