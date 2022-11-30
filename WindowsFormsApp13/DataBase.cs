using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    internal class DataBase
    {

        public static string GetAnsver(string question)
        {
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                string str = null;
                while (true)
                {
                    str = fs.ToString();
                    if (str != null)
                    {
                        if (str == question)
                            return " есть такая заметка";
                    }
                    else
                        return " нет такой заметки";
                }
            }
        }
    }
}
