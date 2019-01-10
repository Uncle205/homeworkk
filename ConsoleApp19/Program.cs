using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.Common;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
           
     
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["AlphaConnectionStrings"].ProviderName);
       

        }
    }
}
