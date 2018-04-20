using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Repository.Interfaces;

namespace ToDo.DataAccess.Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public ToDoDBContext Context { get; }

        public UnitOfWork(ToDoDBContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
