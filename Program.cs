using System;



namespace consoleApplication1
{

    public class Tank
    {
        protected string Name;
        protected int Boekomplekt;
        protected int LvlManevr;

        public Tank(int boekomplekt, int lvlManevr, string name)
        {

            this.Boekomplekt = boekomplekt;
            this.LvlManevr = lvlManevr;
            this.Name = name;
        }

        public Tank()
        {
            Boekomplekt = 0;
            LvlManevr = 0;
            Name = "null";
        }

        public void Print()
        {
            Console.WriteLine("name - " + Name);
            Console.WriteLine("boekomplekt = " + Boekomplekt + " lvlManevr = " + LvlManevr);
        }

        class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}