using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
   public class DataManager
    {
        private IDatabase _database;
        private IShow _show;
        public DataManager(IDatabase database,IShow show)
        {
            this._database = database;
            this._show = show;
        }

       public void Show()
        {
            _show.Show();
        }

        public void Add()
        {
            _database.Add();
        }

        public void Delete()
        {
            _database.Delete();
        }

        public void Update()
        {
            _database.Update();
        }

        public void Select()
        {
            _database.Select();
        }
    }

}
