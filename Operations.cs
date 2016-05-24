using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public static class Operations
    {
        public static int Createcar(int SNO,string NAME, int MODEL,int PRICE)
        {
            int a = DataBaseOperations.Createcar(SNO, NAME, MODEL, PRICE);
            return a;
        }
        public static int Updatecar(int SNO, string NAME, int MODEL, int PRICE)
        {
            int a = DataBaseOperations.Updatecar(SNO, NAME, MODEL, PRICE);
            return a;
        }
        public static int Deletecar(int SNO)
        {
            int a = DataBaseOperations.Deletecar(SNO);
            return a;
        }
    }
}
