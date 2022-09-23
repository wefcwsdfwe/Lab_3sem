using System;
using System.Management.Instrumentation;


namespace consoleApplication1
{
    public class Tank
    {
        private double x;
        private double y;
        private double angle;
        
        public Tank(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int NewCordinate_X, int NewCordinate_Y)
        {
           
            if (this.angle != 0)
            {
                double New_X, New_Y;
                New_X = NewCordinate_X * Math.Cos(angle);
                New_Y = NewCordinate_Y * Math.Sin(angle);
                
                this.x += New_X;
                this.y += New_Y;
                this.angle = 0;
            }
            else
            {
                this.x += NewCordinate_X;
                this.y += NewCordinate_Y;
            }
            Console.WriteLine($"{"("} {this.x} {";"} {this.y} {")"}");
        }

        public void Rotate(double angle)
        {
            // double New_X, New_Y;
            // New_X = x * Math.Cos(angle);
            // New_Y = y * Math.Sin(angle);
            //
            // this.x = New_X;
            // this.y = New_Y;
            //
            // Console.WriteLine($"{"("} {this.x} {";"} {this.y} {")"}");
            bool flag = true;
            if (flag == false)
            {
                this.angle = angle;
            }
            else
            {
                this.angle = angle;
                flag = false;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Tank T34 = new Tank(0, 0);
                T34.Move(2, 3);
                T34.Move(-1, 2);
                T34.Rotate(Math.PI/4);
                T34.Move(1, 8);
                T34.Move(2, 3);
                
            }
        }
    }
}