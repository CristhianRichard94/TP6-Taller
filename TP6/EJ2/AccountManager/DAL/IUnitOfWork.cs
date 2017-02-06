using System;

namespace AccountManager.DAL
{
    public interface IUnitOfWork : IDisposable
    {

        IAccountRepository AccountRepository { get; }

        IClientRepository ClientRepository { get; }

        void Complete();

    }
}
