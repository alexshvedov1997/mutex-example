using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mutexTrain
{
    class ShareResult
    {
    static    public int Count;
     static   public Mutex mtx = new Mutex();

    }
}
