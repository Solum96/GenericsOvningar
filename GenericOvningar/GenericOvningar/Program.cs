using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ÖVING 1

            Jewel jewel = new Jewel(2000);

            Safe<Jewel> mySafe = new Safe<Jewel>();
            mySafe.Store(jewel);

            Console.WriteLine(mySafe.Retrieve().Worth);
            Console.ReadKey(); */

            /* ÖVNING 2 
            
            List<double> myList = new List<double>();
            Random rng = new Random();
            RandomDoubleCreator myRandom = new RandomDoubleCreator();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(RandomDoubleCreator.GetRandomNumber(1, 101));
            }
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(); */


        }
    }
}
