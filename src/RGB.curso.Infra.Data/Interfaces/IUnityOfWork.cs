using System.Collections.Generic;

namespace RGB.curso.Infra.Data.Interfaces
{
    public interface IUnityOfWork
    {
        void BeginTransaction();
        void Commit(List<string> listaErros);
    }
}
