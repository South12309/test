using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Db:IDb
    {
        public Db()
        {
            //код инициализации базы
        }
        public bool ExecuteSQL(string query)
        {
            bool result = true;
            
            //Код выполнения sql

            return result;
        }
    }
}
