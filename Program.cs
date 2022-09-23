using System;
using System.Management.Instrumentation;


namespace consoleApplication1
{
    public class Tank
    {
        public int x;
        public int y;
        
        public Tank(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Manevr(Tank T)
        {
            // if (...) {x+-1}
            // if (...){y+-1}
        }

        class Program
        {
            static void Main(string[] args)
            {
                Tank T34 = new Tank();
                T34.SetCoordinates(0, 0);
            }
        }
    }
}