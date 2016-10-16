using CafeAlessio.Data;
using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain;
using CafeAlessio.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Service.Concrete
{
    public class DatabaseService
    {
        public static void InitDB()
        {
            Utils.InitDB();
        }
    }
}
