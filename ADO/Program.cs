using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.Connection();
            Console.ReadLine();
        }
    }
}
