using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mutexTrain
{
    class IncMtx
    {
       public Thread thrd;
       // ShareResult shr = new ShareResult();
        int num;
         public IncMtx(int num, string name) {
            thrd = new Thread(Run);
            thrd.Name = name;
            this.num = num;
            thrd.Start();
        }
        void Run()
        {
            Console.WriteLine("Ожидание мьютекса");
            // shr.mtx.WaitOne();
            ShareResult.mtx.WaitOne();
            Console.WriteLine("Мьютекс получен");
            do
            {
                // shr.Count++;
                ShareResult.Count++;
                Console.WriteLine(thrd.Name + "= " + ShareResult.Count);
                num--;
                Thread.Sleep(100);
            } while (num > 0);
            ShareResult.mtx.ReleaseMutex();
            //shr.mtx.ReleaseMutex();
        }

    }
}
