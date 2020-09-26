using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Waterlog.Database
{
    public class SqliteReader : IDataReader, IDisposable
    {
        private DbContextOptions<SqliteContext> options;
        private SqliteContext context;

        public SqliteReader()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqliteContext>();
            optionsBuilder.UseSqlite("Data Source=aquarium.db");
            options = optionsBuilder.Options;
            context = new SqliteContext(options);
        }

        public int Add<T>(T input)
        {
            throw new NotImplementedException();
        }

        public int Delete<T>(T input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return context.Set<T>().ToList();
        }

        public T GetById<T>(int input)
        {
            throw new NotImplementedException();
        }

        public int Update<T>(T input)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
