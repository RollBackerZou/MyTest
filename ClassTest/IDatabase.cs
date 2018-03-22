using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public interface IDatabase
    {
        string DbName { get; }
        void Select();
        void Update();
        void Delete();
        void Add();
    }

    public interface IShow
    {
        void Show();
    }
}
