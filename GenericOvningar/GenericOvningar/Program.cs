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

            /* ÖVNING 3
             
            Mammal dog = new Dog("Berta");
            Mammal cat = new Cat();
            Bird crow = new Crow();
            Reptile snake = new Snake();

            Dictionary<string, Animal> myDictionary = new Dictionary<string, Animal>();
            myDictionary.Add("Dog", dog);
            myDictionary.Add("Cat", cat);
            myDictionary.Add("Bird", crow);
            myDictionary.Add("Snake", snake);

            Console.WriteLine(myDictionary["Dog"]);
            Console.ReadKey(); */

            Dog dog1 = new Dog("Berta");
            Dog dog2 = new Dog("Saga");
            Cat cat1 = new Cat("Grå");

            StackALot<Animal> myStack = new StackALot<Animal>();

            myStack.Push(dog1);
            myStack.Push(dog2);
            myStack.Push(cat1);

            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.ReadKey();

            Stack<Animal> myStack2 = new Stack<Animal>();
            myStack2.Push(dog1);
            myStack2.Push(dog2);
            myStack2.Push(cat1);

            //Console.WriteLine(myStack2.Pop());
            //Console.WriteLine(myStack2.Pop());
            //Console.WriteLine(myStack2.Pop());

            
        }
    }
}
