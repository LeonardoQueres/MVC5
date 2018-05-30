using Rgb.Curso.Infra.Data.Repository.Contextos;
using RGB.curso.Infra.Data.Contextos;
using RGB.curso.Infra.Data.Interfaces;
using System;

namespace RGB.curso.Infra.Data.UoW
{
    public class UnityOfWork : IUnityOfWork
    {

        private readonly ContextoEF contexto;
        private readonly ContextoADO contextoADO;
        private Boolean disposed;

        public UnityOfWork(ContextoEF _contexto, ContextoADO _contextoADO)
        {
            contexto = _contexto;
            contextoADO = _contextoADO;
        }

        public void BeginTransaction()
        {
            disposed = false;
        }

        public void Commit()
        {
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    contexto.Dispose();
                    contextoADO.Dispose();
                }
            }
            disposed = true;
        }
    }
}
