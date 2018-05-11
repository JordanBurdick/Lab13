using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13JordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {
            int car1Speed = 20;
            int car2Speed = 0;
            Car car1 = new Car("Ford", "Focus", 2010, car1Speed);
            Car car2 = new Car("Chevy", "Cruze", 2018, car2Speed);

            for (int i = 0; i <60; i++)
            {
                if (i % 2 == 0)
                {
                    car2Speed = car2.SpeedUp();
                }
                if (i % 3 == 0)
                {
                    car1Speed = car1.SpeedUp();
                }
                if (i % 5 == 0)
                {
                    car1Speed = car1.SlowDown();
                    car2Speed = car2.SlowDown();
                }
            }
            car1.Display();
            car2.Display();



            //pls
        }
    }
}
