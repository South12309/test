using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class BlogEssence
    {
        protected string name;
        public abstract bool IfNotExist();
        public abstract string CreateQuery();
        public abstract string CreateMailText();
        public void Save()
        {
            if (IfNotExist())
            {
                IDb db = new Db();
                db.ExecuteSQL(CreateQuery());
                IMail mail = new Mail();
                mail.SendMail(CreateMailText());
            }
        }
    }
}
