using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data
{
    public class Utils
    {
        public static void InitDB()
        {
            Database.SetInitializer<AlessioContext>(new AlessioInitializer());
        }
    }
}
