using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Category:BlogEssence
    {
              

        Category(string name)
        {
            this.name = name;            
        }

        override public string CreateMailText()
        {
            return "Добавлена категория" + name;
        }



        override public string CreateQuery()
        {
            string query="";
            // Создание запроса
            return query;
        }

        override public bool IfNotExist()
        {
            bool ifExist = false;

            // Некий код проверки существования такой категории

            return ifExist;

        }
    }
}
