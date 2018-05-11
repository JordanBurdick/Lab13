using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13JordanBurdick
{
    class Car
    {

        private int Speed;
        private string Make;
        private string Model;
        private int Year;

        public Car(string Make, string Model, int Year, int Speed)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Speed = Speed;
        }

        public Car(string Make, string Model, int Speed = 0)
        {
            this.Make = Make;
            this.Model = Model;
            this.Speed = Speed;
        }

        public int SpeedUp()
        {
            Speed += 1;
            //Console.WriteLine(Make + Model + Speed + " Mph");
            return Speed;
        }

        public int SlowDown()
        {
            if (Speed > 0)
            {
                Speed -= 1;
            }
            else
            {
                Console.WriteLine("Car is already stopped.");
            }
            return Speed;
        }
        //brings speed to 0 over time
        public void Stop()
        {
            while (Speed > 0)
            {
                Speed -= 1;
            }
        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }





        //pls
    }
}
