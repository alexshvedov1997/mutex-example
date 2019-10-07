using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutexTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            IncMtx mt1 = new IncMtx(5, "Мьютекс 1");
            DecMtx mtx2 = new DecMtx(5, "Мьютекс 2");
            mtx2.thrdD.Join();
            mt1.thrd.Join();
        }
    }
}
