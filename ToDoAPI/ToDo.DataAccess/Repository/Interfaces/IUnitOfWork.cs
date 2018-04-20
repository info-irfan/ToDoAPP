using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.DataAccess.Repository.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        ToDoDBContext Context { get; }
        void Commit();
    }
}
