using System;

namespace Mocking
{
    public class Repository
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public virtual int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
