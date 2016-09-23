using System;
using System.Threading;

namespace SampleService
{
    public class SampleService
    {
        public void Start()
        {
            Thread.Sleep(new Random().Next(2000, 3000));
        }

        public void Stop()
        {
            Thread.Sleep(new Random().Next(2000, 3000));
        }
    }
}