using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    internal class Model
    {
        public string GetAnsver(string qustion)
        {
            {
                return DataBase.GetAnsver(qustion);
            }
        }
    }
}
