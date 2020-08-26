using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWindowForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainform mainform = new Mainform();
            mainform.ShowDialog();
            Console.ReadKey();
        }
    }
}
