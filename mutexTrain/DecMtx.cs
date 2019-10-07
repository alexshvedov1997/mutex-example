using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mutexTrain
{
    class DecMtx
    {
      public  Thread thrdD;
        ShareResult shrD = new ShareResult();
        int num;
        public DecMtx(int num, string name)
        {
            thrdD = new Thread(Run);
            thrdD.Name = name;
            this.num = num;
            thrdD.Start();
        }
        void Run()
        {
            Console.WriteLine("Ожидание мьтекса 2");
            // shrD.mtx.WaitOne();
            ShareResult.mtx.WaitOne();
            Console.WriteLine("Получение мьютекса");
            do
            {
                //  shrD.Count--;
                ShareResult.Count--;
                Console.WriteLine(thrdD.Name + "=" + ShareResult.Count);
                Thread.Sleep(100);
                num--;
            } while (num > 0);
            // shrD.mtx.ReleaseMutex();
            ShareResult.mtx.ReleaseMutex();
            Console.WriteLine("Мьютекс 2 завершен");

        }
    }
}
