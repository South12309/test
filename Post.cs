using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Post:BlogEssence
    {        
        string text;
        public Post(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        override public string CreateMailText()
        {
            return "Добавлен пост" + name;
        }



        override public string CreateQuery()
        {
            string query = "";
            // Создание запроса
            return query;
        }

        override public bool IfNotExist()
        {          

            return true;

        }

    }
}
