using System;
using System.Collections.Generic;
using System.Text;

namespace Waterlog.Database
{
    public interface IDataReader
    {
        int Add<T>(T input);
        int Update<T>(T input);
        int Delete<T>(T input);
        T GetById<T>(int input);
        IEnumerable<T> GetAll<T>() where T : class;
    }
}
