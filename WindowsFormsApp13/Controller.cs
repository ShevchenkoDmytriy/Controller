using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    internal class Controller
    {
        public async Task AddAsync(string msg)
        {
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs,msg);
            }
        }
    }
}
