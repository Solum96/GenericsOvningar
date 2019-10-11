using System;

namespace GenericOvningar
{
    public class RandomDoubleCreator
    {
        public static Random random = new Random();

        public static double GetRandomNumber(double minValue, double maxValue)
        {
            var randomNumber = random.NextDouble() * (maxValue - minValue) + minValue;
            return Math.Round(randomNumber, 3);
        }
    }
}